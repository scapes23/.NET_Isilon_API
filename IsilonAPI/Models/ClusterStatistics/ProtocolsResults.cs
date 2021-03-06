﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace IsilonAPI.Models.ClusterStatistics
{
    [DataContract]
    public class ProtocolsResults
    {
        [DataMember(Name = "protocols")]
        public Protocol[] Protocols;
    }
}
