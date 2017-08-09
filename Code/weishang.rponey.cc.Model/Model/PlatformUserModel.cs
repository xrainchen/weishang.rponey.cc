using System;

namespace weishang.rponey.cc.Model.Model
{
    public class PlatformUserModel : BaseModel
    {
        public PublicEnum.PublicEnum.PlatformUserRankEnum Rank { get; set; }

        public DateTime RegTime { get; set; }

        public string WxOpenId { get; set; }

        public string NickName { get; set; }

        public PublicEnum.PublicEnum.SexEnum Sex { get; set; }

        public string HeadImgUrl { get; set; }

        public string WxUnionId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}
