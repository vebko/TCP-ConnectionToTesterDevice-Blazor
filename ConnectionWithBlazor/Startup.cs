using System.Net.Http;

using BlazorWebView;
using BlazorWebView.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace ConnectionWithBlazor
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<HttpClient>();
            services.AddAntDesign();
        }

        /// <summary>
        /// Configure the app.
        /// </summary>
        /// <param name="app">The application builder for apps.</param>
        public void Configure(ApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}