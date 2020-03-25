using Medicaid.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Medicaid.Core.Master
{
    [Table("PatientMaster")]
    public class PatientMaster :Base<int>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string BloodPresure { get; set; }
        public string EmergencyContactNumber { get; set; }
        public string Address { get; set; }
        public string BloodGroup { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
    }
}
