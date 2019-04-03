using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HTMLhelpers.Models
{
    public class Formulario
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public String cedula { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public String nombre { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public String apellido { get; set; }

        [Range(15,100,ErrorMessage ="Debes ser mayor de 15 años")]
        [Required(ErrorMessage = "Campo Requerido")]
        public int edad { get; set; }

        [MinLength(10)]
        public String telefono { get; set; }

        [EmailAddress(ErrorMessage ="Correo no encontrado")]
        [RegularExpression("^[_A-Za-z'`+-.]+([_A-Za-z0-9'+-.]+)*@([A-Za-z0-9-])+(\\.[A-Za-z0-9]+)*(\\.([A-Za-z]*){3,})$", ErrorMessage = "Formato incorrecto")]
        [Required(ErrorMessage ="El correo es requerido")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Formato Incorrecto")]
        public String Correo { get; set; }

        public String genero { get; set; }

        public String estado { get; set; }

        //public string[] hobbies { get; set; }

        public bool hobby1 { get; set; }
        public bool hobby2 { get; set; }
        public bool hobby3 { get; set; }
        public bool hobby4 { get; set; }


        public generos GenerosPersonas { get; set; }

    }

    public enum generos
    {
        Masculino,
        Femenino,
        Otro
    }
}