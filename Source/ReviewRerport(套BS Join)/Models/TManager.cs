﻿using System;
using System.Collections.Generic;

namespace ReviewRerport.Models
{
    public partial class TManager
    {
        public int FSid { get; set; }
        public string FAccount { get; set; } = null!;
        public string FPassword { get; set; } = null!;
    }
}
