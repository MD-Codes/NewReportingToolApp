using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewReportingToolApp.Models.API
{
    public class ApiMembers
    {

        public partial class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public partial class Class1
        {
            public string member_id { get; set; }
            public string person_id { get; set; }
            public string name { get; set; }
            public string party { get; set; }
            public string constituency { get; set; }
            public Office[] office { get; set; }
        }

        public partial class Office
        {
            public string dept { get; set; }
            public string position { get; set; }
            public string from_date { get; set; }
            public string to_date { get; set; }
        }

    }
}
