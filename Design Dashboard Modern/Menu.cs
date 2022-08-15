using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Dashboard_Modern.Producto;
using Design_Dashboard_Modern.Proveedor;

namespace Design_Dashboard_Modern
{
    public partial class Menu : Form
    {
        private Form currentChildForm;
        public Menu()
        {
            InitializeComponent();
        }
        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }
        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }
        private void BtbMenu_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 60)
            {
                panelMenu.Visible = false;
                panelMenu.Width = 226;
                Panelanimator.ShowSync(panelMenu);
                Logoanimator.ShowSync(Logo);
                labelNombreUsuario.Visible = true;
            }
            else
            {
                Logoanimator.Hide(Logo);
                panelMenu.Visible = false;
                panelMenu.Width = 60;
                Panelanimator.ShowSync(panelMenu);
                labelNombreUsuario.Visible = false;
            }
        }
        private void OpenChildFrom(Form Child)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = Child;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(Child);
            Child.BringToFront();
            Child.Show();
        }
        private void ButtonProductos_Click(object sender, EventArgs e)
        {
                OpenChildFrom(new Form_Agregar_Productos());
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        { Frm_Vista_Proveedor vista = new Frm_Vista_Proveedor();
            OpenChildFrom(new Frm_Vista_Proveedor());

            //if(vista.buttonAgregarProveedor_Click().)
        }

       
    }
}
