﻿using Core.Entities;

namespace Entities.Concretes
{
    public class Title : Entity<Guid>
    {
        public Guid TopicId { get; set; }
        public Guid LikeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Point { get; set; }
        public string Subtype { get; set; }
        public string VideoLanguage { get; set; }
        public string VideoLink { get; set; }
        public Topic? Topic { get; set; }
        public Like? Like { get; set; }
    }
}
