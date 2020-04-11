using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UTECProject.Models
{
    public class CrearUsuarioViewModel
    {
        [Required(ErrorMessage = "Este campo es requerido, por favor ingrese un nombre de usuario")]
        public String Usuario { get; set; }

        [Required(ErrorMessage = "Este campo es requerido, por favor ingrese un correo")]
        public String correo { get; set; }

        [Required(ErrorMessage = "Este campo es requerido, por favor ingrese una contraseña")]
        public String contraseña { get; set; }

        [Required(ErrorMessage = "Este campo es requerido, por favor seleccione un tipo")]
        public int tipo { get; set; }

    }
}