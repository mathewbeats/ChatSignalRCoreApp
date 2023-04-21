#pragma checksum "C:\Users\alexm\source\repos\ChatSignalRCoreApp\ChatSignalRCoreApp\Views\Chats\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7ccd32d192795b0980720245d6ffca63401a609"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chats_Chat), @"mvc.1.0.view", @"/Views/Chats/Chat.cshtml")]
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
#line 1 "C:\Users\alexm\source\repos\ChatSignalRCoreApp\ChatSignalRCoreApp\Views\_ViewImports.cshtml"
using ChatSignalRCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alexm\source\repos\ChatSignalRCoreApp\ChatSignalRCoreApp\Views\_ViewImports.cshtml"
using ChatSignalRCoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7ccd32d192795b0980720245d6ffca63401a609", @"/Views/Chats/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"397cce2d8cc133cc1aa3cd0e7622abe8150b6600", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Chats_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1 class=\"text-center\">");
#nullable restore
#line 4 "C:\Users\alexm\source\repos\ChatSignalRCoreApp\ChatSignalRCoreApp\Views\Chats\Chat.cshtml"
                   Write(ChatSignalIr.Controllers.ChatsController.ListaChats.GetValueOrDefault(Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""row justify-content-center"">
    <div class=""mb-2"">
        <input class=""form-control"" type=""text"" placeholder=""introduzca su Usuario"" id=""user"" />
        <input class=""form-control"" type=""text"" placeholder=""introduzca su Mensaje"" id=""message"" />
        <div class=""text-center"">
            <button id=""btnEnviar"" type=""button"" class=""btn btn-success"">Enviar</button>
        </div>
    </div>
</div>

<div class=""row justify-content-center"">
    <div class=""col-10"">
        <ul class=""list-group"" id=""Mensajes"">
        </ul>
    </div>
</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7ccd32d192795b0980720245d6ffca63401a6094559", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            //primero estamos creando el objeto de conexion
            var conexion = new signalR.HubConnectionBuilder().withUrl(""/Chats"").build();
            //Despues iniciamos la conexion y nos añadimos al grupo mediante la funcion ""AddToGroup""
            conexion.start().then(() => {
                conexion.invoke(""AddToGroup"", """);
#nullable restore
#line 34 "C:\Users\alexm\source\repos\ChatSignalRCoreApp\ChatSignalRCoreApp\Views\Chats\Chat.cshtml"
                                          Write(Model);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""");
            }).then(() => console.log(conexion));
            //En el momento que demos click, obtenemos los datos de los inputs y lo mandamos mediante
            //la función ""SendMessage""
            $(""#btnEnviar"").click(function (e) {
                let room = ");
#nullable restore
#line 39 "C:\Users\alexm\source\repos\ChatSignalRCoreApp\ChatSignalRCoreApp\Views\Chats\Chat.cshtml"
                      Write(Model);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                let user = $(""#user"").val();
                let mensaje = $(""#message"").val();
                conexion.invoke('SendMessage', room, user, mensaje);
                $(""#message"").val("""");
                $(""#message"").focus();
                //Para que no recargue la pagina
                e.preventDefault();
            });
            //Si la conexion esta activa y un mensaje se manda, se activa la funcion ""RecibirMensaje""
            //y nos mostrara en tiempo real el mensaje y el usuario
            conexion.on(""RecibirMensaje"", (user, mensaje) => {
                let li = $(""<li>"", {""class"": ""list-group-item""});
                let small = $(""<small>"", { ""text"": user + ""  -  "" });
                li.append(small);
                li.append(mensaje);
                $(""#Mensajes"").append(li);
            });
        });
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
