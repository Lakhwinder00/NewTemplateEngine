using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class TemplateModel
    {
        public class Rootobject
        {
            public Schema schema { get; set; }
        }
        public class Schema
        {
            public Friends friends { get; set; }
        }

        public class Friends
        {
            public string type { get; set; }
            public Items items { get; set; }
        }

        public class Items
        {
            public string type { get; set; }
            public string title { get; set; }
            public Properties properties { get; set; }
        }

        public class Properties
        {
            public Nick nick { get; set; }
            public Gender gender { get; set; }
            public Age age { get; set; }
        }

        public class Nick
        {
            public string type { get; set; }
            public string title { get; set; }
            public bool required { get; set; }
        }

        public class Gender
        {
            public string type { get; set; }
            public string title { get; set; }
            public string[] _enum { get; set; }
        }

        public class Age
        {
            public string type { get; set; }
            public string title { get; set; }
        }

    }
}