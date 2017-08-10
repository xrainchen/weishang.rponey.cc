using weishang.rponey.cc.Model.PublicEnum;
using weishang.rponey.cc.Service.PlatformPromotion.Imp;

namespace weishang.rponey.cc.Service.PlatformPromotion
{
    public class PlatformPromotionManager
    {
        public PlatformPromotionService Service(PublicEnum.PlatformPromotionSchemeTypeEnum schemeType)
        {
            switch (schemeType)
            {
                case PublicEnum.PlatformPromotionSchemeTypeEnum.BigWheel:
                    return new BigWheelPlatformPromotionService();
                default:
                    return null;
            }
        }
    }
}
