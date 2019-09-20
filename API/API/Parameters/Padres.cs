using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Padres : AuditableEntity
    {
        /// <summary>
        /// Cuit del Cliente
        /// </summary>
        /// <example>20312981883</example>
        [Required]
        public int AlumnoId { get; set; }

        /// <summary>
        /// Cuit del Cliente
        /// </summary>
        /// <example>20312981883</example>
        [Required]
        public string Nombre1 { get; set; }

        /// <summary>
        /// Cuit del Cliente
        /// </summary>
        /// <example>20312981883</example>
        [Required]
        public string Apellido1 { get; set; }

        /// <summary>
        /// Cuit del Cliente
        /// </summary>
        /// <example>20312981883</example>
        [Required]
        public string Documento1 { get; set; }

        /// <summary>
        /// Cuit del Cliente
        /// </summary>
        /// <example>20312981883</example>
        [Required]
        public string Telefono1 { get; set; }

        /// <summary>
        /// Cuit del Cliente
        /// </summary>
        /// <example>20312981883</example>
        [Required]
        public string Nombre2 { get; set; }

        /// <summary>
        /// Cuit del Cliente
        /// </summary>
        /// <example>20312981883</example>
        [Required]
        public string Apellido2 { get; set; }

        /// <summary>
        /// Cuit del Cliente
        /// </summary>
        /// <example>20312981883</example>
        [Required]
        public string Documento2 { get; set; }

        /// <summary>
        /// Cuit del Cliente
        /// </summary>
        /// <example>20312981883</example>
        [Required]
        public string Telefono2 { get; set; }

        public virtual Alumno Alumno { get; set; }
    }
}
