#pragma checksum "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86961189df60cf11f24f39703a3167b33a447d2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Empleado_Editar), @"mvc.1.0.view", @"/Views/Empleado/Editar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86961189df60cf11f24f39703a3167b33a447d2d", @"/Views/Empleado/Editar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5605e86bfdc163e2749e6e7847f380f6d2a4bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Empleado_Editar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VWorkS.Data.EmpleadoManto>
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
#line 4 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
Write(Html.HiddenFor(model => model.Empleado.EstadoRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
Write(Html.Hidden("TipoManto", (object)@ViewBag.TipoManto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input name=\"IsValid\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 185, "\"", 232, 1);
#nullable restore
#line 6 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
WriteAttributeValue("", 193, ViewData.ModelState.IsValid.ToString(), 193, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<div class=\"form-group row\">\r\n    <label class=\"col-md-4 control-label\">Id</label>\r\n    <div class=\"col-md-12\">\r\n        ");
#nullable restore
#line 10 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
   Write(Html.EditorFor(model => model.Empleado.IdEmpleado, new { htmlAttributes = new { @class = "form-control", @readonly = "true", @type="" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
   Write(Html.ValidationMessageFor(model => model.Empleado.IdEmpleado, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"form-group row\">\r\n    <label class=\"col-md-4 control-label\">Nombre Completo</label>\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 18 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
          
            string valido = "";
            if (!ViewData.ModelState.IsValid)
            {

                if (ViewData.ModelState["Empleado.NombreComleto"].ValidationState.ToString() == "Invalid")
                    valido = "is-invalid";
                else
                    valido = "is-valid";

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86961189df60cf11f24f39703a3167b33a447d2d5968", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 29 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Empleado.NombreCompleto);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1158, "form-control", 1158, 12, true);
#nullable restore
#line 29 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
AddHtmlAttributeValue(" ", 1170, valido, 1171, 7, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86961189df60cf11f24f39703a3167b33a447d2d7982", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 30 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Empleado.NombreCompleto);

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
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"form-group row\">\r\n    <label class=\"col-md-4 control-label\">DPI</label>\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 38 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
          
            if (!ViewData.ModelState.IsValid)
            {

                if (ViewData.ModelState["Empleado.DPI"].ValidationState.ToString() == "Invalid")
                    valido = "is-invalid";
                else
                    valido = "is-valid";

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86961189df60cf11f24f39703a3167b33a447d2d10297", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 48 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Empleado.DPI);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1776, "form-control", 1776, 12, true);
#nullable restore
#line 48 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
AddHtmlAttributeValue(" ", 1788, valido, 1789, 7, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86961189df60cf11f24f39703a3167b33a447d2d12301", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 49 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Empleado.DPI);

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
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"form-group row\">\r\n    <label class=\"col-md-4 control-label\">Cantidad De Hijos</label>\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 57 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
          
            if (!ViewData.ModelState.IsValid)
            {

                if (ViewData.ModelState["Empleado.CantidadHijos"].ValidationState.ToString() == "Invalid")
                    valido = "is-invalid";
                else
                    valido = "is-valid";

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86961189df60cf11f24f39703a3167b33a447d2d14630", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 67 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Empleado.CantidadHijos);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2417, "form-control", 2417, 12, true);
#nullable restore
#line 67 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
AddHtmlAttributeValue(" ", 2429, valido, 2430, 7, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86961189df60cf11f24f39703a3167b33a447d2d16644", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 68 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Empleado.CantidadHijos);

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
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div class=\"form-group row\">\r\n    <label class=\"col-md-4 control-label\">Salario Base</label>\r\n    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 76 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
          
            if (!ViewData.ModelState.IsValid)
            {

                if (ViewData.ModelState["Empleado.SalarioBase"].ValidationState.ToString() == "Invalid")
                    valido = "is-invalid";
                else
                    valido = "is-valid";

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86961189df60cf11f24f39703a3167b33a447d2d18976", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 86 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Empleado.SalarioBase);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3059, "form-control", 3059, 12, true);
#nullable restore
#line 86 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
AddHtmlAttributeValue(" ", 3071, valido, 3072, 7, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86961189df60cf11f24f39703a3167b33a447d2d20988", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 87 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Empleado.SalarioBase);

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
#line 93 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
     if (Model.Empleado.EstadoRegistro == "A")
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
#line 105 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
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
#line 118 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<div class=""form-group row"">
    <label class=""col-md-4 control-label"">Bono Decreto</label>
    <div class=""col-md-12"">
        <span>250.00</span>
    </div>
    </div>
<div class=""form-group row"">
    <div class=""col-md-12"">
        <div class=""col-md-6"">
            <label class=""col-md-4 control-label"">IGSS</label>
");
#nullable restore
#line 130 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
              
                double igss = 0;
                if (Model.Empleado.SalarioBase > 0)
                {
                    igss = Model.Empleado.SalarioBase * 4.83 / 100;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 136 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
                 Write(igss);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("        </div>\r\n        <div class=\"col-md-6\">\r\n            <label class=\"col-md-4 control-label\">IRTRA</label>\r\n");
#nullable restore
#line 141 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
              
                double irtra = 0;
                if (Model.Empleado.SalarioBase > 0)
                {
                    irtra = Model.Empleado.SalarioBase * 1 / 100;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 147 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
                 Write(irtra);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("        </div>\r\n        <label class=\"col-md-12 control-label\">Bono de paternidad</label>\r\n        <div class=\"col-md-6\">\r\n\r\n");
#nullable restore
#line 153 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
              
                double pater = 0;
                if (Model.Empleado.CantidadHijos > 0)
                {
                    pater = Model.Empleado.CantidadHijos * 133;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 159 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
                 Write(pater);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("        </div>\r\n        <label class=\"col-md-12 control-label\">Salario total</label>\r\n        <div class=\"col-md-6\">\r\n\r\n");
#nullable restore
#line 165 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
              
                double stotal = 0;
                if (Model.Empleado.SalarioBase > 0)
                {
                    stotal = Model.Empleado.SalarioBase + pater + 250;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 171 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
                 Write(stotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("        </div>\r\n        <label class=\"col-md-12 control-label\">Salario liquido</label>\r\n        <div class=\"col-md-6\">\r\n\r\n");
#nullable restore
#line 177 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
              
                double sliquido = 0;
                if (Model.Empleado.SalarioBase > 0)
                {
                    sliquido = stotal - igss - irtra;
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 183 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
                 Write(sliquido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral(@"        </div>
    </div>
</div>
        <hr />
        <ul class=""nav nav-tabs"">
            <li class=""nav-item"">
                <a href=""#ultimamodificacion"" data-toggle=""tab"" aria-expanded=""false"" class=""nav-link active"">
                    <span");
            BeginWriteAttribute("class", " class=\"", 6680, "\"", 6688, 0);
            EndWriteAttribute();
            WriteLiteral(">Modificación</span>\r\n                </a>\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                <a href=\"#otrasmodificaciones\" data-toggle=\"tab\" aria-expanded=\"true\"\r\n                   class=\"nav-link\">\r\n                    <span");
            BeginWriteAttribute("class", " class=\"", 6937, "\"", 6945, 0);
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
            BeginWriteAttribute("value", " value=\"", 7343, "\"", 7384, 1);
#nullable restore
#line 207 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
WriteAttributeValue("", 7351, Model.Empleado.FechaHoraModifica, 7351, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Empleado.FechaHoraModifica"" id=""Empleado.FechaHoraModifica"" readonly class=""form-control"" />
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""col-md-4 control-label"">Usuario</label>
                    <div class=""col-md-12"">
                        <input");
            BeginWriteAttribute("value", " value=\"", 7730, "\"", 7761, 1);
#nullable restore
#line 213 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Empleado\Editar.cshtml"
WriteAttributeValue("", 7738, Model.Empleado.Usuario, 7738, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Empleado.Usuario\" id=\"Empleado.Usuario\" readonly class=\"form-control\" />\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VWorkS.Data.EmpleadoManto> Html { get; private set; }
    }
}
#pragma warning restore 1591
