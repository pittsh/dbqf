﻿using dbqf.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace dbqf.Criterion
{
    /// <summary>
    /// Represents a combination of parameters that are unioned (OR).
    /// </summary>
    public abstract class Disjunction : Junction
    {
        protected override string Op
        {
            get { return "or"; }
        }

        public Disjunction()
        {
        }
    }
}
