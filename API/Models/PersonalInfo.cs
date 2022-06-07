using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class PersonalInfo
    {
           public PersonalInfo(int id, string name, long phoneNumber) 
        {
            this.Id = id;
            this.Name = name;
            this.PhoneNumber = phoneNumber;
   
        }
        [Required]
        public int Id{get;set;}
        
        public string Name{get;set;}

        public long PhoneNumber{get;set;}
    }
}