using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UTECProject.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Este Campo es Requerido, Por Favor Ingrese un Nombre de usuario")]
        public String Ususario { get; set; }

        [Required(ErrorMessage = "El Campo Contraseña No Puede estar Vacio")]
        [PasswordPropertyText]
        public String Contraseña { get; set; }

    }
}