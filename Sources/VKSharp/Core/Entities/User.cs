﻿using VKSharp.Core.EntityFragments;
using VKSharp.Core.Enums;
using VKSharp.Core.Interfaces;
using VKSharp.Helpers.DataTypes;

namespace VKSharp.Core.Entities {
    public class User : IVKEntity<User> {
        public Audio StatusAudio { get; set; }

        public bool? BlackListed { get; set; }
        public bool? CanPost { get; set; }
        public bool? CanSeeAllPosts { get; set; }
        public bool? CanSeeAudio { get; set; }
        public bool? CanWritePrivateMessage { get; set; }
        public bool? Deactivated { get; set; }
        public bool? HasMobile { get; set; }
        public bool? Hidden { get; set; }
        public bool? Online { get; set; }
        public bool? OnlineMobile { get; set; }
        public bool? Verified { get; set; }
        public bool? WallComments { get; set; }
        
        public byte Timezone { get; set; }
        
        public Date BDate { get; set; }
        
        public Exports Exports { get; set; }
        
        public LastSeen LastSeen { get; set; }
        
        public ProfileCounters Counters { get; set; }
        
        public ProfilePhotos ProfilePhotos { get; set; }
        
        public Relation? Relation { get; set; }
        
        public Relative[] Relatives { get; set; }
        
        public School[] Schools { get; set; }
        
        public Sex? Sex { get; set; }
        
        public SiteProfiles Connections { get; set; }
        
        public string About { get; set; }
        public string Activities { get; set; }
        public string Books { get; set; }
        public string Domain { get; set; }
        public string FacultyName { get; set; }
        public string FirstName { get; set; }
        public string Games { get; set; }
        public string HomePhone { get; set; }
        public string HomeTown { get; set; }
        public string Interests { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string Movies { get; set; }
        public string Music { get; set; }
        public string NickName { get; set; }
        public string Quotes { get; set; }
        public string Site { get; set; }
        public string Status { get; set; }
        public string Tv { get; set; }
        public string UniversityName { get; set; }

        public uint? CommonCount { get; set; }
        public uint ID { get; set; }
        public uint? City { get; set; }
        public uint? Country { get; set; }
        public uint? Faculty { get; set; }
        public uint? OnlineApp { get; set; }
        public uint? University { get; set; }

        public uint[] Lists { get; set; }
        
        public University[] Universities { get; set; }
        
        public ushort? Graduation { get; set; }

        public VKApi Context { get; set; }
        
        public override string ToString() {
            return "ID :" + this.ID;
        }
    }
}