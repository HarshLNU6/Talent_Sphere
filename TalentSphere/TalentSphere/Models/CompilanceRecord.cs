using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TalentSphere.Enums;
 
namespace TalentSphere.Models
{
    public class ComplianceRecord
    {
        public int ComplianceID { get; set; }

        public int EmployeeID { get; set; }

        public CompilanceRecordType Type { get; set; }

        public string Result { get; set; }

        public DateTime Date { get; set; }

        public string Notes { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Employee Employee { get; set; }
    }
}