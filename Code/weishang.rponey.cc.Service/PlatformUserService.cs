using System;
using weishang.rponey.cc.Model;
using weishang.rponey.cc.Model.ViewModel;

namespace weishang.rponey.cc.Service
{
    /// <summary>
    /// 平台用户服务
    /// </summary>
    public class PlatformUserService
    {
        /// <summary>
        /// PC端注册
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ExecuteResultModel PcRegister(BaseViewModel model)
        {
            //todo:验证

            //todo:添加
            throw new ArgumentNullException();
        }
        /// <summary>
        /// 微信端注册
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ExecuteResultModel WeiXinRegister(BaseViewModel model)
        {
            throw new ArgumentNullException();
        }
        /// <summary>
        /// 绑定微信号
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public ExecuteResultModel BindWeiXin(BaseViewModel model)
        {
            throw new ArgumentNullException();
        }
    }
}
