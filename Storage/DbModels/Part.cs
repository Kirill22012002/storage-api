﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Storage.DbModels
{
    public partial class Part
    {
        public long Id { get; set; }
        public long? IdProduct { get; set; }
        public int? Amount { get; set; }
        public DateTime? Datefiling { get; set; }

        public virtual Product IdProductNavigation { get; set; }
    }
}