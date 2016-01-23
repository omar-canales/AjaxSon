using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jorsh.AjaxSon.Business.Entity
{
    public class EntQueja
    {
        public int Id { get; set; }
        public int Anio { get; set; }
        public string Prefijo { get; set; }
        public int Numero { get; set; }
        public string Reporte { get; set; }
        public int ViaActivacionId { get; set; }
        public int ResponsableId { get; set; }
        public string Descripcion { get; set; }
        public bool EstatusSeguimiento { get; set; }
        public int UnidadNegocioId { get; set; }
        public string NumeroServicio { get; set; }
        public int EjecutivoSACId { get; set; }
        public bool Definicion { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Procedente { get; set; }
        public bool EnvioCorreo { get; set; }
        public int UsuarioId { get; set; }
        public int MotivoImprocedenteId { get; set; }
        public int MotivoNoEnviarMail { get; set; }
        public string Cliente { get; set; }
        public int Cliente_ID { get; set; }
        public int Estado_ID { get; set; }
        public int Municipio_ID { get; set; }
        public int TipoServicio_ID { get; set; }
        public string FechaActivacionServ { get; set; }
        public string EstatusServicioServ { get; set; }
    }
}
