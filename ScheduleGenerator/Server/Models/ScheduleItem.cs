﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ScheduleGenerator.Shared.Enums;

namespace ScheduleGenerator.Server.Models
{
    public class ScheduleItem
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string RoomNumber { get; set; }
        public string Lecturer { get; set; }
        [Range(0, 6)]
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        [Range(0, 5)]
        public TypeOfClasses TypeOfClasses { get; set; }
        [Range(0, 5)]
        public Color Color { get; set; }
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}
