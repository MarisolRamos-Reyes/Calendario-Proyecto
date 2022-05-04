using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Calendario_Proyecto
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            var skingmanager = MaterialSkinManager.Instance;
            skingmanager.AddFormToManage(this);
            skingmanager.Theme = MaterialSkinManager.Themes.DARK;
            skingmanager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue700, Primary.Blue700,
                Accent.Blue400, TextShade.WHITE);
            //Labelfecha.Text = DateTime.Now.ToLongDateString();
            //labelhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "Director" && this.textcontraseña.Text == "123456789" || this.comboBox1.Text == "Personal Academico" && this.textcontraseña.Text == "123"
                || this.comboBox1.Text == "Personal de Planeación" && this.textcontraseña.Text == "456" || this.comboBox1.Text == "Personal Financiero" && this.textcontraseña.Text == "789")
            {
                Form Formulario = new Calendario();
                Formulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Revise su contraseña, debe de estar mal escrita", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        
    }
}
