using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace TranLeQuyen_5951071088.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "NameSt")]
        public string NameSt { get; set; }
        [DataMember(Name = "Age")]
        public int Age { get; set; }
        [DataMember(Name = "Student_code")]
        public string Student_code { get; set; }

      
    } }  