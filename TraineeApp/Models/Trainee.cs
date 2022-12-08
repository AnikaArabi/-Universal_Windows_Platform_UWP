using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeApp.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Round { get; set; }
        public string Course { get; set; }
        public string BatchID { get; set; }
        public string Gender { get; set; }
        public DateTime ClassStartDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool isContinuing { get; set; } = false;
        public string Picture { get; set; }
        public string StartDate { get => this.ClassStartDate.ToString("yyyy-MMM-dd"); }
    }
}
