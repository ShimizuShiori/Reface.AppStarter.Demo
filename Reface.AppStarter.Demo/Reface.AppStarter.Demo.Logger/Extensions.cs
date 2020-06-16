namespace Reface.AppStarter.Demo.Logger
{
    public static class Extensions
    {
        public static void Info(this ILogger logger, string content)
        {
            logger.Output(LoggerLevel.Info, content);
        }

        public static void Warning(this ILogger logger, string content)
        {
            logger.Output(LoggerLevel.Warning, content);
        }

        public static void Error(this ILogger logger, string content)
        {
            logger.Output(LoggerLevel.Error, content);
        }

        public static void Message(this ILogger logger, string content)
        {
            logger.Output(LoggerLevel.Message, content);
        }
    }
}
