﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazInteresesMensualHouston.Helpers
{
    public class Libreria
    {
        public string PrimerCracter(string texto)
        {
            return Funcion.Mid(texto, 1, 1);
        }

        public long GetFileSize(String archivo)
        {
            try
            {
                FileInfo fi = new FileInfo(archivo);

                return fi.Length;
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
                return -1;
            }
        }

        public void Mensajes()
        {

        }

        public void DecirTexto()
        {
            
        }

        public void ArrayText()
        {

        }

        public void ValSplitText()
        {

        }

        public void Getosver()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void LangOsHex()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void LangOsDec()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public void CheckLan(string ipserver)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void mail()
        {

        }

        public void GetUser()
        {

        }

        public void GetEquipo()
        {

        }

        public void CrearFolder()
        {

        }


        public void ValidarDirectorio()
        {

        }

        public void CrearArchivos(string[] arreglo)
        {

        }

        public void CrearArchivos(string archivo)
        {

        }

        public void CrearArchivoEscribe()
        {
            try
            {

            }
            catch (Exception ex)
            {
                
            }
        }

        public void EscribirArchivo(string[] arreglo, string archivo)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void EscribirLineaArchivo()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public void GetMac()
        {

        }

        public void GetIp()
        {

        }


        public void GetRun()
        {

        }


        public void GetRun2()
        {

        }

        public void Run()
        {

        }

        public void Run2()
        {

        }

        public void RunSinEsperar()
        {

        }

        public void CheckProcess()
        {

        }

        public void chekprocessowner()
        {

        }

    }

  
}