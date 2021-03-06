﻿using System;

namespace AccountingTool.DAL.Models
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }
        DateTime AddedDate { set; get; }
        DateTime ModifiedDate { set; get; }
    }
}