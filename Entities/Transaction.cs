﻿using System;
using System.Collections.Generic;

#nullable disable

namespace fin_app_backend
{
    public partial class Transaction
    {
        public Transaction()
        {
            Transactiontags = new HashSet<Transactiontag>();
        }

        public int Id { get; set; }
        public double? Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public bool? Expense { get; set; }
        public int? AccountId { get; set; }
        public int? UserId { get; set; }
        public sbyte Transfer { get; set; }

        public virtual Account Account { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Transactiontag> Transactiontags { get; set; }
    }
}