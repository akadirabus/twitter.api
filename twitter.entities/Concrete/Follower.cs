﻿using twitter.entities.Interfaces;

namespace twitter.entities.Concrete
{
    public class Follower : ITable
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long refUser { get; set; }
    }
}