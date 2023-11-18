﻿using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class Message : ITable
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long refUser { get; set; }
        public string? Content { get; set; }
        public int refMessageStatus { get; set; }
    }
}