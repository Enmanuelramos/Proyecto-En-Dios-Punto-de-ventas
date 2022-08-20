using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Design_Dashboard_Modern
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textUsuario_Enter(object sender, EventArgs e)
        {
            if (textUsuario.Text == "USURAIO")
            {
                textUsuario.Text = "";
                textUsuario.ForeColor = Color.DimGray;
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (textUsuario.Text == "")
            {
                textUsuario.Text = "USURAIO";
                textUsuario.ForeColor = Color.DimGray;
            }
        }
        private void textPassWord_Enter(object sender, EventArgs e)
        {
            if (textPassWord.Text == "Password")
            {
                textPassWord.Text = "";
                textPassWord.ForeColor = Color.DimGray;
                textPassWord.UseSystemPasswordChar = true;
            }
        }

        private void textPassWord_Leave(object sender, EventArgs e)
        {
            if (textPassWord.Text == "")
            {
                textPassWord.Text = "Password";
                textPassWord.ForeColor = Color.DimGray;
                textPassWord.UseSystemPasswordChar = false;
            }
        }
     
        private void btn_minimi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private bool Validar_Texto()
        {
            Frm_Filtro Fil = new Frm_Filtro();

            if(textUsuario.Text.Length < 2) 
            {
                Fil.Show();
                MessageBox.Show("Ingrese el nombre del usuario", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textUsuario.Focus();
                return false ;
            }
            if (textPassWord.Text.Length < 2)
            {
                Fil.Show();
                MessageBox.Show("Ingrese la contraseña", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textPassWord.Focus();
                return false;
            }
            return true;
        }
        private void Hacer_Login()
        {
            RN_Usuario Usurio = new RN_Usuario();
            DataTable Dato = new DataTable();
            int veces = 0;
            string UsuNom = textUsuario.Text;
            string PasUsu = textPassWord.Text;

            if (Validar_Texto() == false) return; // esta condicion es si la validacion del texto es falsa entonces se sale de la concion 

            if (Usurio.RN_Login(UsuNom, PasUsu) == true)
            {
                Dato = Usurio.RN_BuscarUsuario(UsuNom);

                if (Dato.Rows.Count > 0)
                {
                    DataRow dr = Dato.Rows[0];
                    Cls_Libreria.IdRol = dr["Id_Rol"].ToString();
                    Cls_Libreria.Nombre = dr["Nombres"].ToString();
                    Cls_Libreria.Foto = dr["Ubicacion_Foto"].ToString();
                    Cls_Libreria.Rol = dr["Rol"].ToString();
                    Cls_Libreria.IdUsu = dr["Id_Usu"].ToString();
                }

                this.Hide();
                Menu Principal = new Menu();
                Principal.Show();
            }
            else
            {
                veces = veces + 1;
                textPassWord.Text = "";
                textUsuario.Text = "";
                textUsuario.Focus();

                if (veces == 3)
                {
                    MessageBox.Show("Usted a sobrepasado los intentos ", " Advertencia de Login ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
        }
        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            Hacer_Login();
        }

        private void textUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textUsuario.Focus();
            }
        }

        private void textPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 Btn_Iniciar_Click(sender, e);
            }
        }

    }
 }