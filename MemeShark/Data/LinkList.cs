using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;
using Newtonsoft.Json;

namespace MemeShark.Data
{
    // Read and parse data from grabber output (lists.json)
    public class LinkList
    {
        public Dictionary<string, string> links { get; set; }
    }
}
