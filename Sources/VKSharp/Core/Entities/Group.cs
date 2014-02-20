﻿using VKSharp.Core.EntityFragments;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;

namespace VKSharp.Core.Entities {
    public class Group:IVKEntity<Group> {
        
        public bool IsAdmin { get; set; }
        public bool IsClosed { get; set; }
        public bool IsMember { get; set; }
        public bool? CanCreateTopic { get; set; }
        public bool? CanPost { get; set; }
        public bool? CanSeeAllPosts { get; set; }
        public bool? Verified { get; set; }
        public GroupAdminLevel AdminLevel { get; set; }
        public GroupCounters Counters { get; set; }
        public PageType PageType { get; set; }
        public Place Place { get; set; }
        public ProfilePhotos Photos { get; set; }
        public string Contacts { get; set; }
        public string Description { get; set; }
        public string Links { get; set; }
        public string Name { get; set; }
        public string ScreeName { get; set; }
        public string Site { get; set; }
        public string Status { get; set; }
        public string WikiPage { get; set; }
        public uint ID { get; set; }
        public uint? City { get; set; }
        public uint? Country { get; set; }
        public uint? EndDate { get; set; }
        public uint? MembersCount { get; set; }
        public uint? PostID { get; set; }
        public uint? StartDate { get; set; }

        public VKApi Context { get; set; }
    }
}