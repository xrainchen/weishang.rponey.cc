using RPoney.Utilty.Extend;

namespace weishang.rponey.cc.Model.PublicEnum
{
    public partial class PublicEnum
    {
        /// <summary>
        /// 平台活动策划类型
        /// </summary>
        public enum PlatformPromotionSchemeTypeEnum
        {
            /// <summary>
            /// 大转盘
            /// </summary>
            [Remark("大转盘")]
            BigWheel =1,

        }
        /// <summary>
        /// 平台活动策划状态
        /// </summary>
        public enum PlatformPromotionSchemeStatusEnum
        {
            /// <summary>
            /// 策划中
            /// </summary>
            [Remark("策划中")]
            Planing = 1,
            /// <summary>
            /// 上线
            /// </summary>
            [Remark("上线")]
            OnLine = 2,
            /// <summary>
            /// 下架
            /// </summary>
            [Remark("下架")]
            OffLine = 3
        }
    }
}
