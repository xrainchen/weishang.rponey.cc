using RPoney.Utilty.Extend;

namespace weishang.rponey.cc.Model.PublicEnum
{
    public partial class PublicEnum
    {
        /// <summary>
        /// 平台用户等级
        /// </summary>
        public enum PlatformUserRankEnum
        {
            /// <summary>
            /// 普通会员
            /// </summary>
            [Remark("普通会员")]
            Vip1 = 1,
            /// <summary>
            /// 黄金会员
            /// </summary>
            [Remark("黄金会员")]
            Vip2 = 2,
            /// <summary>
            /// 白金会员
            /// </summary>
            [Remark("白金会员")]
            Vip3 = 3,
        }
        /// <summary>
        /// 性别
        /// </summary>
        public enum SexEnum
        {
            /// <summary>
            /// 未知
            /// </summary>
            [Remark("未知")]
            Unknow = 0,
            /// <summary>
            /// 男
            /// </summary>
            [Remark("男")]
            Male = 1,
            /// <summary>
            /// 女
            /// </summary>
            [Remark("女")]
            FeMale = 2
        }
    }
}
