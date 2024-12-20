﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBuddy.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string UserName { get; set; } 
        public string EmailAddress { get; set; }
        public string Password { get; set; }

       
        public TenantMappingEntity TenantMapping { get; set; } 
        public ICollection<LikeEntity> Likes { get; set; }
        public ICollection<TweetEntity> Tweets { get; set; }
        public ICollection<FollowEntity> Followings { get; set; }
    }
}