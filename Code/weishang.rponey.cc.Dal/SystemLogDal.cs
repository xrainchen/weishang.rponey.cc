using System;
using System.Data;
using System.Data.SqlClient;
using cms.rponey.cc.DbHelper;
using RPoney;
using RPoney.Log;
using weishang.rponey.cc.Model.Model;

namespace weishang.rponey.cc.Dal
{
    public class SystemLogDal
    {
        /// <summary>
        /// 添加日志记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public long Add(SystemLogModel model)
        {
            const string description = "添加系统日志";
            try
            {
                var sql = @"
                    Insert Into
                    SystemLog(Content,CreatedBy,LogType,CreateOn)
                    Values(@Content,@CreatedBy,@LogType,@CreateOn);
                    Select @@IDENTITY";
                var paras = new IDataParameter[]
                {
                    new SqlParameter("@Content",SqlDbType.NVarChar){Value = model.Content},
                    new SqlParameter("@CreatedBy",SqlDbType.BigInt){Value = model.CreatedBy},
                    new SqlParameter("@LogType",SqlDbType.Int){Value = model.LogType},
                    new SqlParameter("@CreateOn",SqlDbType.DateTime){Value = DateTime.Now},
                };
                LoggerManager.Debug(GetType().Name, $"{description},sql:{sql},model:{model.SerializeToJSON()}");
                return DataBaseManager.MainDb().ExecuteScalar(sql, paras).CInt(0, false);
            }
            catch (Exception e)
            {
                LoggerManager.Error(GetType().Name, $"{description}", e);
                return 0;
            }
        }
    }
}