using System.Diagnostics.CodeAnalysis;
using System.Web.Optimization;

namespace T4MVCHostMvcApp.App_Start
{
    public static class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        [SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0")]
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle(Links.Bundles.Scripts.jquery).Include("~/scripts/jquery-{version}.js"));
            bundles.Add(new StyleBundle(Links.Bundles.Styles.bootstrap).Include("~/styles/bootstrap*.css"));
            bundles.Add(new StyleBundle(Links.Bundles.Styles.common).Include(Links.Bundles.Content.Assets.Site_css));

        }
    }
}

namespace Links
{
    public static partial class Bundles
    {
        public static partial class Scripts
        {
            public static readonly string jquery = "~/scripts/jquery";
            public static readonly string jqueryui = "~/scripts/jqueryui";
        }
        public static partial class Styles
        {
            public static readonly string bootstrap = "~/styles/boostrap";
            public static readonly string theme = "~/styles/theme";
            public static readonly string common = "~/styles/common";
        }
    }
}