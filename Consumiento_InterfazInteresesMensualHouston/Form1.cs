using InterfazInteresesMensualHouston.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consumiento_InterfazInteresesMensualHouston
{
    public partial class Form1 : Form
    {
        Libreria libreria;
        Miscelanea miscelanea;
        public Form1()
        {
            InitializeComponent();

            libreria = new Libreria();
            miscelanea = new Miscelanea();

        }

        public void CargaEnvio()
        {
            string tmp = Command.Text.Trim().Replace("\\", "/").Replace("-", "/") + "";
            try
            {
                //string[] args = Environment.GetCommandLineArgs();
                if(tmp != String.Empty)
                {
                    if(tmp.Contains("/"))
                    {
                        miscelanea.DiaProceso = DateTime.Parse(tmp);
                        miscelanea.FechaProceso = Funcion.Mid(miscelanea.DiaProceso.ToString(), 7, 4) + Funcion.Mid(miscelanea.DiaProceso.ToString(), 4, 2) + Funcion.Mid(miscelanea.DiaProceso.ToString(), 1, 2);
                    }
                    else
                    {
                        Command.Text = $"No se puede procesar la solicitud con los parametros introducidos ({tmp})";
                    }
                }

                //diames = Format(Now, "ddmmyyyy", vbMonday)
                //DiaDeLaSemana = Trim$((Weekday(Now, vbMonday)))

                //n = InStr(diasCierre, diames)
                //m = InStr(diasDeActividad, DiaDeLaSemana)


                if(ValidaFecha() == false)
                {
                    Command.Text = "La fecha actual no es una fecha valida para procesar la informacion, aplicacion terminada.";
                }

                bool ok4;
                string app001 = "";

                app001 = miscelanea.RutaTransfer2 + "\\" + "app001.ini";

                string e;
                string fech;

                FechaAnterior();



            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tmrTiempo.Enabled = false;
                miscelanea.INI_PATH = System.Reflection.Assembly.GetEntryAssembly().Location;
                char comillas = (char)34;
                miscelanea.watchApp = Funcion.getValueAppConfig("watchApp", "CargaEnvioA");
                miscelanea.watchAppPath = Funcion.getValueAppConfig("watchAppPath", "CargaEnvioA");
                miscelanea.diasDeActividad = Funcion.getValueAppConfig("diasDeActividad", "CargaEnvioA");
                miscelanea.diasInhabiles = Funcion.getValueAppConfig("diasCierre", "CargaEnvioA");
                miscelanea.horaDesde = TimeSpan.Parse(Funcion.getValueAppConfig("horaDesde", "CargaEnvioA"));
                miscelanea.horaHasta = TimeSpan.Parse(Funcion.getValueAppConfig("horaHasta", "CargaEnvioA"));
                miscelanea.reset = Funcion.getValueAppConfig("RESET", "CargaEnvioA");
                miscelanea.DiaProceso = DateTime.Parse(Funcion.getValueAppConfig("DiaProceso", "CargaEnvioA"));
                miscelanea.DiaProcesocomillas = miscelanea.DiaProceso.ToString("dd-MM-yyyy");
                miscelanea.RutaServidor = Funcion.getValueAppConfig("RutaServer", "CargaEnvioA");
                miscelanea.RutaArch = Funcion.getValueAppConfig("Repositorio", "CargaEnvioA");
                miscelanea.RutaTransfer = Funcion.getValueAppConfig("RutaTransfer", "CargaEnvioA");
                miscelanea.RutaTransfer2 = Funcion.getValueAppConfig("RutaTransfer2", "CargaEnvioA");
                miscelanea.Logs = Funcion.getValueAppConfig("Logs", "CargaEnvioA");

                miscelanea.sUltimaAccion = "0";
                miscelanea.sHoraFin = miscelanea.horaHasta.ToString();
                miscelanea.sDia = DateTime.Now.ToString("dddd");

                miscelanea.inicioproceso = DateTime.Now.ToString("hh:mm:ss");
                miscelanea.strgFechaUltAccion = DateTime.Now.ToString("hh:mm:ss");
                string fecha_tmp = miscelanea.DiaProceso.ToString("dd-MM-yyyy");
                miscelanea.FechaProceso = Funcion.Mid(fecha_tmp, 7, 4) + Funcion.Mid(fecha_tmp, 4, 2) + Funcion.Mid(fecha_tmp, 1, 2);

                if (!libreria.ValidarDirectorio(miscelanea.RutaArch))
                {
                    libreria.CrearFolder(miscelanea.RutaArch);
                }

                CargaEnvio();

            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
            }
        }

        public bool ValidaFecha()
        {
            try
            {
                if (DateTime.Now.ToString("dd/MM/yyyy") == miscelanea.DiaProceso.ToString("dd/MM/yyyy"))
                {


                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
                return false;
            }
        }

        public string FechaAnterior()
        {
            try
            {
                int mes, year;
                string month, ano;

                mes = Int32.Parse(miscelanea.DiaProceso.ToString("MM"));
                year = Int32.Parse(miscelanea.DiaProceso.ToString("yyyy"));

                if(mes == 1)
                {
                    ano = (year - 1).ToString();
                    month = "12";
                }
                else
                {
                    ano = year.ToString();
                    month = (mes - 1).ToString(); 
                }

                string fech;
                return fech = new DateTime(Int32.Parse(ano), Int32.Parse(month), Int32.Parse(Funcion.getValueAppConfig("primerdiadelmes", "CargaEnvioA"))).ToString("dd/MM/yyyy");

               
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
                return null;
            }

        }
    }
}
