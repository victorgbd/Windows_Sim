using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Sim
{
    public class DataCPUProcesos
    {
        public string NombreProceso { get; set; }
        public string PorcentajeCPU { get; set; }

        public DataCPUProcesos(string nombreProceso, string porcentajeCPU)
        {
            NombreProceso = nombreProceso;
            PorcentajeCPU = porcentajeCPU;
        }
    }
}
