#pragma checksum "C:\Users\andre\OneDrive\Documentos\Programação\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaa1d4ecdc933c5a7380359af63c102e8971a8af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
#line 2 "C:\Users\andre\OneDrive\Documentos\Programação\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Views\_ViewImports.cshtml"
using PrimeiroProjeto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaa1d4ecdc933c5a7380359af63c102e8971a8af", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d25e9132e0e267f768743c79ea535a0daffcfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\andre\OneDrive\Documentos\Programação\ASPNETCoreMVCLojaVirtual\Seção 02\PrimeiroProjeto\PrimeiroProjeto\Views\Home\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main role=""main"">
    <br />
    <br />
    <section class=""container"">
        <aside class=""col-sm-4"">
            <h3 class=""subtitle-doc"">
                # Login form simple
                <a href=""#"" data-html=""code_login_1"" class=""showcode"">[code]</a>
            </h3>
            <div id=""code_login_1"">
                <div class=""card"">
                    <article class=""card-body"">
                        <a href=""/Home/CadastroCliente"" class=""float-right btn btn-outline-primary"">Sign up</a>
                        <h4 class=""card-title mb-4 mt-1"">Sign in</h4>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaa1d4ecdc933c5a7380359af63c102e8971a8af4088", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label>Your email</label>\r\n                                <input");
                BeginWriteAttribute("name", " name=\"", 822, "\"", 829, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control"" placeholder=""Email"" type=""email"">
                            </div> <!-- form-group// -->
                            <div class=""form-group"">
                                <a class=""float-right"" href=""#"">Forgot?</a>
                                <label>Your password</label>
                                <input class=""form-control"" placeholder=""******"" type=""password"">
                            </div> <!-- form-group// -->
                            <div class=""form-group"">
                                <div class=""checkbox"">
                                    <label> <input type=""checkbox""> Save password </label>
                                </div> <!-- checkbox .// -->
                            </div> <!-- form-group// -->
                            <div class=""form-group"">
                                <button type=""submit"" class=""btn btn-primary btn-block""> Login </button>
                            </div> <!-- form-group// -->
                   ");
                WriteLiteral("     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </article>\r\n                </div> <!-- card.// -->\r\n            </div> <!-- code-wrap.// -->\r\n        </aside>\r\n    </section>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
