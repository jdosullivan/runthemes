﻿using System;

namespace RunThemes.Data.Models
{
    public class Promotion : ModelBase
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long CompanyId { get; set; }
    }
}