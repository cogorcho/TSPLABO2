using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Consultorio2013
{
    class Configuracion
    {
		string archivocfg = "consultorio.cfg";
		string fecha = "";
		static string directorio = "";
		string[] archivos = {};
		static string dirPacientes;
		static string dirBackup;
		static string dirLog;
		static string dirTurnos;
		static string dirImagenes;
		static string dirReportes;
		static string dirHC;

		public Configuracion()
		{
			if (File.Exists(archivocfg)) {
				leerConfiguracion();
			}
			else {
				crearConfiguracion();
                leerConfiguracion();
			}
		}
		
		void leerConfiguracion() {
			string[] lineas = File.ReadAllLines(archivocfg);
			foreach ( string linea in lineas ) {
				int indx = linea.IndexOf(":");
				string marca = linea.Substring(0,indx);
				switch (marca) {
					case "Fecha" : { fecha = linea.Substring(indx+1); break;}
					case "ArchivoCfg" : { archivocfg = linea.Substring(indx+1); break;}
					case "Directorio" : { directorio = linea.Substring(indx+1); break;}
					case "Pacientes" : { dirPacientes = linea.Substring(indx+1); break;}
					case "Log" : { dirLog = linea.Substring(indx+1); break;}
					case "Turnos" : { dirTurnos = linea.Substring(indx+1); break;}
					case "Backup" : { dirBackup = linea.Substring(indx+1); break;}
					case "Imagenes" : { dirImagenes = linea.Substring(indx+1); break;}
					case "Reportes" : { dirReportes = linea.Substring(indx+1); break;}
					case "HC" : { dirHC = linea.Substring(indx+1); break;}
				}
			}
			archivos = Directory.GetFiles(directorio);
		}
		
		public string getFecha() { return fecha; }
		public string getArchivocfg() { return archivocfg; }
		public static string getDirectorio() { return directorio; }
		public static string getDirectorioPacientes() { return dirPacientes; }
		public static string getDirectorioLog() { return dirLog; }
		public static string getDirectorioBackup() { return dirBackup; }
		public static string getDirectorioTurnos() { return dirTurnos; }
		public static string getDirectorioImagenes() { return dirImagenes; }
		public static string getDirectorioReportes() { return dirReportes; }
		public static string getDirectorioHC() { return dirHC; }
		public string[] getArchivos() { return archivos; }
		
		void crearConfiguracion() {
			string[] lineas = { "Fecha:" + DateTime.Now, "ArchivoCfg:"+archivocfg };
			File.WriteAllLines(archivocfg, lineas);
			crearDirectorio();
		}
		
		void crearDirectorio() {
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.Description = "Creaci�n del directorio para archivos";
			DialogResult result = fbd.ShowDialog();
			directorio = fbd.SelectedPath + "\\" + "Consultorio";
			string maslineas =  "Directorio:" + directorio + Environment.NewLine +
									"Pacientes:" + directorio + "\\Pacientes" + Environment.NewLine +
									"Log:"  + directorio + "\\Log" +Environment.NewLine +
									"Turnos:" + directorio + "\\Turnos" + Environment.NewLine +
									"Backup:" + directorio + "\\Backup" + Environment.NewLine +
									"Imagenes:" + directorio + "\\Imagenes" + Environment.NewLine +
									"HC:" + directorio + "\\HC" + Environment.NewLine +
									"Reportes:" + directorio + "\\Reportes";
			File.AppendAllText(archivocfg, maslineas);
			crearSubDirectorios(directorio);
		}
		
		void crearSubDirectorios(String dir) {
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);
			if (!Directory.Exists(dir + "\\Pacientes"))
				Directory.CreateDirectory(dir + "\\Pacientes");
			if (!Directory.Exists(dir + "\\Backup"))
				Directory.CreateDirectory(dir + "\\Backup");
			if (!Directory.Exists(dir + "\\Log"))
				Directory.CreateDirectory(dir + "\\Log");
			if (!Directory.Exists(dir + "\\Turnos"))
				Directory.CreateDirectory(dir + "\\Turnos");
			if (!Directory.Exists(dir + "\\Imagenes"))
				Directory.CreateDirectory(dir + "\\Imagenes");
			if (!Directory.Exists(dir + "\\Reportes"))
				Directory.CreateDirectory(dir + "\\Reportes");
			if (!Directory.Exists(dir + "\\HC"))
				Directory.CreateDirectory(dir + "\\HC");
		}
    }
}
