using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazInteresesMensualHouston.Helpers
{
    public class Miscelanea
    {
        const string APPLICATION = "CargaEnvioA";

        const int REG_SZ = 1;
        const int REG_BINARY = 3;
        const UInt32 HKEY_CURRENT_USER = 0x80000001;

        public const UInt32 WM_CLOSE = 0x10;
        public const UInt32 WM_DESTROY = 0x2;

        public string watchApp;
        public string watchAppPath;
        public string diasDeActividad;
        public string diasFeriados;
        public DateTime horaDesde;
        public DateTime horaHasta;
        public int frecuencia;
        public string reset;
        public string FechaProceso;
        public DateTime DiaProceso;
        public string DiaProcesocomillas;
        public string RutaServidor;
        public string RutaKYC;
        public string RutaArch;
        public string RutaTransfer;
        public string RutaTransfer2;
        public string Logs;
        public double varshell;


        public string sUltimaAccion;
        public string sDia;
        public int TiempoBusqueda;
        public string strgFechaUltAccion;
        public string INI_PATH;
        //Public lib As New Libreria
        public string inicioproceso;
        public string sHoraFin;
        public string mensaje;
        public string sFhProcUltima;
        public string sFhProcDia;
        public string sHoraRes;


        public void UltimaBusqueda()
        {
            sUltimaAccion = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        public void TimeDelay(int segundos)
        {
            Thread.Sleep(segundos * 1000);
        }


        public void StartModTray(Form form, long frmicon, bool modifyTray = true, string titleBall = "", string message_ball = "", long icon_ball = 0)
        {

        }


        public void EndTray()
        {

        }

        public void Message(string texto)
        {
            
        }

    }
}
