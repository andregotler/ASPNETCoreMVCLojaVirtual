#pragma checksum "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c1a6944cb04ffce3f95e987328faa4600f661c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Categoria_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Categoria/Index.cshtml")]
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
#line 2 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\_ViewImports.cshtml"
using PrimeiroProjeto.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\_ViewImports.cshtml"
using PrimeiroProjeto.Models.Constante;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c1a6944cb04ffce3f95e987328faa4600f661c8", @"/Areas/Colaborador/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbdd8463914c99d7d8a8e760e7da41e2de37cdd1", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<PrimeiroProjeto.Models.Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Categoria</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c1a6944cb04ffce3f95e987328faa4600f661c86234", async() => {
                WriteLiteral("Cadastrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 10 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
 if (TempData["MSG_S"] != null) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 11 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                              Write(Html.Raw(TempData["MSG_S"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 12 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
 if (Model.Count > 0) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"table-responsive\">\r\n        <table class=\"table table-bordered\">\r\n            <thead>\r\n                <tr>\r\n                    <th scope=\"col\">");
#nullable restore
#line 18 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
#nullable restore
#line 19 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
#nullable restore
#line 20 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().CategoriaPai));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th scope=\"col\">Ações</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 25 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                 foreach (Categoria categoria in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 27 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                   Write(categoria.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                       Write(categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n\r\n                            ");
#nullable restore
#line 31 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                       Write(Html.DisplayFor(Model => categoria.CategoriaPai.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            -\r\n                            ");
#nullable restore
#line 33 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                       Write(Html.DisplayFor(Model => categoria.CategoriaPai.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c1a6944cb04ffce3f95e987328faa4600f661c812157", async() => {
                WriteLiteral("Atualizar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                                        WriteLiteral(categoria.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c1a6944cb04ffce3f95e987328faa4600f661c814515", async() => {
                WriteLiteral("Excluir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                                      WriteLiteral(categoria.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 40 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
#nullable restore
#line 44 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina })));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                                                                          
}
else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <Span> Nenhum registro cadastrado! </Span>");
#nullable restore
#line 47 "C:\Users\André Gotler\Documents\GitHub\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Areas\Colaborador\Views\Categoria\Index.cshtml"
                                              }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<PrimeiroProjeto.Models.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
