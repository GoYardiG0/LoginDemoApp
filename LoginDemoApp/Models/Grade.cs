using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDemoApp.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string? Email { get; set; }

        public DateTime? TestDate { get; set; }
        public int? GradeNum { get; set; }
        public string SubjectName { get; set; } = null!;
    }
}
