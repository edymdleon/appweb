#pragma checksum "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52bd0f57a132bf4298ada0e202f37321c56fcf4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
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
#nullable restore
#line 2 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
using X.PagedList.Mvc.Core.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52bd0f57a132bf4298ada0e202f37321c56fcf4c", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5605e86bfdc163e2749e6e7847f380f6d2a4bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<VWorkS.Data.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-inverse pr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-original-title", new global::Microsoft.AspNetCore.Html.HtmlString("Modificar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-modal", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-inverse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-original-title", new global::Microsoft.AspNetCore.Html.HtmlString("Eliminar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Usuarios";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id='myModal' class='modal fade' tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div id='myModalContent'></div>
        </div>
    </div>
</div>

<div class=""row"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">
                <h1 class=""card-title"">Usuarios</h1>
                <div class=""input-group"">
                    <input type=""text"" id=""search"" name=""search"" class=""form-control search-query pull-right"" placeholder=""Buscar..."" onkeypress=""Mensaje(event)""");
            BeginWriteAttribute("value", " value=\"", 793, "\"", 816, 1);
#nullable restore
#line 24 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 801, ViewBag.Filtro, 801, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <button class=\"btn btn-primary\" style=\"margin-right:1px;\" type=\"button\" onclick=\"Buscar()\"><span");
            BeginWriteAttribute("class", " class=\"", 936, "\"", 944, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"ti-search\"></i></span></button>\r\n                    ");
#nullable restore
#line 26 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
               Write(Html.ActionLink("Agregar Usuario", "UsuarioAgregar", "Usuario", null, new { data_modal = "modal", id = "btnCreate", @class = "btn btn-default btn-primary", @style = "margin-left:1px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>



                <br />
                <div class=""table-responsive"">
                    <table id=""demo-foo-addrow"" class=""table table-bordered m-t-30 table-hover"" data-paging=""true"" data-paging-size=""7"">
                        <thead class=""bg-info text-white"">
                            <tr>
                                <th width=""65%"">Nombre De Usuario</th>
                                <th width=""15%"">Estado</th>
                                <th width=""20%""></th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 43 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 47 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.NombreUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n");
#nullable restore
#line 50 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                         if (item.EstadoRegistro == "A")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>Activo</td>\r\n");
#nullable restore
#line 53 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>\r\n                                                <span class=\"badge badge-pill badge-danger\">Inactivo</span>\r\n                                            </td>\r\n");
#nullable restore
#line 59 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52bd0f57a132bf4298ada0e202f37321c56fcf4c10878", async() => {
                WriteLiteral("<i class=\"ti-marker-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2845, "~/Usuario/UsuarioEditar/", 2845, 24, true);
#nullable restore
#line 61 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
AddHtmlAttributeValue("", 2869, item.IdUsuario, 2869, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52bd0f57a132bf4298ada0e202f37321c56fcf4c12917", async() => {
                WriteLiteral(" <i class=\"ti-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3082, "~/Usuario/UsuarioEliminar/", 3082, 26, true);
#nullable restore
#line 62 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
AddHtmlAttributeValue("", 3108, item.IdUsuario, 3108, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 65 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>



                <div class=""row"">
                    <div class=""col-lg-10"">
                        <div class=""grid-container text-truncate"">
                        </div>
                    </div>
                    <div class=""col-lg-2"">
                        <div class=""grid-container text-truncate"">
                            <select class=""btn-info form-control text-white"" style=""font-size:inherit; align-content:center;"" id=""paginas"" name=""paginas"" onchange=""Paginador();"">
");
#nullable restore
#line 81 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                 for (int k = 5; k <= 30; k++)
                                {
                                    string k1 = k + "";
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                     if (ViewBag.Paginador == k)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52bd0f57a132bf4298ada0e202f37321c56fcf4c16565", async() => {
#nullable restore
#line 86 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                                                Write(k1);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                           WriteLiteral(k1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 87 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52bd0f57a132bf4298ada0e202f37321c56fcf4c19075", async() => {
#nullable restore
#line 90 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                                       Write(k1);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                           WriteLiteral(k1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 91 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                                     
                                    k = k + 4;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </select>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-12 text-center\">\r\n                        ");
#nullable restore
#line 101 "F:\BackUP\work\projectos\Eval\Evaluacion\CodigosFuente\VWorkS\Views\Usuario\Index.cshtml"
                   Write(Html.PagedListPager(Model, page => Url.Action("index", new { page, search = ViewBag.Filtro, Paginador = ViewBag.Paginador }), new PagedListRenderOptions { LinkToFirstPageFormat = "<< Primera", LinkToPreviousPageFormat = "< Anterior", LinkToNextPageFormat = "Siguiente >", LinkToLastPageFormat = "Ultima>>" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>





<script type=""text/javascript"">
    function Paginador() {
        var busqueda = $('#search').val();
        var paginado = $('#paginas').val();
        location.href = 'Usuario?Busqueda=' + busqueda + '&paginador=' + paginado;
    }

    function Buscar() {
        var busqueda = $('#search').val();
        var paginado = $('#paginas').val();
        location.href = 'Usuario?Busqueda=' + busqueda + '&paginador=' + paginado;;
    }

    function Mensaje(e) {
        if (e.keyCode == 13) {
            Buscar();
        }
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<VWorkS.Data.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
