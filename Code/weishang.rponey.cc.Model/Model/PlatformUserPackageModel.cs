using System;

namespace weishang.rponey.cc.Model.Model
{
    public class PlatformUserPackageModel : BaseModel
    {
        public string Name { get; set; }

        /// <summary>
        /// 价格（分）
        /// </summary>
        public int Price { get; set; }

        public string Content { get; set; }

        public PublicEnum.PublicEnum.PlatformUserPackageEnum PackageType { get; set; }

        public DateTime CreateOn { get; set; }
    }
}
