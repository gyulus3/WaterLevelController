#pragma checksum "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e1078d7c8a94db61795274330f9e6d212caaf35"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/schedulePage")]
    public partial class SchedulePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Schedule Manager</h3>\r\n<hr>\r\n\r\n");
#line 6 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
 if (loaded)
{

#line default
#line hidden
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "type", "button");
            __builder.AddAttribute(4, "class", "btn btn-success m-1");
            __builder.AddAttribute(5, "data-toggle", "modal");
            __builder.AddAttribute(6, "data-target", "#createScheduleModal");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 8 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                                                                                                                        ClearCreateSchedule

#line default
#line hidden
            ));
            __builder.AddContent(8, "Add new");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#line 9 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"

    if (schedules != null)
    {

#line default
#line hidden
            __builder.AddContent(10, "        ");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.AddMarkupContent(14, "<thead>\r\n                <tr>\r\n                    <th>Name</th>\r\n                    <th>Min Water Level</th>\r\n                    <th>Auto</th>\r\n                    <th>Connected sensors</th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(15, "tbody");
            __builder.AddMarkupContent(16, "\r\n");
#line 22 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                 foreach (var schedule in schedules)
                {

#line default
#line hidden
            __builder.AddContent(17, "                    ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#line 25 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                             schedule.Name

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#line 26 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                             schedule.MinWaterLevel

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#line 27 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                             schedule.Auto

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#line 28 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                             schedule.NumberOfSensors

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "btn btn-warning m-1");
            __builder.AddAttribute(37, "data-toggle", "modal");
            __builder.AddAttribute(38, "data-target", "#editScheduleModal");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 30 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                                                                                                                                               ()=>SetEditSchedule(schedule.Id)

#line default
#line hidden
            ));
            __builder.AddContent(40, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "class", "btn btn-danger m-1");
            __builder.AddAttribute(45, "data-toggle", "modal");
            __builder.AddAttribute(46, "data-target", "#deleteScheduleModal");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 31 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                                                                                                                                                ()=>SetDeleteSchedule(schedule.Id)

#line default
#line hidden
            ));
            __builder.AddContent(48, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#line 34 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                }

#line default
#line hidden
            __builder.AddContent(52, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
#line 37 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
    }

    else
    {

#line default
#line hidden
            __builder.AddContent(55, "        ");
            __builder.AddMarkupContent(56, "<p>No schedule available!</p>\r\n");
#line 42 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
    }
}

