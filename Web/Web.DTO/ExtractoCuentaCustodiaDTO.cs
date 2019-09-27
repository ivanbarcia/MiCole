using System;

namespace eDrago.DTO
{
    public class ExtractoCuentaCustodiaDTO
    {
        public int? ccm_id { get; set; }
        public DateTime? ccm_fvalor { get; set; }
        public string espe_codigo { get; set; }
        public int? concc_id { get; set; }
        public string concc_descrip { get; set; }
        public string ccm_tipomov { get; set; }
        public decimal? ccm_monto { get; set; }
        public DateTime? ccm_falta { get; set; }
        public decimal? saldo_parcial { get; set; }
        public decimal? precio_val { get; set; }
        public int? ccus_id { get; set; }
        public int? ccus_numero { get; set; }
        public DateTime? fecha_precios { get; set; }
        public int? oper_numero { get; set; }
        public string titular { get; set; }
        public string ccus_numero_tit { get; set; }
        public int? concc_esbloqueo { get; set; }
        public string espe_descrip { get; set; }
        public string codigo_cv { get; set; }
        public string codigo_ISIN { get; set; }
        public string codigo_bolsa { get; set; }
        public decimal? PPCpa { get; set; }
        public decimal? PPVta { get; set; }
        public decimal? Rendimiento { get; set; }
        public decimal? oper_monto { get; set; }
        public decimal? saldo_disponible { get; set; }
        public decimal? saldo_bloqueado { get; set; }
        public decimal? Saldo_total { get; set; }
        public string descripcion_bloqueos { get; set; }
        public decimal? saldo_inmovilizado { get; set; }
        public decimal? saldo_bloqueado_interno { get; set; }
        public decimal? saldo_bloqueado_externo { get; set; }
        public string ccm_monto_string { get; set; }
        public string saldo_parcial_string { get; set; }

    }
}
