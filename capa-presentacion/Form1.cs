using capa_entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_negocio;
   
namespace capa_presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarbtn_Click(object sender, EventArgs e)
        {
            Empleados emp = new Empleados()
            {
                Id = IDtxt.Text,
                Nombre = Nombretxt.Text,
                Apellidos = Apellidotxt.Text,
                Direccion = Direcciontxt.Text,
                Telefono = telefonotxt.Text,
                Email = Emailtxt.Text,
                Cargo = Cargotxt.Text,
                Salario = decimal.Parse(salariotxt.Text),
                FechaIngreso = fechadtp.Value,
                Genero = generocmb.Text
            };

            EmpleadosNegocio negocio = new EmpleadosNegocio();

            if (!negocio.ValidarEmpleado(emp))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivos de texto (*.txt)|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                negocio.Guardar(save.FileName, emp);
                MessageBox.Show("Archivo guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void abrirbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos de texto (*.txt)|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(open.FileName);
            }
        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?",
      "Confirmar",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generocmb.Items.Add("Masculino");
            generocmb.Items.Add("Femenino");
            generocmb.Items.Add("Otro");
        }

        private void Nombretxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void generocmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            generocmb.Items.Add("Masculino"); 
            generocmb.Items.Add("Femenino"); 
            generocmb.Items.Add("Otro");
        }

        private void Direcciontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void diclbl_Click(object sender, EventArgs e)
        {

        }

        private void Salalbl_Click(object sender, EventArgs e)
        {

        }

        private void cargolbl_Click(object sender, EventArgs e)
        {

        }

        private void emalbl_Click(object sender, EventArgs e)
        {

        }

        private void telelbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idlbl_Click(object sender, EventArgs e)
        {

        }

        private void fechadtp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void telefonotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void salariotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void apelbl_Click(object sender, EventArgs e)
        {

        }

        private void Cargotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apellidotxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
