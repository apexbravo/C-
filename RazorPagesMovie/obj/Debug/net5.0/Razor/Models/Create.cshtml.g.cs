#pragma checksum "C:\Users\Apxb\Documents\C#\RazorPagesMovie\Models\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45b59858d58425d17cab47b98d9f53722a46393b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Models_Create), @"mvc.1.0.razor-page", @"/Models/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45b59858d58425d17cab47b98d9f53722a46393b", @"/Models/Create.cshtml")]
    public class Models_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Apxb\Documents\C#\RazorPagesMovie\Models\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Movie</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Movie.Title"" class=""control-label""></label>
                <input asp-for=""Movie.Title"" class=""form-control"" />
                <span asp-validation-for=""Movie.Title"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Movie.ReleaseDate"" class=""control-label""></label>
                <input asp-for=""Movie.ReleaseDate"" class=""form-control"" />
                <span asp-validation-for=""Movie.ReleaseDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Movie.Genre"" class=""control-label""></label>
                <input asp-for=""Movie.Genre"" class=""form-control"" />
                <span asp-validation-for=");
            WriteLiteral(@"""Movie.Genre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Movie.Price"" class=""control-label""></label>
                <input asp-for=""Movie.Price"" class=""form-control"" />
                <span asp-validation-for=""Movie.Price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 48 "C:\Users\Apxb\Documents\C#\RazorPagesMovie\Models\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.Models.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Models.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Models.CreateModel>)PageContext?.ViewData;
        public RazorPagesMovie.Models.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591