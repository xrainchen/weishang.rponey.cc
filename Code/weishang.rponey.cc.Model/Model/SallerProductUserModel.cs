using System;

namespace weishang.rponey.cc.Model.Model
{
    public class SallerProductUserModel : BaseModel
    {
        public string WxOpenId { get; set; }

        public string NickName { get; set; }

        public PublicEnum.PublicEnum.SexEnum Sex { get; set; }

        public string HeadImgUrl { get; set; }

        public string WxUnionId { get; set; }

        public DateTime RegTime { get; set; }
    }
}
