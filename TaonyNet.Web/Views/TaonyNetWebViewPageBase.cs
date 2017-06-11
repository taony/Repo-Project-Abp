using Abp.Web.Mvc.Views;

namespace TaonyNet.Web.Views
{
    public abstract class TaonyNetWebViewPageBase : TaonyNetWebViewPageBase<dynamic>
    {

    }

    public abstract class TaonyNetWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected TaonyNetWebViewPageBase()
        {
            LocalizationSourceName = TaonyNetConsts.LocalizationSourceName;
        }
    }
}