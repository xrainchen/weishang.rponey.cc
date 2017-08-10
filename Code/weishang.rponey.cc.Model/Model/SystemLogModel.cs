using System;

namespace weishang.rponey.cc.Model.Model
{
    public class SystemLogModel : BaseModel
    {
        public string Content { get; set; }

        public long CreatedBy { get; set; }

        public PublicEnum.PublicEnum.SystemLogTypeEnum LogType { get; set; }

        public DateTime CreateOn { get; set; }
    }
}
