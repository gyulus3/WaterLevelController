#pragma checksum "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SwitchPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "083bf6a4d0631fbad05714f15fccfa241fc98c6b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/switchPage")]
    public partial class SwitchPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 125 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SwitchPage.razor"
       
    const string baseUrl = "https://localhost:5001/api/";
    bool loaded = false;
    DtoSwitchListItem[] switches;
    int selectedId;
    DtoCreateSwitch createSwitch;
    DtoEditSwitch editSwitch;

    protected override async Task OnInitializedAsync()
    {
        await GetSwitches();
        loaded = true;
    }

    protected async Task GetSwitches()
    {
        DtoSwitchListItem[] loadedSwitches = await Http.GetJsonAsync<DtoSwitchListItem[]>(baseUrl + "switches");

        if (loadedSwitches != null && loadedSwitches.Length > 0)
        {
            switches = loadedSwitches;
        }

        else
            switches = null;
    }

    protected void ClearCreateSwitch()
    {
        createSwitch = new DtoCreateSwitch();
    }


    protected async Task PostCreateSwitch()
    {
        await Http.PostAsJsonAsync(baseUrl + "switches", createSwitch);
        await GetSwitches();

    }

    protected async Task DeleteSelectedSwitch()
    {
        await Http.DeleteAsync(baseUrl + "switches/" + selectedId);
        await GetSwitches();
    }

    protected async Task EditSelectedSwitch()
    {

        await Http.PutAsJsonAsync(baseUrl + "switches", editSwitch);
        await GetSwitches();
    }

    protected void SetEditSwitch(int id)
    {
        selectedId = id;

        bool found = false;
        int i = 0;
        while (!found && i < switches.Length)
        {
            if (switches[i].Id == selectedId)
            {
                editSwitch = new DtoEditSwitch()
                {
                    Id = switches[i].Id,
                    Name = switches[i].Name,
                    Mac = switches[i].Mac,
                    Ip = switches[i].Ip
                };
            }
            i++;
        }
    }

    protected void SetDeleteSwitch(int id)
    {
        selectedId = id;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
