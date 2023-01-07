﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.DataLayer
{
    class Secretary
    {
        public int SecretaryId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNum { get; set; }

        public Secretary(int SecretaryId, string Name, string LastName, string PhoneNum)
        {
            this.SecretaryId = SecretaryId;
            this.Name = Name;
            this.LastName = LastName;
            this.PhoneNum = PhoneNum;
        }
    }
}