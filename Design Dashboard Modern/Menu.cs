using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        private void Menu_Load(object sender, EventArgs e)
        {
            Cargar_Datos_Usuario();
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
                Logoanimator.ShowSync(PicUser);
                NombreUsuario.Visible = true;
            }
            else
            {
                Logoanimator.Hide(PicUser);
                panelMenu.Visible = false;
                panelMenu.Width = 60;
                Panelanimator.ShowSync(panelMenu);
                NombreUsuario.Visible = false;
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
            PanelDesktop.Controls.Add(Child);
            Child.BringToFront();
            Child.Show();
        }
        private void ButtonProductos_Click(object sender, EventArgs e)
        {
                OpenChildFrom(new Frm_Explo_Productos());
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        { 
            OpenChildFrom(new Frm_Vista_Proveedor());
        }
        public void Cargar_Datos_Usuario()
        {
            Frm_Filtro Fill = new Frm_Filtro();

            Fill.Show();
            MessageBox.Show("Bienvenido (a) Sr: " + Cls_Libreria.Nombre, "Inicio de Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Fill.Hide();

            NombreUsuario.Text = Cls_Libreria.Nombre;
            bunifuCustomLabel1.Text = Cls_Libreria.Nombre;
            //lbl_Rol.Text = Cls_Libreria.Rol;

            if (Cls_Libreria.Foto.Trim().Length == 0 | Cls_Libreria.Foto == null) return;

            if (File.Exists(Cls_Libreria.Foto) == true)
            {
                PicUser.Load(Cls_Libreria.Foto);
                //PicUser_2.Load(Cls_Libreria.Foto);
            }
        }
    }
}
