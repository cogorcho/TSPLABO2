using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Consultorio2013
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            Configuracion CFG = new Configuracion();
            cargarLV();
            txtApellido.Focus();
        }

        void BtnSalirClick(object sender, EventArgs e)
        {
            Application.Exit();
        }


        void BtnGuardarClick(object sender, EventArgs e)
        {
            if (!validarDatos())
                return;
            string sexo;
            if (rbFem.Checked)
                sexo = rbFem.Text;
            else
                sexo = rbMas.Text;
            Persona p = new Persona(txtApellido.Text,
                                    txtNombre.Text,
                                    dtpFNac.Text,
                                    cbxTipoDoc.SelectedItem.ToString(),
                                    txtDocumento.Text,
                                    txtTelefono.Text,
                                    sexo,
                                    txtEmail.Text);
            p.guardar();
            Log.grabar("Nuevo registro: " + txtDocumento.Text);
            clearForm();
            cargarLV();			
        }

        bool validarDatos()
        {
            if (txtApellido.Text.Length == 0)
            {
                MessageBox.Show("Falta el apellido!");
                txtApellido.Focus();
                return false;
            }
            else if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Falta el nombre!");
                txtNombre.Focus();
                return false;
            }
            else if (cbxTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Falta el tipo de documento");
                cbxTipoDoc.Focus();
                return false;
            }
            else if (txtDocumento.Text.Length == 0)
            {
                MessageBox.Show("Falta el documento");
                txtDocumento.Focus();
                return false;
            }
            return true;
        }

        void clearForm()
        {
            txtApellido.Clear();
            txtNombre.Clear();
            dtpFNac.Value = DateTime.Now;
            cbxTipoDoc.SelectedIndex = -1;
            txtDocumento.Clear();
            txtTelefono.Clear();
            rbFem.Checked = false;
            rbMas.Checked = true;
            txtEmail.Clear();
            txtApellido.Focus();
        }

        public void cargarLV()
        {
            string[] files = Directory.GetFiles(Configuracion.getDirectorioPacientes(), "*.dat");
            string nombre, apellido, fechanac, tipodoc, documento, telefono, sexo, email;
            lvDatos.Items.Clear();
            ListViewItem itm = new ListViewItem();
            foreach (string file in files)
            {
                string[] data = File.ReadAllLines(file);
                foreach (string line in data)
                {
                    string campo = line.Substring(0, line.IndexOf(":"));
                    switch (campo)
                    {
                        case "Apellido": { apellido = line.Substring(line.IndexOf(":") + 1); itm = lvDatos.Items.Add(apellido); break; }
                        case "Nombre": { nombre = line.Substring(line.IndexOf(":") + 1); itm.SubItems.Add(nombre); break; }
                        case "Fecha de nacimiento": { fechanac = line.Substring(line.IndexOf(":") + 1); itm.SubItems.Add(fechanac); break; }
                        case "Tipo documento": { tipodoc = line.Substring(line.IndexOf(":") + 1); itm.SubItems.Add(tipodoc); break; }
                        case "Documento": { documento = line.Substring(line.IndexOf(":") + 1); itm.SubItems.Add(documento); break; }
                        case "Teléfono": { telefono = line.Substring(line.IndexOf(":") + 1); itm.SubItems.Add(telefono); break; }
                        case "Sexo": { sexo = line.Substring(line.IndexOf(":") + 1); itm.SubItems.Add(sexo); break; }
                        case "Email": { email = line.Substring(line.IndexOf(":") + 1); itm.SubItems.Add(email); break; }
                    }
                }
            }
        }

        void BtnNuevoClick(object sender, EventArgs e)
        {
            clearForm();
        }

        private void lvDatos_DoubleClick(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            ListViewItem lvItem = lv.FocusedItem;
            txtApellido.Text = lvItem.Text;
            txtNombre.Text = lvItem.SubItems[1].Text;
            dtpFNac.Text = lvItem.SubItems[2].Text;
            cbxTipoDoc.SelectedIndex = cbxTipoDoc.FindStringExact(lvItem.SubItems[3].Text);
            txtDocumento.Text = lvItem.SubItems[4].Text;
            txtTelefono.Text = lvItem.SubItems[5].Text;
            if (lvItem.SubItems[6].Text == "Masculino")
                rbMas.Checked = true;
            else
                rbFem.Checked = true;
            txtEmail.Text = lvItem.SubItems[7].Text;
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                Persona.borrar(txtDocumento.Text);
                Log.grabar("Registro Eliminado: " + txtDocumento.Text);
                cargarLV();
                clearForm();
            }
        }

        private void lnkArchivos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FileDialog fDatos = new OpenFileDialog();
            fDatos.Title = "Selección de archivos de datos";
            fDatos.InitialDirectory = Configuracion.getDirectorio();
            DialogResult result = fDatos.ShowDialog();
            if (result == DialogResult.OK)
            {
                String dir = fDatos.FileName.Substring(0, fDatos.FileName.LastIndexOf("\\"));
                if (dir.Equals(Configuracion.getDirectorioBackup()))
                    System.Diagnostics.Process.Start("winrar.exe", fDatos.FileName);
                else if (dir.Equals(Configuracion.getDirectorioImagenes()))
                    System.Diagnostics.Process.Start("mspaint.exe", fDatos.FileName);
                else
                    System.Diagnostics.Process.Start("notepad.exe", fDatos.FileName);
                cargarLV();
                lvDatos.Refresh();
            }
        }

        //------------------------------------------------------
        // HC
        //------------------------------------------------------
        private void btnHC_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                string sexo = "";
                if (rbFem.Checked)
                    sexo = rbFem.Text;
                else
                    sexo = rbMas.Text;

                HC hc = new HC(txtApellido.Text, txtNombre.Text, cbxTipoDoc.SelectedItem.ToString(), txtDocumento.Text, txtTelefono.Text, sexo, txtEmail.Text);
            }
        }

        private void rtnReporte_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                string sexo = "";
                if (rbFem.Checked)
                    sexo = rbFem.Text;
                else
                    sexo = rbMas.Text;

                Reporte rpt = new Reporte(txtApellido.Text, txtNombre.Text, cbxTipoDoc.SelectedItem.ToString(), txtDocumento.Text, txtTelefono.Text, sexo, txtEmail.Text);
            }
        }

        private void btnImagenes_Click_1(object sender, EventArgs e)
        {
            Imagen im = new Imagen(txtApellido.Text, txtNombre.Text, txtDocumento.Text);
            im.getFiles();
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Log.grabar("Arranca backup");
            Backup.doBackup();
            Log.grabar("Backup terminado");
        }
    }
}