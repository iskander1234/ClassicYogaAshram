﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace yogaAshram.Models
{
    public enum AttendanceState
    {
        attended=1,
        notattended=2,
        frozen=3,
        notcheked=4
    }
    public class Attendance
    {
        public long Id { get; set; }
        public long  ClientId  { get; set; }
        public virtual Client  Client { get; set; }
        public long  GroupId  { get; set; }
        public virtual Group  Group { get; set; }
        public int AttendanceDays { get; set; }
        public AttendanceState AttendanceState { get; set; } = Models.AttendanceState.notcheked;
        public bool IsChecked { get; set; } = false;
        public List<DateTime> DatesOfAttendance { get; set; }
        public List<DateTime> DatesOfAbsence { get; set; }
        

        
    }
}