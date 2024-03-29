#pragma checksum "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\HotelRoom\RoomPrices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4dd4291a1c4b791db8767a94ea4ee878d48efd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HotelRoom_RoomPrices), @"mvc.1.0.view", @"/Views/HotelRoom/RoomPrices.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/HotelRoom/RoomPrices.cshtml", typeof(AspNetCore.Views_HotelRoom_RoomPrices))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\_ViewImports.cshtml"
using DevnotHotelReservation.Web;

#line default
#line hidden
#line 2 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\_ViewImports.cshtml"
using DevnotHotelReservation.Web.Models;

#line default
#line hidden
#line 1 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\HotelRoom\RoomPrices.cshtml"
using DevnotHotelReservation.Entity.Model;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4dd4291a1c4b791db8767a94ea4ee878d48efd6", @"/Views/HotelRoom/RoomPrices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26af0f3b7b2b51ada6054ce1f8052349b0c97af3", @"/Views/_ViewImports.cshtml")]
    public class Views_HotelRoom_RoomPrices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HotelRoomPrice>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\HotelRoom\RoomPrices.cshtml"
  
    ViewData["Title"] = "RoomPrices";
    Layout = "~/Views/Shared/_MyLayout.cshtml";

#line default
#line hidden
            BeginContext(168, 616, true);
            WriteLiteral(@"

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-10"">
            <div class=""alert alert-light"" role=""alert"">
                <h2>Oda Fiyatları</h2>
            </div>
            <table class=""table"">
                <thead class=""thead-light"">
                    <tr>
                        <th scope=""col"">Başlangıç Tarihi</th>
                        <th scope=""col"">Bitiş Tarihi</th>
                        <th scope=""col"">Fiyat</th>
                        <th scope=""col"">Uygunluk</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 25 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\HotelRoom\RoomPrices.cshtml"
                     foreach (var room in Model)
                    {
                        

#line default
#line hidden
#line 27 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\HotelRoom\RoomPrices.cshtml"
                         if (room.StartDate != null || room.EndDate != null)
                        {

#line default
#line hidden
            BeginContext(962, 70, true);
            WriteLiteral("                            <tr>\r\n                                <th>");
            EndContext();
            BeginContext(1033, 43, false);
#line 30 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\HotelRoom\RoomPrices.cshtml"
                               Write(room.StartDate.Value.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 43, true);
            WriteLiteral("</th>\r\n                                <td>");
            EndContext();
            BeginContext(1120, 41, false);
#line 31 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\HotelRoom\RoomPrices.cshtml"
                               Write(room.EndDate.Value.ToString("dd-MM-yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1205, 10, false);
#line 32 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\HotelRoom\RoomPrices.cshtml"
                               Write(room.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1215, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 33 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\HotelRoom\RoomPrices.cshtml"
                                 if (room.IsAvailable == true)
                                {

#line default
#line hidden
            BeginContext(1321, 281, true);
            WriteLiteral(@"                                    <td>
                                        <div class=""alert alert-success"" role=""alert"">
                                            <h5>Uygun</h5>
                                        </div>
                                    </td>
");
            EndContext();
#line 40 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\HotelRoom\RoomPrices.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1710, 286, true);
            WriteLiteral(@"                                    <td>
                                        <div class=""alert alert-danger"" role=""alert"">
                                            <h5>Uygun Değil</h5>
                                        </div>
                                    </td>
");
            EndContext();
#line 48 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\HotelRoom\RoomPrices.cshtml"
                                }

#line default
#line hidden
            BeginContext(2031, 35, true);
            WriteLiteral("                            </tr>\r\n");
            EndContext();
#line 50 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\HotelRoom\RoomPrices.cshtml"
                        }

#line default
#line hidden
#line 50 "C:\Users\508Games\Desktop\DevnotHotelReservation\DevnotHotelReservation.Web\Views\HotelRoom\RoomPrices.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(2116, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HotelRoomPrice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
