﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigpus.model
{
    public class Magazine : Book
    {
        public override string GetTitle()
        {
            return Title;
        }
    }
}
