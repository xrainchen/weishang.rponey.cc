using weishang.rponey.cc.Model;
using weishang.rponey.cc.Model.ViewModel;

namespace weishang.rponey.cc.Service.PlatformPromotion
{
    public abstract class PlatformPromotionService : IPlatformPromotion
    {
        public abstract ExecuteResultModel CreateTemp(IViewModel model);
        public abstract ExecuteResultModel CreatePromotionScheme(IViewModel model);
    }
}
