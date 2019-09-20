using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace eDrago.DAL.Models
{
    [Table("especies")]
    public class Especie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string espe_codigo { get; set; }

        [Display(Name = "Usuario Ata")]
        public string usua_alta { get; set; }

        [Display(Name = "Fecha Alta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime espe_falta { get; set; }

        [Display(Name = "Usuario Modificación")]
        public string usua_modif { get; set; }

        [Display(Name = "Fecha Modificación")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? espe_fmodif { get; set; }

        [Display(Name = "Descripción")]
        public string espe_descrip { get; set; }

        [Display(Name = "Tipo de Especie")]
        public string tespe_codigo { get; set; }

        [Display(Name = "Símbolo")]
        public string espe_simbolo { get; set; }

        [Display(Name = "Divpase")]
        public bool espe_divpase { get; set; }

        [Display(Name = "Codcot")]
        public string espe_codcot { get; set; }

        [Display(Name = "merc_codcot")]
        public string merc_codcot { get; set; }

        [Display(Name = "Cotiza Por")]
        public int espe_cotizapor { get; set; }

        [Display(Name = "Valor Nominal")]
        public decimal espe_valornom { get; set; }

        [Display(Name = "Código Madre")]
        public string espe_codmadre { get; set; }

        [Display(Name = "Cupones")]
        public int espe_cupones { get; set; }

        [Display(Name = "gesp_codigo")]
        public string gesp_codigo { get; set; }

        [Display(Name = "intcorridos")]
        public bool espe_intcorridos { get; set; }

        [Display(Name = "Precio Base")]
        public bool espe_precbase { get; set; }

        [Display(Name = "Emisión")]
        public decimal espe_emision { get; set; }

        [Display(Name = "maxposic")]
        public decimal espe_maxposic { get; set; }

        [Display(Name = "Vence")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? espe_vence { get; set; }

        [Display(Name = "Especie Activa")]
        public int espe_activa { get; set; }

        [Display(Name = "jfon_id")]
        public int jfon_id { get; set; }

        [Display(Name = "espe_min_oper")]
        public decimal espe_min_oper { get; set; }

        [Display(Name = "espe_nro_inscrip")]
        public string espe_nro_inscrip { get; set; }

        [Display(Name = "espe_fform")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? espe_fform { get; set; }

        [Display(Name = "espe_spread")]
        public float espe_spread { get; set; }

        [Display(Name = "espe_nivelbcra1")]
        public string espe_nivelbcra1 { get; set; }

        [Display(Name = "espe_nivelbcra2")]
        public string espe_nivelbcra2 { get; set; }

        [Display(Name = "espe_nivelbcra3")]
        public string espe_nivelbcra3 { get; set; }

        [Display(Name = "espe_nivelbcra4")]
        public string espe_nivelbcra4 { get; set; }

        [Display(Name = "espe_nivelbcra5")]
        public string espe_nivelbcra5 { get; set; }

        [Display(Name = "espe_nivelbcra6")]
        public string espe_nivelbcra6 { get; set; }

        [Display(Name = "espe_nivelbcra7")]
        public string espe_nivelbcra7 { get; set; }

        [Display(Name = "espe_operasuc")]
        public int espe_operasuc { get; set; }

        [Display(Name = "espe_rtafija")]
        public int espe_rtafija { get; set; }

        [Display(Name = "espe_rtavariable")]
        public int espe_rtavariable { get; set; }

        [Display(Name = "espe_calcula_tir")]
        public int espe_calcula_tir { get; set; }
    }
}
