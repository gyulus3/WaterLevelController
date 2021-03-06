#pragma checksum "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e270cc4954bda07397debc54d3b37d18343bc3e9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WaterLevelControllerClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using WaterLevelControllerClient;

#line default
#line hidden
#line 7 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using WaterLevelControllerClient.Shared;

#line default
#line hidden
#line 8 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using WaterLevelControllerClient.Data.Dto;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/zonePage")]
    public partial class ZonePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 145 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
       
    const string baseUrl = "https://localhost:5001/api/";
    bool loaded = false;
    DtoZoneListItem[] zones;
    DtoZoneListItem selectedZone;
    DtoSensorListItem[] sensors;
    DtoCreateZone createZone = new DtoCreateZone();

    protected override async Task OnInitializedAsync()
    {
        await GetZones();
        await GetSensors();
        loaded = true;
    }

    protected async Task GetSensors()
    {
        if(selectedZone != null)
        {
            DtoSensorListItem[] loadedSensors = await Http.GetJsonAsync<DtoSensorListItem[]>(baseUrl + "zones/sensors/" + selectedZone.Id);
            if (loadedSensors != null && loadedSensors.Length > 0)
                sensors = loadedSensors;
            else sensors = null;
        }
        else
            sensors = null;
    }

    protected async Task GetZones()
    {
        DtoZoneListItem[] loadedZones = await Http.GetJsonAsync<DtoZoneListItem[]>(baseUrl + "zones");

        if (loadedZones != null && loadedZones.Length > 0)
        {
            zones = loadedZones;
            selectedZone = zones[0];
        }

        else
            zones = null;
    }

    protected void ClearCreateZone()
    {
        createZone = new DtoCreateZone();
    }

    protected async Task ZoneSelectorChanged(ChangeEventArgs e)
    {

        int selectedId = Convert.ToInt32(e.Value);
        bool found = false;
        int i = 0;
        while (!found && i < zones.Length)
        {
            if (zones[i].Id == selectedId)
            {
                selectedZone = zones[i];
            }
            i++;
        }
        await GetSensors();

    }

    protected async Task RefillAllClicked()
    {
        List<int> ids = new List<int>();
        foreach(var sensor in sensors)
        {
            ids.Add(sensor.Id);
        }
        await Http.PutJsonAsync(baseUrl + "refill", ids);
        await GetSensors();
    }

    protected async Task PostCreateZone()
    {
        await Http.PostAsJsonAsync(baseUrl + "zones", createZone);
        await GetZones();

    }

    protected async Task DeleteSelectedZone()
    {
        await Http.DeleteAsync(baseUrl + "zones/" + selectedZone.Id);
        await GetZones();
    }

    protected async Task EditSelectedZone()
    {
        await Http.PutJsonAsync(baseUrl + "zones", selectedZone);
        await GetZones();
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
