using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class UbicacionPersona:BaseEntity
    {
        public string TipoDeVia { get; set; }
        public int NumeroPri { get; set; }
        public int NumeroSec { get; set; }
        public int NumeoTer { get; set; }
        public string Bis { get; set; }
        public string CardinalPri { get; set; }
        public string CardinalSec { get; set; }
        public string LetraPri { get; set; }
        public string LetraSec { get; set; }
        public string LetraTer { get; set; }
        public string Complemento { get; set; }
        public string IdPersonaFk { get; set; }
        public int IdCiudadFk { get; set; }
        public Ciudad Ciudades { get; set; }
        public Persona Personas { get; set; }
        
    }
}