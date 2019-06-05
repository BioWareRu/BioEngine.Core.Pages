using BioEngine.Core.API;
using BioEngine.Core.Modules;
using BioEngine.Core.Search;
using BioEngine.Pages.Entities;
using BioEngine.Pages.Search;
using BioEngine.Pages.SiteMaps;
using cloudscribe.Web.SiteMap;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BioEngine.Pages
{
    public class PagesModule : BaseBioEngineModule
    {
        public override void ConfigureServices(IServiceCollection services, IConfiguration configuration,
            IHostEnvironment environment)
        {
            base.ConfigureServices(services, configuration, environment);
            services.RegisterSearchRepositoryHook<Page>()
                .RegisterSearchProvider<PagesSearchProvider, Page>();
            services.AddScoped<ISiteMapNodeService, PagesSiteMapNodeService>();
            services.RegisterApiEntities<Page>();
        }
    }
}
