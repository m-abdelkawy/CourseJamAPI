﻿using System.Collections.Generic;

namespace CourseJamAPI.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public List<UserNotification> UserNotifications { get; set; }
    }
}