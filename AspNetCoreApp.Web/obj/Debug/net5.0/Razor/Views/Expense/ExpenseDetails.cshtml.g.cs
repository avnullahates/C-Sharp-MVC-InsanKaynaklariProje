#pragma checksum "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9c886a70b27fbfbd2153c7048f85862db677096"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expense_ExpenseDetails), @"mvc.1.0.view", @"/Views/Expense/ExpenseDetails.cshtml")]
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
#nullable restore
#line 1 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\_ViewImports.cshtml"
using AspNetCoreApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\_ViewImports.cshtml"
using AspNetCoreApp.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\_ViewImports.cshtml"
using CoreLayer.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\_ViewImports.cshtml"
using CoreLayer.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\_ViewImports.cshtml"
using CoreLayer.VM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9c886a70b27fbfbd2153c7048f85862db677096", @"/Views/Expense/ExpenseDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"901b421581fa0a413c9b250776e76ea19b21a150", @"/Views/_ViewImports.cshtml")]
    public class Views_Expense_ExpenseDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreLayer.Entities.Expense>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateExpense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Expense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link mt-2 ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExpenseDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 15 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
   Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""main-content"" id=""panel"">
    <!-- Topnav -->
    <!-- Header -->
    <!-- Header -->
    <div class=""header pb-0 d-flex align-items-center"" style=""min-height: 24px; background-image: url(~/argon/assets/img/theme/profile-cover.jpg); background-size: cover; background-position: center top;"">
        <!-- Mask -->
        <!-- Header container -->
        <div class=""container-fluid align-items-center "">
        </div>
    </div>

    <div class=""container-fluid mt-2"">
        <div class=""row"">
            <div class=""col"">
                <div class=""card"">
                    <div class=""card-header border-0"">
                        <h3 class=""mb-2""> Harcama Detay Sayfası </h3>
                    </div>
                    <div class=""card-body"">
                        <div class=""container-fluid"">
                            <div class=""row"">
                                <div class=""col-lg-3 col-md-6 label mb-1"">Harcama Tutarı</div>
                                ");
            WriteLiteral("<div class=\"col-lg-3 col-md-6\"> ");
#nullable restore
#line 42 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
                                                           Write(Html.DisplayFor(model => model.ExpenseAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TL</div>      
                            </div>                          
                            <div class=""row"">               
                                <div class=""col-lg-3 col-md-6 label mb-1"">Harcama Türü</div>
                                <div class=""col-lg-3 col-md-6""> ");
#nullable restore
#line 46 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
                                                           Write(Html.DisplayFor(model => model.TypeOfExpenses));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>        
                            </div>                          
                            <div class=""row"">               
                                <div class=""col-lg-3 col-md-6 label mb-1"">Açıklama</div>
                                <div class=""col-lg-3 col-md-6""> ");
#nullable restore
#line 50 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
                                                           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>          
                            </div>                         
                            <div class=""row"">              
                                <div class=""col-lg-3 col-md-6 label mb-1"">Onay Durumu</div>
                                <div class=""col-lg-3 col-md-6""> ");
#nullable restore
#line 54 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
                                                           Write(Html.DisplayFor(model => model.Approval));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n");
#nullable restore
#line 56 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
                             if (@Model.Invoce != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"row\">\r\n\r\n                                    <div class=\"col-lg-3 col-md-6 label mb-1\">Fatura</div>\r\n\r\n                                    <div class=\"col-lg-3 col-md-6\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9c886a70b27fbfbd2153c7048f85862db67709612586", async() => {
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e9c886a70b27fbfbd2153c7048f85862db67709612882", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2827, "~/Files/Invoices/", 2827, 17, true);
#nullable restore
#line 63 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
AddHtmlAttributeValue("", 2844, Model.Invoce, 2844, 13, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2743, "~/Files/Invoices/", 2743, 17, true);
#nullable restore
#line 62 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
AddHtmlAttributeValue("", 2760, Model.Invoce, 2760, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 67 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
                            }

                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"row\">\r\n                                    <div class=\"col-lg-3 col-md-6 label mb-1\">Fatura</div>\r\n                                </div>\r\n");
#nullable restore
#line 74 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <div class=\"row mb-1\">\r\n                                <div class=\"col-lg-3 col-md-6 label mb-1\">Oluşturma Tarihi</div>\r\n                                <div class=\"col-lg-3 col-md-6\"> ");
#nullable restore
#line 78 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
                                                           Write(Html.DisplayFor(model => model.CreationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9c886a70b27fbfbd2153c7048f85862db67709617535", async() => {
                WriteLiteral("\r\n                                <div");
                BeginWriteAttribute("class", " class=\"", 3754, "\"", 3762, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e9c886a70b27fbfbd2153c7048f85862db67709618025", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 82 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9c886a70b27fbfbd2153c7048f85862db67709619800", async() => {
                    WriteLiteral("Güncelle");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 83 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
                                                                    WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9c886a70b27fbfbd2153c7048f85862db67709622242", async() => {
                    WriteLiteral("Harcama Listesine Dön");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                                \r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 98 "C:\Users\pana_\source\Workspaces\InsanKaynaklari\AspNetCoreApp.Web\AspNetCoreApp.Web\Views\Expense\ExpenseDetails.cshtml"
      
        await Html.RenderPartialAsync("_ValidationScriptsPartial");
    

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreLayer.Entities.Expense> Html { get; private set; }
    }
}
#pragma warning restore 1591
