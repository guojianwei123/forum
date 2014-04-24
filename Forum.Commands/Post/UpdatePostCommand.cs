﻿using System;
using ENode.Commanding;

namespace Forum.Commands.Post
{
    [Serializable]
    public class UpdatePostCommand : Command<string>
    {
        public string Subject { get; private set; }
        public string Body { get; private set; }

        public UpdatePostCommand(string id, string subject, string body) : base(id)
        {
            Subject = subject;
            Body = body;
        }
    }
}
