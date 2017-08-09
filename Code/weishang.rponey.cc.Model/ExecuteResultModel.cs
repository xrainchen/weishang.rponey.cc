namespace weishang.rponey.cc.Model
{
    /// <summary>
    /// 执行结果模型
    /// </summary>
    public class ExecuteResultModel
    {
        /// <summary>
        /// 返回码
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 错误消息
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
        public object Data { get; set; }
    }
}
