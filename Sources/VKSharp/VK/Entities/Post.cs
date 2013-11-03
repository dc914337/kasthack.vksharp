﻿using VKSharp.VK.EntityParsers;
using VKSharp.VK.Helpers.DataTypes;
using VKSharp.VK.Interfaces;

namespace VKSharp.VK.Entities {
    public class Post : IVKEntity<Post> {
        public bool FriendsOnly { get; set; }
        public Geo Geo { get; set; }
        public Group[] Groups { get; set; }
        public int CopyOwnerID { get; set; }
        public int CopyPostType { get; set; }
        public int FromID { get; set; }
        public int ReplyOwnerID { get; set; }
        public int ToID { get; set; }
        public Post[] CopyHistory { get; set; }
        public PostComments Comments { get; set; }
        public PostLikes PostLikes { get; set; }
        public PostSource PostSource { get; set; }
        public PostType PostType { get; set; }
        public string CopyText { get; set; }
        public string Text { get; set; }
        public uint Date { get; set; }
        public uint CopyPostDate { get; set; }
        public uint ID { get; set; }
        public uint ReplyPostID { get; set; }
        public uint? SignerID { get; set; }
        public User[] Profiles { get; set; }
        public IVKEntityParser<Post> GetParser() {
            return PostParser.Instanse;
        }
    }
}