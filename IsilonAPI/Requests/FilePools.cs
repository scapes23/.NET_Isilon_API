﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IsilonAPI.Models.FilePools;


namespace IsilonAPI.Requests
{
    public class FilePools : Core
    {
        public FilePools(string Username, string Password, string IsilonUrl, bool IgnoreInvalidCerts)
            : base(Username, Password, IsilonUrl, IgnoreInvalidCerts)
        {

        }

        public string GetDefaultPolicy()
        {
            RequestResult res = RunResult("/platform/1/filepool/default-policy");
            return (string)res.Content;
        }
    }
}
