using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorialConsole
{
    public class Grade
    {
        public Grade() { 
                Student = new List<Student>();
        }

        public string GradeId { get; set; }
        public string GradeName { get; set; } = string.Empty;
        public IList<Student> Student { get; set; }
    }
}
