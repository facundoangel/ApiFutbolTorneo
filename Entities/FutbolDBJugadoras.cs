using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ApiFutbolTorneo.Entities
{
    //AGREGO LA PROPIEDAD DE CAMPO UNICO A EL DNI DE LA TABLA DE JUGADORAS

    [Index(nameof(dni), IsUnique = true)]
    public class FutbolDBJugadoras
    {
      
        [Key]
        public int id { get; set; }
        [RegularExpression("^[1-9]{1}[0-9]{7}$",
            ErrorMessage = "Ingresar DNI sin puntos")]
        public int dni { get; set; }
        [RegularExpression("^[a-zA-Z]{1,25}$",
           ErrorMessage = "Solo se permiten letras en este campo y debe contener entre 1 y 25 caracteres sin espacios")]
        public string nombre { get; set; }
        [RegularExpression("^[a-zA-Z]{1,25}$",
           ErrorMessage = "Solo se permiten letras en este campo y debe contener entre 1 y 25 caracteres sin espacios")]
        public string apellido { get; set; }
        [RegularExpression("^[a-zA-Z ]{1,25}$",
           ErrorMessage = "Solo se permiten letras en este campo y debe contener entre 1 y 25 caracteres")]
        public string equipojugando { get; set; }

    }
}