else
{

#line default
#line hidden
            __builder.AddMarkupContent(57, "    <hr>\r\n    ");
            __builder.AddMarkupContent(58, "<span>Loading...</span>\r\n");
#line 49 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(59, "\r\n\r\n");
#line 52 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
 if (createSchedule != null)
{

#line default
#line hidden
            __builder.AddContent(60, "    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "modal fade");
            __builder.AddAttribute(63, "id", "createScheduleModal");
            __builder.AddAttribute(64, "tabindex", "-1");
            __builder.AddAttribute(65, "role", "dialog");
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "modal-dialog");
            __builder.AddAttribute(69, "role", "document");
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "modal-content");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.AddMarkupContent(74, "<div class=\"modal-header\">\r\n                    <h5 class=\"modal-title\">Create new zone </h5>\r\n                </div>\r\n                ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "modal-body");
            __builder.AddMarkupContent(77, "\r\n                    ");
            __builder.OpenElement(78, "form");
            __builder.AddMarkupContent(79, "\r\n                        ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "form-group");
            __builder.AddMarkupContent(82, "\r\n                            ");
            __builder.AddMarkupContent(83, "<label for=\"nameInput\" class=\"mt-2\">Name:</label>\r\n                            ");
            __builder.OpenElement(84, "input");
            __builder.AddAttribute(85, "type", "text");
            __builder.AddAttribute(86, "class", "form-control");
            __builder.AddAttribute(87, "id", "nameInput");
            __builder.AddAttribute(88, "placeholder", "Schedule name");
            __builder.AddAttribute(89, "required", true);
            __builder.AddAttribute(90, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 64 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                                           createSchedule.Name

#line default
#line hidden
            ));
            __builder.AddAttribute(91, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => createSchedule.Name = __value, createSchedule.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                            ");
            __builder.AddMarkupContent(93, "<label for=\"minWaterLevelInput\" class=\"mt-2\">MinWaterLevel:</label>\r\n                            ");
            __builder.OpenElement(94, "input");
            __builder.AddAttribute(95, "type", "number");
            __builder.AddAttribute(96, "class", "form-control");
            __builder.AddAttribute(97, "id", "minWaterLevelInput");
            __builder.AddAttribute(98, "placeholder", "Min water level");
            __builder.AddAttribute(99, "max", "100");
            __builder.AddAttribute(100, "min", "0");
            __builder.AddAttribute(101, "required", true);
            __builder.AddAttribute(102, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 66 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                                           createSchedule.MinWaterLevel

#line default
#line hidden
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(103, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => createSchedule.MinWaterLevel = __value, createSchedule.MinWaterLevel, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                            ");
            __builder.AddMarkupContent(105, "<label for=\"autoInput\" class=\"mt-2\">Auto:</label>\r\n                            ");
            __builder.OpenElement(106, "input");
            __builder.AddAttribute(107, "type", "checkbox");
            __builder.AddAttribute(108, "class", "form-control");
            __builder.AddAttribute(109, "id", "autoInput");
            __builder.AddAttribute(110, "required", true);
            __builder.AddAttribute(111, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 68 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                                           createSchedule.Auto

#line default
#line hidden
            ));
            __builder.AddAttribute(112, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => createSchedule.Auto = __value, createSchedule.Auto));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                        ");
            __builder.OpenElement(115, "button");
            __builder.AddAttribute(116, "type", "button");
            __builder.AddAttribute(117, "class", "btn btn-success");
            __builder.AddAttribute(118, "data-dismiss", "modal");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 70 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                                                                                                      PostCreateSchedule

#line default
#line hidden
            ));
            __builder.AddContent(120, "Create");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                        ");
            __builder.AddMarkupContent(122, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancel</button>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n");
#line 77 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
}

#line default
#line hidden
            __builder.AddMarkupContent(128, "\r\n\r\n");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "modal fade");
            __builder.AddAttribute(131, "id", "deleteScheduleModal");
            __builder.AddAttribute(132, "tabindex", "-1");
            __builder.AddAttribute(133, "role", "dialog");
            __builder.AddMarkupContent(134, "\r\n    ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "modal-dialog");
            __builder.AddAttribute(137, "role", "document");
            __builder.AddMarkupContent(138, "\r\n        ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "modal-content");
            __builder.AddMarkupContent(141, "\r\n            ");
            __builder.AddMarkupContent(142, "<div class=\"modal-header\">\r\n                <h5 class=\"modal-title\">Do you want to delete this schedule? </h5>\r\n            </div>\r\n            ");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "modal-body");
            __builder.AddMarkupContent(145, "\r\n                ");
            __builder.OpenElement(146, "button");
            __builder.AddAttribute(147, "type", "button");
            __builder.AddAttribute(148, "class", "btn btn-danger m-1");
            __builder.AddAttribute(149, "data-dismiss", "modal");
            __builder.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 87 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                                                                                                 DeleteSelectedSchedule

#line default
#line hidden
            ));
            __builder.AddContent(151, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                ");
            __builder.AddMarkupContent(153, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">No</button>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n\r\n\r\n");
#line 95 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
 if (editSchedule != null)
{

#line default
#line hidden
            __builder.AddMarkupContent(158, "    \r\n    ");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "class", "modal fade");
            __builder.AddAttribute(161, "id", "editScheduleModal");
            __builder.AddAttribute(162, "tabindex", "-1");
            __builder.AddAttribute(163, "role", "dialog");
            __builder.AddMarkupContent(164, "\r\n        ");
            __builder.OpenElement(165, "div");
            __builder.AddAttribute(166, "class", "modal-dialog");
            __builder.AddAttribute(167, "role", "document");
            __builder.AddMarkupContent(168, "\r\n            ");
            __builder.OpenElement(169, "div");
            __builder.AddAttribute(170, "class", "modal-content");
            __builder.AddMarkupContent(171, "\r\n                ");
            __builder.AddMarkupContent(172, "<div class=\"modal-header\">\r\n                    <h5 class=\"modal-title\">Edit schedule</h5>\r\n                </div>\r\n                ");
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "modal-body");
            __builder.AddMarkupContent(175, "\r\n                    ");
            __builder.OpenElement(176, "form");
            __builder.AddMarkupContent(177, "\r\n                        ");
            __builder.OpenElement(178, "div");
            __builder.AddAttribute(179, "class", "form-group");
            __builder.AddMarkupContent(180, "\r\n                            ");
            __builder.AddMarkupContent(181, "<label for=\"nameInput\" class=\"mt-2\">Name:</label>\r\n                            ");
            __builder.OpenElement(182, "input");
            __builder.AddAttribute(183, "type", "text");
            __builder.AddAttribute(184, "class", "form-control");
            __builder.AddAttribute(185, "id", "nameInput");
            __builder.AddAttribute(186, "required", true);
            __builder.AddAttribute(187, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 108 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                                           editSchedule.Name

#line default
#line hidden
            ));
            __builder.AddAttribute(188, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => editSchedule.Name = __value, editSchedule.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n                            ");
            __builder.AddMarkupContent(190, "<label for=\"minWaterLevelInput\" class=\"mt-2\">MinWaterLevel:</label>\r\n                            ");
            __builder.OpenElement(191, "input");
            __builder.AddAttribute(192, "type", "number");
            __builder.AddAttribute(193, "class", "form-control");
            __builder.AddAttribute(194, "id", "minWaterLevelInput");
            __builder.AddAttribute(195, "max", "100");
            __builder.AddAttribute(196, "min", "0");
            __builder.AddAttribute(197, "required", true);
            __builder.AddAttribute(198, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 110 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                                           editSchedule.MinWaterLevel

#line default
#line hidden
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(199, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => editSchedule.MinWaterLevel = __value, editSchedule.MinWaterLevel, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n                            ");
            __builder.AddMarkupContent(201, "<label for=\"autoInput\" class=\"mt-2\">Auto:</label>\r\n                            ");
            __builder.OpenElement(202, "input");
            __builder.AddAttribute(203, "type", "checkbox");
            __builder.AddAttribute(204, "class", "form-control");
            __builder.AddAttribute(205, "id", "autoInput");
            __builder.AddAttribute(206, "required", true);
            __builder.AddAttribute(207, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 112 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                                           editSchedule.Auto

#line default
#line hidden
            ));
            __builder.AddAttribute(208, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => editSchedule.Auto = __value, editSchedule.Auto));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(209, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(210, "\r\n                        ");
            __builder.OpenElement(211, "button");
            __builder.AddAttribute(212, "type", "button");
            __builder.AddAttribute(213, "class", "btn btn-success");
            __builder.AddAttribute(214, "data-dismiss", "modal");
            __builder.AddAttribute(215, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 114 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
                                                                                                      EditSelectedSchedule

#line default
#line hidden
            ));
            __builder.AddContent(216, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(217, "\r\n                        ");
            __builder.AddMarkupContent(218, "<button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Cancel</button>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(219, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(221, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(223, "\r\n");
#line 121 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 123 "D:\Work\WaterLevelController\WaterLevelController\WaterLevelControllerClient\Pages\SchedulePage.razor"
       
    const string baseUrl = "https://localhost:5001/api/";
    bool loaded = false;
    DtoScheduleListItem[] schedules;
    int selectedId;
    DtoCreateSchedule createSchedule;
    DtoEditSchedule editSchedule;

    protected override async Task OnInitializedAsync()
    {
        await GetSchedules();
        loaded = true;
    }

    protected async Task GetSchedules()
    {
        DtoScheduleListItem[] loadedSchedules = await Http.GetJsonAsync<DtoScheduleListItem[]>(baseUrl + "schedules");

        if (loadedSchedules != null && loadedSchedules.Length > 0)
        {
            schedules = loadedSchedules;
        }

        else
            schedules = null;
    }

    protected void ClearCreateSchedule()
    {
        createSchedule = new DtoCreateSchedule();
    }


    protected async Task PostCreateSchedule()
    {
        await Http.PostAsJsonAsync(baseUrl + "schedules", createSchedule);
        await GetSchedules();

    }

    protected async Task DeleteSelectedSchedule()
    {
        await Http.DeleteAsync(baseUrl + "schedules/" + selectedId);
        await GetSchedules();
    }

    protected async Task EditSelectedSchedule()
    {

        await Http.PutAsJsonAsync(baseUrl + "schedules", editSchedule);
        await GetSchedules();
    }

    protected void SetEditSchedule(int id)
    {
        selectedId = id;

        bool found = false;
        int i = 0;
        while (!found && i < schedules.Length)
        {
            if (schedules[i].Id == selectedId)
            {
                editSchedule = new DtoEditSchedule()
                {
                    Id = schedules[i].Id,
                    Name = schedules[i].Name,
                    MinWaterLevel = schedules[i].MinWaterLevel,
                    Auto = schedules[i].Auto
                };
                found = true;
            }
            i++;
        }
    }

    protected void SetDeleteSchedule(int id)
    {
        selectedId = id;
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
