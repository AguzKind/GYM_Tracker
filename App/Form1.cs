using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App
{
    public partial class FormPrincipal : Form
    {
        public bool estadoBotones = true;
        public string nombreImagenes = "";
        string stringConexion = "Data Source=AGUZKIND;Initial Catalog=GYM_Tracker;Integrated Security=True";
        public FormPrincipal()
        {
            InitializeComponent();
            dtp_agregar.Format = DateTimePickerFormat.Custom;
            dtp_agregar.CustomFormat = "yyyy/MM/dd";
        }
        private void CambiarVisibilidadBotones()
        {

            if (estadoBotones == true)
            {
                estadoBotones = !estadoBotones;
                btn_AgregarProgreso.Visible = !estadoBotones;
                btn_VerProgreso.Visible = !estadoBotones;
                pnl_Info.Visible = estadoBotones;
            }
            else
            {
                estadoBotones = !estadoBotones;
                btn_AgregarProgreso.Visible = !estadoBotones;
                btn_VerProgreso.Visible = !estadoBotones;
                pnl_Info.Visible = estadoBotones;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CambiarVisibilidadBotones();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            CambiarVisibilidadBotones();
        }

        private void btn_VerProgreso_Click(object sender, EventArgs e)
        {

        }

        private void btn_AgregarImagen_Click(object sender, EventArgs e)
        {
            // Función para agregar imagenes.
            OpenFileDialog odf = new OpenFileDialog();
            odf.Multiselect = true;
            if (odf.ShowDialog() == DialogResult.OK)
            {
                string[] archivosSeleccionados = odf.FileNames;
                nombreImagenes = string.Join(", ", archivosSeleccionados);
                // foreach para agregar los paths a la listbox.
                foreach (string str in archivosSeleccionados) {
                    lbx_imagenes.Items.Add(str.ToString());
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtp_agregar_ValueChanged(object sender, EventArgs e)
        {
            dtp_agregar.Format = DateTimePickerFormat.Custom;
            dtp_agregar.CustomFormat = "yyyy/MM/dd";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Menu_Click_1(object sender, EventArgs e)
        {
            CambiarVisibilidadBotones();
        }

        private void lbx_imagenes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cambia el path de la imagen cuando el usuario hace click en un item
            // de la listbox.
            pbx_imagen.ImageLocation = lbx_imagenes.Items[lbx_imagenes.SelectedIndex].ToString();
        }

        private void btn_subirContenido_Click(object sender, EventArgs e)
        {
            AgregarEnBD("INSERT INTO Dias VALUES ('" + dtp_agregar.Text + "', '" + txt_peso.Text + "')");
            // Falta agregar las imagenes y linkearlas al dia en la tabla intermedia.
        }
        public void AgregarEnBD(string query)
        {
            SqlConnection conexion = new SqlConnection(stringConexion);
            try
            {
                conexion.Open();
                SqlCommand Accion = new SqlCommand(query, conexion);
                Accion.ExecuteNonQuery();
                MessageBox.Show("Datos guardados correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
