using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalControlGastos
{
    public class Transactions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Coin { get; set; }
        public float Amount { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Method { get; set; }
    }
}

