﻿using SSRD.IdentityUI.Core.Data.Entities.Group;
using SSRD.IdentityUI.Core.Data.Enums.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSRD.IdentityUI.Core.Data.Entities
{
    public class InviteEntity : IBaseEntity
    {
        public string Id { get; private set; }

        public string Email { get; private set; }
        public string Token { get; private set; }
        public InviteStatuses Status { get; private set; }

        public string GroupId { get; private set; }
        public GroupEntity Group { get; private set; }

        public DateTimeOffset ExpiresAt { get; private set; }

        public DateTimeOffset? _CreatedDate { get; set; }
        public DateTimeOffset? _ModifiedDate { get; set; }

        public InviteEntity(string email, string token, InviteStatuses status, string groupId, DateTimeOffset expiresAt)
        {
            Email = email;
            Token = token;
            Status = status;
            GroupId = groupId;
            ExpiresAt = expiresAt;
        }

        public void Update(InviteStatuses status)
        {
            Status = status;
        }
    }
}
