#pragma checksum "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ebaf74405d97b19437522a67cf218acb642841d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Crear), @"mvc.1.0.view", @"/Views/Usuario/Crear.cshtml")]
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
#line 1 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\_ViewImports.cshtml"
using VWorkS.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ebaf74405d97b19437522a67cf218acb642841d", @"/Views/Usuario/Crear.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5605e86bfdc163e2749e6e7847f380f6d2a4bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Crear : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VWorkS.Data.UsuarioManto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("invalid-feedback"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
Write(Html.HiddenFor(model => model.Usuario.EstadoRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
Write(Html.Hidden("TipoManto", (object)@ViewBag.TipoManto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<input name=\"IsValid\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 550, "\"", 597, 1);
#nullable restore
#line 19 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
WriteAttributeValue("", 558, ViewData.ModelState.IsValid.ToString(), 558, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<div class=\"form-group row\">\r\n    <label class=\"col-md-4 control-label\">Id</label>\r\n    <div class=\"col-md-12\">\r\n        ");
#nullable restore
#line 23 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
   Write(Html.EditorFor(model => model.Usuario.IdUsuario, new { htmlAttributes = new { @class = "form-control", @readonly = "true", @type = "" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 24 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
   Write(Html.ValidationMessageFor(model => model.Usuario.IdUsuario, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"form-group row\">\r\n    <label class=\"col-md-4 control-label\">Nombre De Usuario</label>\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 30 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
          
            string valido = "";
            if (!ViewData.ModelState.IsValid)
            {

                if (ViewData.ModelState["Usuario.NombreUsuario"].ValidationState.ToString() == "Invalid")
                    valido = "is-invalid";
                else
                    valido = "is-valid";

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ebaf74405d97b19437522a67cf218acb642841d5971", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 41 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Usuario.NombreUsuario);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1518, "form-control", 1518, 12, true);
#nullable restore
#line 41 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
AddHtmlAttributeValue(" ", 1530, valido, 1531, 7, false);

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
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ebaf74405d97b19437522a67cf218acb642841d7979", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 42 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Usuario.NombreUsuario);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"form-group row\">\r\n    <label class=\"col-md-4 control-label\">Correo Electronico</label>\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 50 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
          
            if (!ViewData.ModelState.IsValid)
            {

                if (ViewData.ModelState["Usuario.Email"].ValidationState.ToString() == "Invalid")
                    valido = "is-invalid";
                else
                    valido = "is-valid";

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ebaf74405d97b19437522a67cf218acb642841d10304", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 60 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Usuario.Email);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2151, "form-control", 2151, 12, true);
#nullable restore
#line 60 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
AddHtmlAttributeValue(" ", 2163, valido, 2164, 7, false);

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
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ebaf74405d97b19437522a67cf218acb642841d12305", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 61 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Usuario.Email);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"form-group row\">\r\n    <label class=\"col-md-4 control-label\">Fecha Nacimiento</label>\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 69 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
          
            if (!ViewData.ModelState.IsValid)
            {

                if (ViewData.ModelState["Usuario.FechaNacimiento"].ValidationState.ToString() == "Invalid")
                    valido = "is-invalid";
                else
                    valido = "is-valid";

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ebaf74405d97b19437522a67cf218acb642841d14631", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 79 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Usuario.FechaNacimiento);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2794, "form-control", 2794, 12, true);
#nullable restore
#line 79 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
AddHtmlAttributeValue(" ", 2806, valido, 2807, 7, false);

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
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ebaf74405d97b19437522a67cf218acb642841d16642", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 80 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Usuario.FechaNacimiento);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"form-group\">\r\n");
#nullable restore
#line 86 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
     if (Model.Usuario.EstadoRegistro == "A")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""input-group"">
            <label class=""control-label"" id=""switch01"" name=""switch01"">Activo</label>
            <div class=""input-group-append"">
                <div class=""switch"">
                    <label>
                        <input type=""checkbox"" checked id=""radio_01"" name=""radio_01"" onclick=""CambiarEstado();""><span class=""lever switch-col-light-green""></span>
                    </label>
                </div>
            </div>
        </div>
");
#nullable restore
#line 98 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""input-group"">
            <label class=""control-label"" id=""switch01"" name=""switch01"">Inactivo</label>
            <div class=""input-group-append"">
                <div class=""switch"">
                    <label>
                        <input type=""checkbox"" id=""radio_01"" name=""radio_01"" onclick=""CambiarEstado();""><span class=""lever switch-col-light-green""></span>
                    </label>
                </div>
            </div>
        </div>
");
#nullable restore
#line 111 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Crear.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VWorkS.Data.UsuarioManto> Html { get; private set; }
    }
}
#pragma warning restore 1591