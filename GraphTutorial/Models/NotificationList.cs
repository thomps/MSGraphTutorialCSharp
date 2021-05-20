namespace GraphTutorial.Models
{
    // Class representing an array of notifications
    // in a notification payload
    public class NotificationList
    {
        public ChangeNotificationPayload[] Value { get;set; }
    }
}