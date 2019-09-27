using eDrago.Resources;
using System;
using System.ComponentModel.DataAnnotations;

namespace eDrago.DTO
{
    public class DetalleMovimientoDTO
    {
        [Display(ResourceType = typeof(Global), Name = "NumeroOperacion")]
        public int oper_numero { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Sector")]
        public string sect_codigo { get; set; }

        [Display(ResourceType = typeof(Global), Name = "FechaOrigen")]
        public DateTime oper_forigen { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Usuario")]
        public string usua_codigo { get; set; }

        [Display(ResourceType = typeof(Global), Name = "FechaAlta")]
        public DateTime oper_falta { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Estado")]
        public string esto_codigo { get; set; }

        [Display(ResourceType = typeof(Global), Name = "TipoOperacion")]
        public string tope_codigo { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Cliente")]
        public string clie_alias { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Especie")]
        public string espe_codigo { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Mercado")]
        public string merc_codigo { get; set; }

        [Display(ResourceType = typeof(Global), Name = "NumeroOperacion")]
        public int oper_nrobol { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Monto")]
        public decimal oper_monto { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Precio")]
        public double oper_precio { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Pase")]
        public double oper_pase { get; set; }

        [Display(ResourceType = typeof(Global), Name = "FechaVencimiento")]
        public DateTime oper_fvence { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Comision")]
        public Single cdor_comision { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Observaciones")]
        public string oper_observ { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Supervisor")]
        public string usua_super { get; set; }

        [Display(ResourceType = typeof(Global), Name = "FechaSupervision")]
        public DateTime? fecha_superv { get; set; }

        [Display(ResourceType = typeof(Global), Name = "UsuarioAlta")]
        public string usua_alta { get; set; }

        [Display(ResourceType = typeof(Global), Name = "FechaAlta")]
        public DateTime oper_faltaa { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Secuencia")]
        public int secuencia { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Corredor")]
        public string cdor_nombre { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Codigo")]
        public string cdor_codigo { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Corresponsal")]
        public string corr_nombre { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Monto")]
        public decimal? oper_mont_neg { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Operador")]
        public string operador { get; set; }

        [Display(ResourceType = typeof(Global), Name = "MargenOperador")]
        public double? margen_ope { get; set; }

        [Display(ResourceType = typeof(Global), Name = "Concepto")]
        public string cpto_codigo { get; set; }

        [Display(ResourceType = typeof(Global), Name = "ResponsableComercial")]
        public string resp_comercial { get; set; }

        [Display(ResourceType = typeof(Global), Name = "ResponsableInversion")]
        public string resp_inversion { get; set; }

        [Display(ResourceType = typeof(Global), Name = "IdSideba")]
        public int? oper_nro_sideba { get; set; }

        [Display(ResourceType = typeof(Global), Name = "SuperaLimiteEfectivo")]
        public string oper_supera_limite_efectivo { get; set; }

        [Display(Name = "Cuenta Comitente")]
        public string cuenta_comitente { get; set; }

        [Display(Name = "Monto Inversión")]
        public double? monto_inversion { get; set; }

        [Display(Name = "Forma de Liquidación")]
        public string forma_liquidacion { get; set; }
    }
}
