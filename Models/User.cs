using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eon_TestAssignment.Models
{
    public class User
    {
        [MaxLength(36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String Id { get; set; }

        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        public string Gender { get; set; }

        public String RegisteredDate { get; set; }

   
        public String SelectedDays { get; set; }

        [MaxLength(100)]
        
        public String AddRequest { get; set; }
    }
}
