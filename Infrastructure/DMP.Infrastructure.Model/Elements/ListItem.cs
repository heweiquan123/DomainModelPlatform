﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMP.Infrastructure.Model.Elements
{
    public class ListItem
    {

        public string Text { get; set; }

        public string Value { get; set; }

        public bool IsDefault { get; set; }

        public ListItem()
        { }
    }
}
