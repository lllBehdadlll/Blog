﻿using BM.Domain.ArticleAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BM.Domain.CommentAgg
{
    public class Comment
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }
        public int Status { get; private set; }
        public DateTime CreationTime { get; private set; }
        public long ArticleId { get; private set; }
        public Article Article { get; private set; }

        protected Comment() { }
        public Comment(string name, string email, string message, long articleId)
        {
            Name = name;
            Email = email;
            Message = message;
            ArticleId = articleId;
            Status = Statuses.New;
            CreationTime = DateTime.Now;
        }

        public void Confirm()
        {
            Status = Statuses.Confirmed;
        }
        public void Reject() 
        {
            Status = Statuses.Rejected;
        }
    }
}