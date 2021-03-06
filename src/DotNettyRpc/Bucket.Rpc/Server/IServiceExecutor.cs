﻿using Bucket.Rpc.Messages;
using Bucket.Rpc.Transport;
using System.Threading.Tasks;

namespace Bucket.Rpc.Server
{
    /// <summary>
    /// 一个抽象的服务执行器。
    /// </summary>
    public interface IServiceExecutor
    {
        /// <summary>
        /// 执行。
        /// </summary>
        /// <param name="sender">消息发送者。</param>
        /// <param name="message">调用消息。</param>
        Task ExecuteAsync(IMessageSender sender, TransportMessage message);
    }
}
