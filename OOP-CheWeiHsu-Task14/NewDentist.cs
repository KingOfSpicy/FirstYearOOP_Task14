using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OOP_CheWeiHsu_Task14
{
    class NewDentist
    {
        public NewDentist(int id, string name, string telNum)
        {
            Id = id;
            Name = name;
            TelNum = telNum;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string TelNum { get; set; }

        public GetAllDentists()
        {

        }
    }
}
