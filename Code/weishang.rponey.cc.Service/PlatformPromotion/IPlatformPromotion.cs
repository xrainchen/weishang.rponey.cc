using weishang.rponey.cc.Model;
using weishang.rponey.cc.Model.Model;
using weishang.rponey.cc.Model.ViewModel;

namespace weishang.rponey.cc.Service.PlatformPromotion
{
    public interface IPlatformPromotion
    {
        /// <summary>
        /// 创建活动模版
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ExecuteResultModel CreateTemp(IViewModel model);
        /// <summary>
        /// 创建活动策划案
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        ExecuteResultModel CreatePromotionScheme(IViewModel model);


    }
}
