using MaxiKiosco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaxiKiosco.Data
{
    public class DbInicializador
    {
        public static void Inicializador (MaxiKioscoContext context)
        {
            context.Database.EnsureCreated();


        }
    }
}
