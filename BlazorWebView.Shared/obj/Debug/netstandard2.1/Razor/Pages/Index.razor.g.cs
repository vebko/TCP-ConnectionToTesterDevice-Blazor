#pragma checksum "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaaf9f9040b843ed10fe530decc28ad8a17efae1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWebView.Shared.Pages
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\_Imports.razor"
using BlazorWebView.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\_Imports.razor"
using BlazorWebView.Shared.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
using System.Net.Sockets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<AntDesign.Row>(3);
            __builder.AddAttribute(4, "Justify", "center");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(6, "\n        ");
                __builder2.OpenComponent<AntDesign.Col>(7);
                __builder2.AddAttribute(8, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 10 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
                   12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "\n        ");
                    __builder3.OpenElement(11, "h3");
                    __builder3.AddContent(12, 
#nullable restore
#line 11 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
             value

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(13, "\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n\n<br>\n\n");
            __builder.OpenElement(17, "div");
            __builder.AddMarkupContent(18, "\n    ");
            __builder.OpenComponent<AntDesign.Row>(19);
            __builder.AddAttribute(20, "Justify", "center");
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "\n        ");
                __builder2.OpenComponent<AntDesign.Col>(23);
                __builder2.AddAttribute(24, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 20 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
                   12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(26, "\n        ");
                    __Blazor.BlazorWebView.Shared.Pages.Index.TypeInference.CreateInput_0(__builder3, 27, 28, "IP: ", 29, "margin-right: 8px", 30, 
#nullable restore
#line 21 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
                                                ip

#line default
#line hidden
#nullable disable
                    , 31, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ip = __value, ip)), 32, () => ip);
                    __builder3.AddMarkupContent(33, "\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\n        ");
                __builder2.OpenComponent<AntDesign.Col>(35);
                __builder2.AddAttribute(36, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 23 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
                   12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(38, "\n        ");
                    __Blazor.BlazorWebView.Shared.Pages.Index.TypeInference.CreateInput_1(__builder3, 39, 40, "Port:", 41, "margin-left: 8px", 42, 
#nullable restore
#line 24 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
                                                 port

#line default
#line hidden
#nullable disable
                    , 43, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => port = __value, port)), 44, () => port);
                    __builder3.AddMarkupContent(45, "\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(46, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(47, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n\n<br>\n\n");
            __builder.OpenElement(49, "div");
            __builder.AddMarkupContent(50, "\n    ");
            __builder.OpenComponent<AntDesign.Row>(51);
            __builder.AddAttribute(52, "Justify", "center");
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(54, "\n        ");
                __builder2.OpenComponent<AntDesign.Col>(55);
                __builder2.AddAttribute(56, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 33 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
                   6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(58, "\n        ");
                    __builder3.OpenComponent<AntDesign.Button>(59);
                    __builder3.AddAttribute(60, "Type", "primary");
                    __builder3.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
                                         connect

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(63, "Connect");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(65, "\n        ");
                __builder2.OpenComponent<AntDesign.Col>(66);
                __builder2.AddAttribute(67, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 36 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
                   6

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\n        ");
                __builder2.OpenComponent<AntDesign.Col>(69);
                __builder2.AddAttribute(70, "Span", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<OneOf.OneOf<System.String, System.Int32>>(
#nullable restore
#line 37 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
                   6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(72, "\n        ");
                    __builder3.OpenComponent<AntDesign.Button>(73);
                    __builder3.AddAttribute(74, "Type", "primary");
                    __builder3.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
                                         disconnect

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "Danger", true);
                    __builder3.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(78, "Disconnect");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(79, "\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(80, "\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(81, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\11\Desktop\ConnectionWithBlazor\BlazorWebView.Shared\Pages\Index.razor"
        bool IsConnected { get; set; }
            public string value { get; set; } = "disconnected";
            public string ip { get; set; }
            public string port { get; set; }

            private TcpClient client;

            public void disconnect()
            {
                if (client != null)
                {
                    client.Close();
                    value = "Disconnected";
                }
            }

            public void connect()
            {
                Console.WriteLine("connecting.....");

                client = new TcpClient();
                client.ReceiveTimeout = 2000;
                client.SendTimeout = 2000;
                var result = client.BeginConnect(ip, Int32.Parse(port), null, null);
                int counter = 0;
                while (counter < 20)
                {
                    counter++;
                    Thread.Sleep(100);
                    if (client != null && client.Client != null && client.Connected)
                    {
                        IsConnected = true;
                        Console.WriteLine("connected");
                        value = "Connected";
                        return;
                    }

                }
                IsConnected = false;

                value = "disconnected";

                Console.WriteLine("can not connect");

            }
    

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorWebView.Shared.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInput_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInput_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Input<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
