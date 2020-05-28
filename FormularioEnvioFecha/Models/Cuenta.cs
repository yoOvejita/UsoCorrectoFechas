using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormularioEnvioFecha.Models
{
    public class Cuenta
    {
        public string Id { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreCompleto { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime FechaNacimiento { get; set; }
    }
}