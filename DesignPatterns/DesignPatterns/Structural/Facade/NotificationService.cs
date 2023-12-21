namespace DesignPatterns.Structural.Facade
{
    /// <summary>
    /// Facade
    /// </summary>
    internal class NotificationService
    {
        public void Send(string message, string target)
        {
            NotificationServer notificationServer = new NotificationServer();
            notificationServer.Connect(target);
            var authToken = notificationServer.authentication("AppId", "Key");
            notificationServer.Send(authToken,new Message(message),target);
        }
    }
}
