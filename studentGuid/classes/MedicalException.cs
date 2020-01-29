using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentGuid.classes
{
    class MedicalException : Exception
    {
        public MedicalException() : base("Not Valid")
        {

        }

    }
}
