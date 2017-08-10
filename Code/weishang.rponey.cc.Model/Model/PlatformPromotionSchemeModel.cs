using System;

namespace weishang.rponey.cc.Model.Model
{
    public class PlatformPromotionSchemeModel : BaseModel
    {
        public string Title { get; set; }

        public string Cover { get; set; }

        public DateTime CreateOn { get; set; }

        public PublicEnum.PublicEnum.PlatformPromotionSchemeTypeEnum SchemeType { get; set; }

        public long SchemeTempId { get; set; }

        public PublicEnum.PublicEnum.PlatformPromotionSchemeStatusEnum SchemeStatus { get; set; }
    }
}
