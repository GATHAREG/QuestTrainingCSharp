﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBookMemberGeneric.Entities
{
    internal class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public int BookId { get; set; }
    }
}
