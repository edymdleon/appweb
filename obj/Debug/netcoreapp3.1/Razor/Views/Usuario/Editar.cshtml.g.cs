#pragma checksum "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb189c09628cbf5da38363f6e218914608548646"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Editar), @"mvc.1.0.view", @"/Views/Usuario/Editar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb189c09628cbf5da38363f6e218914608548646", @"/Views/Usuario/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5605e86bfdc163e2749e6e7847f380f6d2a4bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VWorkS.Data.UsuarioManto>
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
#line 4 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
Write(Html.HiddenFor(model => model.Usuario.EstadoRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
Write(Html.Hidden("TipoManto", (object)@ViewBag.TipoManto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input name=\"IsValid\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 183, "\"", 230, 1);
#nullable restore
#line 6 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 191, ViewData.ModelState.IsValid.ToString(), 191, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<div class=\"form-group row\">\r\n    <label class=\"col-md-4 control-label\">Id</label>\r\n    <div class=\"col-md-12\">\r\n        ");
#nullable restore
#line 10 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
   Write(Html.EditorFor(model => model.Usuario.IdUsuario, new { htmlAttributes = new { @class = "form-control", @readonly = "true", @type="" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
   Write(Html.ValidationMessageFor(model => model.Usuario.IdUsuario, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"form-group row\">\r\n    <label class=\"col-md-4 control-label\">Nombre De Usuario</label>\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 18 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
          
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fb189c09628cbf5da38363f6e2189146085486465952", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 29 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Usuario.NombreUsuario);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1151, "form-control", 1151, 12, true);
#nullable restore
#line 29 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
AddHtmlAttributeValue(" ", 1163, valido, 1164, 7, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb189c09628cbf5da38363f6e2189146085486467962", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 30 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
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
#line 38 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
          
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fb189c09628cbf5da38363f6e21891460854864610289", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 48 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Usuario.Email);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1784, "form-control", 1784, 12, true);
#nullable restore
#line 48 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
AddHtmlAttributeValue(" ", 1796, valido, 1797, 7, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb189c09628cbf5da38363f6e21891460854864612292", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 49 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
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
#line 57 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
          
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fb189c09628cbf5da38363f6e21891460854864614620", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 67 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Usuario.FechaNacimiento);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2427, "form-control", 2427, 12, true);
#nullable restore
#line 67 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
AddHtmlAttributeValue(" ", 2439, valido, 2440, 7, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb189c09628cbf5da38363f6e21891460854864616633", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 68 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
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
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n<div class=\"form-group\">\r\n");
#nullable restore
#line 75 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
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
#line 87 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
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
#line 100 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<hr />\r\n<ul class=\"nav nav-tabs\">\r\n    <li class=\"nav-item\">\r\n        <a href=\"#ultimamodificacion\" data-toggle=\"tab\" aria-expanded=\"false\" class=\"nav-link active\">\r\n            <span");
            BeginWriteAttribute("class", " class=\"", 3859, "\"", 3867, 0);
            EndWriteAttribute();
            WriteLiteral(">Modificaci??n</span>\r\n        </a>\r\n    </li>\r\n    <li class=\"nav-item\">\r\n        <a href=\"#otrasmodificaciones\" data-toggle=\"tab\" aria-expanded=\"true\"\r\n           class=\"nav-link\">\r\n            <span");
            BeginWriteAttribute("class", " class=\"", 4068, "\"", 4076, 0);
            EndWriteAttribute();
            WriteLiteral(@">Otras Modificaciones</span>
        </a>
    </li>
</ul>
<div class=""tab-content border"">
    <div class=""tab-pane show active"" id=""ultimamodificacion"">
        <div class=""form-group"">
            <label class=""col-md-4 control-label"">Fecha y Hora</label>
            <div class=""col-md-12"">
                <input");
            BeginWriteAttribute("value", " value=\"", 4402, "\"", 4442, 1);
#nullable restore
#line 121 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 4410, Model.Usuario.FechaHoraModifica, 4410, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Usuario.FechaHoraModifica"" id=""Usuario.FechaHoraModifica"" readonly class=""form-control"" />
            </div>
        </div>
        <div class=""form-group"">
            <label class=""col-md-4 control-label"">Usuario</label>
            <div class=""col-md-12"">
                <input");
            BeginWriteAttribute("value", " value=\"", 4738, "\"", 4774, 1);
#nullable restore
#line 127 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Editar.cshtml"
WriteAttributeValue("", 4746, Model.Usuario.NombreUsuario, 4746, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Usuario.Usuario\" id=\"Usuario.Usuario\" readonly class=\"form-control\"/>\r\n            </div>\r\n        </div>\r\n    </div>\r\n  \r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
