#pragma checksum "C:\Users\Grace\Desktop\Login\Login\Views\Productoes\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "68d70d302bc51f8969b6eefc82d1a33b1aa4e7aa03aabd7cefc90db7b641e59d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productoes_Delete), @"mvc.1.0.view", @"/Views/Productoes/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Grace\Desktop\Login\Login\Views\_ViewImports.cshtml"
using Login;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Grace\Desktop\Login\Login\Views\_ViewImports.cshtml"
using Login.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"68d70d302bc51f8969b6eefc82d1a33b1aa4e7aa03aabd7cefc90db7b641e59d", @"/Views/Productoes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"39116caa49483bd2408d7440d1e6d915e0aa1ed840b93a837d4831a055868668", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Productoes_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Login.Models.Producto>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Grace\Desktop\Login\Login\Views\Productoes\Delete.cshtml"
  
ViewData["Title"] = "Delete";
Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>¿Está seguro que desea eliminar este elemento?</h3>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>Nombre del producto:</dt>\r\n            <dd>");
#nullable restore
#line 14 "C:\Users\Grace\Desktop\Login\Login\Views\Productoes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n            <dt>Descripción del producto:</dt>\r\n            <dd>");
#nullable restore
#line 17 "C:\Users\Grace\Desktop\Login\Login\Views\Productoes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProDescripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n            <dt>Precio del producto:</dt>\r\n            <dd>");
#nullable restore
#line 20 "C:\Users\Grace\Desktop\Login\Login\Views\Productoes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProPrecio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n            <dt>Stock del producto:</dt>\r\n            <dd>");
#nullable restore
#line 23 "C:\Users\Grace\Desktop\Login\Login\Views\Productoes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ProStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n            <dt>Imagen del producto:</dt>\r\n            <dd>\r\n");
#nullable restore
#line 27 "C:\Users\Grace\Desktop\Login\Login\Views\Productoes\Delete.cshtml"
                 if (Model.ProImagen != null && Model.ProImagen.Length > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img");
            BeginWriteAttribute("src", " src=\"", 888, "\"", 957, 2);
            WriteAttributeValue("", 894, "data:image/jpeg;base64,", 894, 23, true);
#nullable restore
#line 29 "C:\Users\Grace\Desktop\Login\Login\Views\Productoes\Delete.cshtml"
WriteAttributeValue("", 917, Convert.ToBase64String(Model.ProImagen), 917, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\" style=\"max-width: 200px; max-height: 200px;\" />\r\n");
#nullable restore
#line 30 "C:\Users\Grace\Desktop\Login\Login\Views\Productoes\Delete.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>No hay imagen cargada</span>\r\n");
#nullable restore
#line 34 "C:\Users\Grace\Desktop\Login\Login\Views\Productoes\Delete.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n\r\n            <dt>Categoría del producto:</dt>\r\n            <dd>");
#nullable restore
#line 38 "C:\Users\Grace\Desktop\Login\Login\Views\Productoes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Categoria.CatNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n            <dt>Subcategoría del producto:</dt>\r\n            <dd>");
#nullable restore
#line 41 "C:\Users\Grace\Desktop\Login\Login\Views\Productoes\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Subcategoria.SubcNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        </dl>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68d70d302bc51f8969b6eefc82d1a33b1aa4e7aa03aabd7cefc90db7b641e59d8666", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "68d70d302bc51f8969b6eefc82d1a33b1aa4e7aa03aabd7cefc90db7b641e59d8960", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 45 "C:\Users\Grace\Desktop\Login\Login\Views\Productoes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProId);

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
                WriteLiteral("\r\n            <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" /> |\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68d70d302bc51f8969b6eefc82d1a33b1aa4e7aa03aabd7cefc90db7b641e59d10769", async() => {
                    WriteLiteral("Volver a la lista");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Login.Models.Producto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
