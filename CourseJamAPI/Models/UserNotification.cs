﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseJamAPI.Models
{
    public class UserNotification
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int NotificationId { get; set; }
        public Notification Notification { get; set; }
    }
}
