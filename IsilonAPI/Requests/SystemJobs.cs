﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsilonAPI.Requests
{
    public class SystemJobs : Core
    {
        public SystemJobs(string Username, string Password, string IsilonUrl, bool IgnoreInvalidCerts)
            : base(Username, Password, IsilonUrl, IgnoreInvalidCerts)
        {

        }
    }
}
