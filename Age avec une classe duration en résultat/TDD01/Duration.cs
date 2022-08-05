using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD01
{
    public class Duration
    {
        //readonly rend la variable imuable
        public readonly int NombreYears;
        public readonly int NombreMonths;
        public readonly int NombreDays;


        //création de constructeur
        public Duration(int pYears, int pMonths, int pDays)
        {
            
            NombreYears = pYears;
            NombreMonths = pMonths;
            NombreDays = pDays;
        }
    }
}
