using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace ApiFutbolTorneo.Entities
{
    //AGREGO LA PROPIEDAD DE CAMPO UNICO A EL NOMBRE DE EQUIPO EN LA TABLA

    [Index(nameof(equipo), IsUnique = true)]
    public class FutbolDBEquipos
    {
        //DEFINO CAMPOS Y AGREGO SUS VALIDACIONES
        [Key]
        public int id { get; set; }
        [RegularExpression("^[a-zA-Z]{1,25}$",
            ErrorMessage ="Solo se permiten letras en este campo y debe contener entre 1 y 25 caracteres")]
        public string equipo { get; set; }
        [RegularExpression("^[a-zA-Z]{1,25}$",
            ErrorMessage = "Solo se permiten letras en este campo y debe contener entre 1 y 25 caracteres")]
        public string color { get; set; }
    }
}
