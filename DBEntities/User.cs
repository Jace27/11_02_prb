using System;
using System.Collections.Generic;

namespace _11_02_21_prb.DBEntities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Ip { get; set; }
        public string LastEnter { get; set; }
        public string Services { get; set; }
        public int TypeId { get; set; }
    }
}
