﻿namespace twitter_api.Models
{
    public class Follower
    {
        public long Id { get; set; }
        public DateTime RecordTime { get; set; }
        public long refUser { get; set; }
    }
}