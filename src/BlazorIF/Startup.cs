using BlazorIF.Core;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;


namespace BlazorIF
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            var game = new Game();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
