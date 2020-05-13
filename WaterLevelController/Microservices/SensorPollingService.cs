using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Linq;
using System;
using WaterLevelController.DAL.Interfaces;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using WaterLevelController.DAL.EfDbContext;
using Newtonsoft.Json;
using System.Net;

namespace WaterLevelController.Microservices
{
    public class SensorPollingService : BackgroundService
    {
        protected readonly IServiceScopeFactory _scopeFactory;
        protected readonly HttpClient httpClient = new HttpClient();
        public SensorPollingService(IServiceScopeFactory scopeFactory)
        {
            _scopeFactory = scopeFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            using (var scope = _scopeFactory.CreateScope())
            {
                var repository = scope.ServiceProvider.GetRequiredService<ISensorRepository>();
                IEnumerable<Sensor> sensors = repository.List();
                while (!stoppingToken.IsCancellationRequested)
                {
                    foreach(var sensor in sensors)
                    {
                        int data = await GetWaterAsync(sensor.Ip);
                        if (data != -1)
                        {
                            Sensor s = sensor;
                            s.Data = data;
                            repository.Update(s);
                        }
                    }
                    
                    await Task.Delay(50, stoppingToken);
                }

            }

        }

        protected async Task<int> GetWaterAsync(string ip)
        {
            using (var webClient = new System.Net.WebClient())
            {
                try
                {
                    var json = webClient.DownloadString("http://" + "localhost" + ":3000/data");
                    Sensor o = JsonConvert.DeserializeObject<Sensor>(json);
                    return o.Data;
                }
                catch
                {
                    return -1;   
                }

            }
        }
    }
}
