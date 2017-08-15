using System;
using weishang.rponey.cc.Dal;
using weishang.rponey.cc.Model.Model;

namespace weishang.rponey.cc.Bll
{
    public class SystemLogBll
    {
        private readonly Lazy<SystemLogDal> _systemDal = new Lazy<SystemLogDal>();
        public long Add(SystemLogModel model)
        {
            return _systemDal.Value.Add(model);
        }
    }
}
