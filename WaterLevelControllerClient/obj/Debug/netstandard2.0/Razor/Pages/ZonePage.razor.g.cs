#pragma checksum "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b84ba3eb67d891c9d47a21abf335710770bd9b23"
// <auto-generated/>
#pragma warning disable 1591
namespace WaterLevelControllerClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using WaterLevelControllerClient;

#line default
#line hidden
#line 7 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using WaterLevelControllerClient.Shared;

#line default
#line hidden
#line 8 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\_Imports.razor"
using WaterLevelControllerClient.Data.Dto;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/zonePage")]
    public partial class ZonePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Zone manager</h3>\r\n<hr>\r\n\r\n");
#line 6 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
 if (loaded)
{
    if (zones != null)
    {

#line default
#line hidden
            __builder.AddContent(1, "        ");
            __builder.AddMarkupContent(2, "<h5>Select a zone:</h5>\r\n        ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenElement(6, "tbody");
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddMarkupContent(11, "\r\n                        ");
            __builder.OpenElement(12, "select");
            __builder.AddAttribute(13, "id", "zone_selector");
            __builder.AddAttribute(14, "class", "custom-select my-2");
            __builder.AddAttribute(15, "value", 
#line 15 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                                                                                      zones[0].Id

#line default
#line hidden
            );
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 15 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                                                                                                               ZoneSelectorChanged

#line default
#line hidden
            ));
            __builder.AddMarkupContent(17, "\r\n");
#line 16 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                             foreach (var zone in zones)
                            {

#line default
#line hidden
            __builder.AddContent(18, "                                ");
            __builder.OpenElement(19, "option");
            __builder.AddAttribute(20, "value", 
#line 18 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                                                zone.Id

#line default
#line hidden
            );
            __builder.AddContent(21, 
#line 18 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                                                          zone.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#line 19 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                            }

#line default
#line hidden
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.AddMarkupContent(26, @"<td>
                        <button type=""button"" class=""btn btn-warning m-1"" data-toggle=""modal"" data-target=""#editZoneModal"">Edit</button>
                        <button type=""button"" class=""btn btn-danger m-1"" data-toggle=""modal"" data-target=""#deleteZoneModal"">Delete</button>
                    </td>
                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#line 31 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
    }

    else
    {

#line default
#line hidden
            __builder.AddContent(30, "        ");
            __builder.AddMarkupContent(31, "<p>No zone available!</p>\r\n");
#line 36 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
    }

#line default
#line hidden
            __builder.AddContent(32, "    ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "btn btn-success m-1");
            __builder.AddAttribute(36, "data-toggle", "modal");
            __builder.AddAttribute(37, "data-target", "#addZoneModal");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 37 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                                                                                                                 ClearCreateZone

#line default
#line hidden
            ));
            __builder.AddContent(39, "Create new zone");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    <hr>\r\n    ");
            __builder.AddMarkupContent(41, "<h5>Sensors in this zone:</h5>\r\n");
#line 40 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"

    if (sensors != null)
    {

#line default
#line hidden
            __builder.AddContent(42, "        ");
            __builder.OpenElement(43, "table");
            __builder.AddAttribute(44, "class", "table");
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.AddMarkupContent(46, "<thead>\r\n                <tr>\r\n                    <th>Name</th>\r\n                    <th>Ip</th>\r\n                    <th>Water Level</th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(47, "tbody");
            __builder.AddMarkupContent(48, "\r\n");
#line 52 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                 foreach (var sensor in sensors)
                {

#line default
#line hidden
            __builder.AddContent(49, "                    ");
            __builder.OpenElement(50, "tr");
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#line 55 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                             sensor.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                        ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#line 56 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                             sensor.Ip

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#line 57 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                             sensor.Data

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#line 59 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                }

#line default
#line hidden
            __builder.AddContent(62, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#line 62 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
    }
    else
    {

#line default
#line hidden
            __builder.AddContent(65, "        ");
            __builder.AddMarkupContent(66, "<p>No sensor available in this zone!</p>\r\n");
#line 66 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
    }

}

#line default
#line hidden
            __builder.AddMarkupContent(67, "\r\n\r\n");
#line 71 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
 if (createZone != null)
{

#line default
#line hidden
            __builder.AddContent(68, "    ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "modal fade");
            __builder.AddAttribute(71, "id", "addZoneModal");
            __builder.AddAttribute(72, "tabindex", "-1");
            __builder.AddAttribute(73, "role", "dialog");
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "modal-dialog");
            __builder.AddAttribute(77, "role", "document");
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "modal-content");
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.AddMarkupContent(82, "<div class=\"modal-header\">\r\n                    <h5 class=\"modal-title\">Create new zone </h5>\r\n                </div>\r\n                ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "modal-body");
            __builder.AddMarkupContent(85, "\r\n                    ");
            __builder.OpenElement(86, "form");
            __builder.AddMarkupContent(87, "\r\n                        ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "form-group");
            __builder.AddMarkupContent(90, "\r\n                            ");
            __builder.AddMarkupContent(91, "<label for=\"nameInput\" class=\"mt-2\">Name:</label>\r\n                            ");
            __builder.OpenElement(92, "input");
            __builder.AddAttribute(93, "type", "text");
            __builder.AddAttribute(94, "class", "form-control");
            __builder.AddAttribute(95, "id", "nameInput");
            __builder.AddAttribute(96, "placeholder", "Zone name");
            __builder.AddAttribute(97, "required", true);
            __builder.AddAttribute(98, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 83 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                                           createZone.Name

#line default
#line hidden
            ));
            __builder.AddAttribute(99, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => createZone.Name = __value, createZone.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n                        ");
            __builder.OpenElement(102, "button");
            __builder.AddAttribute(103, "type", "button");
            __builder.AddAttribute(104, "class", "btn btn-success");
            __builder.AddAttribute(105, "data-dismiss", "modal");
            __builder.AddAttribute(106, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 85 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                                                                                                      PostCreateZone

#line default
#line hidden
            ));
            __builder.AddContent(107, "Create");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                        ");
            __builder.AddMarkupContent(109, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancel</button>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n");
#line 92 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(115, "\r\n");
#line 94 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
 if (selectedZone != null)
{

#line default
#line hidden
            __builder.AddMarkupContent(116, "    \r\n    ");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "modal fade");
            __builder.AddAttribute(119, "id", "deleteZoneModal");
            __builder.AddAttribute(120, "tabindex", "-1");
            __builder.AddAttribute(121, "role", "dialog");
            __builder.AddMarkupContent(122, "\r\n        ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "modal-dialog");
            __builder.AddAttribute(125, "role", "document");
            __builder.AddMarkupContent(126, "\r\n            ");
            __builder.OpenElement(127, "div");
            __builder.AddAttribute(128, "class", "modal-content");
            __builder.AddMarkupContent(129, "\r\n                ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "modal-header");
            __builder.AddMarkupContent(132, "\r\n                    ");
            __builder.OpenElement(133, "h5");
            __builder.AddAttribute(134, "class", "modal-title");
            __builder.AddContent(135, "Do you want to delete ");
            __builder.AddContent(136, 
#line 101 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                                                                   selectedZone.Name

#line default
#line hidden
            );
            __builder.AddContent(137, " zone? ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n                ");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "modal-body");
            __builder.AddMarkupContent(142, "\r\n                    ");
            __builder.OpenElement(143, "button");
            __builder.AddAttribute(144, "type", "button");
            __builder.AddAttribute(145, "class", "btn btn-danger m-1");
            __builder.AddAttribute(146, "data-dismiss", "modal");
            __builder.AddAttribute(147, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 104 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                                                                                                     DeleteSelectedZone

#line default
#line hidden
            ));
            __builder.AddContent(148, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                    ");
            __builder.AddMarkupContent(150, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">No</button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n");
#line 110 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(155, "\r\n\r\n");
#line 113 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
 if (selectedZone != null)
{

#line default
#line hidden
            __builder.AddMarkupContent(156, "    \r\n    ");
            __builder.OpenElement(157, "div");
            __builder.AddAttribute(158, "class", "modal fade");
            __builder.AddAttribute(159, "id", "editZoneModal");
            __builder.AddAttribute(160, "tabindex", "-1");
            __builder.AddAttribute(161, "role", "dialog");
            __builder.AddMarkupContent(162, "\r\n        ");
            __builder.OpenElement(163, "div");
            __builder.AddAttribute(164, "class", "modal-dialog");
            __builder.AddAttribute(165, "role", "document");
            __builder.AddMarkupContent(166, "\r\n            ");
            __builder.OpenElement(167, "div");
            __builder.AddAttribute(168, "class", "modal-content");
            __builder.AddMarkupContent(169, "\r\n                ");
            __builder.AddMarkupContent(170, "<div class=\"modal-header\">\r\n                    <h5 class=\"modal-title\">Edit zone</h5>\r\n                </div>\r\n                ");
            __builder.OpenElement(171, "div");
            __builder.AddAttribute(172, "class", "modal-body");
            __builder.AddMarkupContent(173, "\r\n                    ");
            __builder.OpenElement(174, "form");
            __builder.AddMarkupContent(175, "\r\n                        ");
            __builder.OpenElement(176, "div");
            __builder.AddAttribute(177, "class", "form-group");
            __builder.AddMarkupContent(178, "\r\n                            ");
            __builder.AddMarkupContent(179, "<label for=\"nameInput\" class=\"mt-2\">Name:</label>\r\n                            ");
            __builder.OpenElement(180, "input");
            __builder.AddAttribute(181, "type", "text");
            __builder.AddAttribute(182, "class", "form-control");
            __builder.AddAttribute(183, "id", "nameInput");
            __builder.AddAttribute(184, "placeholder", 
#line 126 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                                                                                                                            selectedZone.Name

#line default
#line hidden
            );
            __builder.AddAttribute(185, "required", true);
            __builder.AddAttribute(186, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 126 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                                           selectedZone.Name

#line default
#line hidden
            ));
            __builder.AddAttribute(187, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedZone.Name = __value, selectedZone.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n                        ");
            __builder.OpenElement(190, "button");
            __builder.AddAttribute(191, "type", "button");
            __builder.AddAttribute(192, "class", "btn btn-success");
            __builder.AddAttribute(193, "data-dismiss", "modal");
            __builder.AddAttribute(194, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 128 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
                                                                                                      EditSelectedZone

#line default
#line hidden
            ));
            __builder.AddContent(195, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n                        ");
            __builder.AddMarkupContent(197, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancel</button>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(201, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n");
#line 135 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 140 "D:\SZAKDOLGOZAT\project\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\ZonePage.razor"
       
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
        DtoSensorListItem[] loadedSensors = await Http.GetJsonAsync<DtoSensorListItem[]>(baseUrl + "zones/sensors/" + selectedZone.Id);

        if (loadedSensors != null && loadedSensors.Length > 0)
            sensors = loadedSensors;

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
