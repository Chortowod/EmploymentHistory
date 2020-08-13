using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Book
{
    public class PersonDat
    {
        public string SurName { get; set; }
        public string Name { get; set; }
        public string Otch { get; set; }
        public DateTime Bday { get; set; }
        public string Educ { get; set; }
        public string Prof { get; set; }
        public DateTime RegDate { get; set; }
        public Guid PersNumb { get; set; }
    }

    public class WorkDat
    {
        public string WorkPlaceNumb { get; set; }
        public DateTime WorkDateIn { get; set; }
        public string WorkPlace { get; set; }
        public string WorkStatus { get; set; }
        public string WorkInDocument { get; set; }
        public string WorkAddInfo { get; set; }
        public DateTime WorkDateOut { get; set; }
        public string WorkOutReason { get; set; }
        public string WorkOutDocument { get; set; }
        public Guid WorkWorkerID { get; set; }
    }
}
