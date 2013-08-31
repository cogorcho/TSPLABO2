using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Consultorio2013
{
    class Log
    {
        public Log() { }
        public static void grabar(string s)
        {
            DateTime fecha = DateTime.Now;
            string format = "yyyyMMdd";
            string logfile = Configuracion.getDirectorioLog() + "\\" + fecha.ToString(format) + ".log";
            try
            {
                if (!File.Exists(logfile))
                {
                    //File.Create(logfile);
                    File.AppendAllText(logfile, DateTime.Now + ": Log iniciado" + Environment.NewLine);
                }
                else
                {

                    File.AppendAllText(logfile, DateTime.Now + ":" + s + Environment.NewLine);
                }
            }
            catch (IOException ioe)
            {
                MessageBox.Show("Log: " + ioe.Message + "(" + s + ")");
            }
        }
    }
}
