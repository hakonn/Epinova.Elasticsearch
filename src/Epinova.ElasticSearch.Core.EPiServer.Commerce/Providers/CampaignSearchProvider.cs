using Epinova.ElasticSearch.Core.EPiServer.Providers;
using EPiServer.Core.Internal;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using EPiServer.Shell.Search;


namespace Epinova.ElasticSearch.Core.EPiServer.Commerce.Providers
{
    [SearchProvider]
    public class CampaignSearchProvider : SearchProviderBase<IContent, IContent, ContentType>
    {
        // ReSharper disable UnusedAutoPropertyAccessor.Local
        private static Injected<ContentRootService> RootService { get; set; }
        private static Injected<DefaultContentProvider> DefaultContentProvider { get; set; }
        // ReSharper restore UnusedAutoPropertyAccessor.Local

        public CampaignSearchProvider() : base("campaigns")
        {
            IconClass = Constants.CommerceCampaignsIconCssClass;
            AreaName = Constants.CommerceCampaignsArea;
            ForceRootLookup = true;
        }

        protected override string GetSearchRoot()
        {
            return RootService.Service.Get("SysCampaignRoot").ID.ToString();
        }

        protected override string[] GetProviderKeys()
        {
            return new[]
            {
                ProviderConstants.CatalogProviderKey,
                DefaultContentProvider.Service.ProviderKey ?? ProviderConstants.DefaultProviderKey
            };
        }
    }
}