using Microsoft.WindowsAzure.Mobile.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dreamcometotruenetService.DataObjects
{
    public class User : EntityData
    {
        public string UserName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string IMEI { get; set; }
        public bool IsEnable { get; set; }
    }
}