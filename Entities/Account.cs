﻿using System;
using System.Collections.Generic;
using fin_app_backend.Entities.Base;

#nullable disable

namespace fin_app_backend
{
  public partial class Account : Entity
  {
    public Account()
    {
      Transactions = new HashSet<Transaction>();
    }
    public string Currency { get; set; }
    public string Name { get; set; }
    public double Balance { get; set; }
    public string UserId { get; set; }

    public virtual User User { get; set; }
    public virtual ICollection<Transaction> Transactions { get; set; }
  }
}
