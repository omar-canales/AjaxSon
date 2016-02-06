using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jorsh.AjaxSon.Business.Entity
{
    public class EntTableroGestionQueja
    {
        public int BitaEtapaId { get; set; }
        public string Queja { get; set; }
        public string Descripcion { get; set; }
        public string NumServicio { get; set; }
        public string UnidadNegocio { get; set; }
        public int Sistema { get; set; }
        public string ClienteNombre { get; set; }
        public int Cliente { get; set; }
        public string NombServicio { get; set; }
        public DateTime FechaAlta { get; set; }
        public string fAlta { get; set; }
        public int EjecAsigId { get; set; }
        public string EjecAsigNomb { get; set; }
        public DateTime FechaAsigResp { get; set; }
        public DateTime FechaRecaInfo { get; set; }
        public DateTime FechaContResp { get; set; }
        public DateTime FechaSolu { get; set; }
        public DateTime FechaContSolu { get; set; }
        public string FechaSeguiServ { get; set; }
        public string fAsigResp { get; set; }
        public string fContResp { get; set; }
        public string fRecaInfo { get; set; }
        public string fSolu { get; set; }
        public string fContSolu { get; set; }
        public string fSeguiServ { get; set; }
        public string NombreEjecutivoSAC { get; set; }
        public DateTime FechaCierre { get; set; }
        public string fCierre { get; set; }
        public string AccionSiguiente { get; set; }
        public int CausaId { get; set; }
        public int QuejaId { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public int EjecSAC { get; set; }
        public int Etapa { get; set; }
        public bool Definicion { get; set; }
        public int Estado { get; set; }
        public int Municipio { get; set; }
        public int TipoServicio { get; set; }
    }
}
