using NLog;
using OweWay.Application.Contracts;
using System;

namespace OweWay.Infrastructure.Nlogger
{
    public class NLogLoggerService : ILoggerService
    {
        private static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        public void Info(string message) => _logger.Info(message);

        public void Warn(string message) => _logger.Warn(message);

        public void Error(string message, Exception ex = null)
        {
            if (ex != null)
                _logger.Error(ex, message);
            else
                _logger.Error(message);
        }

        public void Debug(string message) => _logger.Debug(message);
    }
}
