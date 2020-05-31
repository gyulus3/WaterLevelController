using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WaterLevelController.DAL.EfDbContext;
using WaterLevelController.DAL.Interfaces;
using WaterLevelController.Services;

namespace WaterLevelController.Microservices
{
    public class SwitchControllerService : BackgroundService
    {
        protected readonly IServiceScopeFactory _scopeFactory;
        protected readonly HttpClient httpClient = new HttpClient();
        public SwitchControllerService(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var sensorRepository = scope.ServiceProvider.GetRequiredService<ISensorRepository>();
                IEnumerable<Sensor> sensors = sensorRepository.List();
                while (!stoppingToken.IsCancellationRequested)
                {
                    foreach (var sensor in sensors)
                    {
                        Sensor s = sensor;
                        s.Data = await GetWaterAsync(sensor.Ip);
                        sensorRepository.Update(s);
                    }

                    foreach (var sensor in sensors)
                    {
                        if (!sensor.Data.Equals("N/A") && sensor.Schedule.Auto && int.Parse(sensor.Data) <= sensor.Schedule.MinWaterLevel)
                        {
                            RefillManager.add(sensor.Id);
                        }
                    }
                    List<int> remove = new List<int>();
                    foreach(int sensorId in RefillManager.getAll())
                    {
                        Sensor sensor = sensorRepository.GetById(sensorId);

                        if (sensor.Data.Equals("N/A"))
                        {
                            RefillManager.remove(sensorId);
                        }
                        else
                        {
                            if (int.Parse(sensor.Data) <= sensor.Schedule.MinWaterLevel)
                                await RefillAsync(sensor.Switch.Ip.ToString());
                            
                            if (int.Parse(sensor.Data) >= 95)
                            {
                                await StopRefillAsync(sensor.Switch.Ip.ToString());
                                remove.Add(sensorId);
                            }
                        }
                    }

                    foreach(int id in remove)
                    {
                        RefillManager.remove(id);
                    }
                    Console.WriteLine(RefillManager.getSize());
                    await Task.Delay(50, stoppingToken);
                }

            }

        }

        protected async Task<string> GetWaterAsync(string ip)
        {
            var client = new HttpClient();
            string jsonString;
            try
            {
                jsonString = client.GetStringAsync("http://" + "localhost" + ":3000/data").Result;
                client.Dispose();
                return JsonConvert.DeserializeObject<Sensor>(jsonString).Data;
            }
            catch
            {
                return "N/A";
            }
            
        }

        protected async Task RefillAsync(string ip)
        {
            //var client = new HttpClient();
            Console.WriteLine("http://" + ip + "/cm?cmnd=Power%20On");
            //await client.GetAsync("http://" + ip + "/cm?cmnd=Power%20On");
            //client.Dispose();
        }

        protected async Task StopRefillAsync(string ip)
        {
            //var client = new HttpClient();
            Console.WriteLine("http://" + ip + "/cm?cmnd=Power%20off");
            //await client.GetAsync("http://" + ip + "/cm?cmnd=Power%20off");
            //client.Dispose();

        }
    }
}
