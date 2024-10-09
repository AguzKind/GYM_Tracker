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
            int idx = 0;
            string[] paths = new string[lbx_imagenes.Items.Count];
            AgregarEnBD("INSERT INTO Dias VALUES ('" + dtp_agregar.Text + "', '" + txt_peso.Text + "')");
            LeerEnBD("SELECT TOP 1 DiaID FROM Dias ORDER BY DiaID DESC");
            // Falta buscar el DiaID para relacionarlo con las imagenes
            // Ver funcion LeerEnBD
            for (int i=0; i <= lbx_imagenes.Items.Count - 1; i++)
            {
                paths[i] = lbx_imagenes.Items[i].ToString();
                AgregarEnBD("INSERT INTO Imagenes (ImgPath, DiaID) VALUES ('" + paths[i] + "', '" + idx + "')");

            }
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

        public int LeerEnBD(string query)
        {
            int index = 0;
            SqlConnection conexion = new SqlConnection(stringConexion);
            try
            {
                conexion.Open();
                SqlCommand Accion = new SqlCommand(query, conexion);
                SqlDataReader lector = Accion.ExecuteReader();
                while (lector.Read())
                {
                    index = Convert.ToInt16(lector["DiaID"].ToString());
                }
                conexion.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return index;
        }
    }
}
