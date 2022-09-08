using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Datos;
using Capa_Entidad;
using Capa_Negocio;

namespace Design_Dashboard_Modern.Cliente
{
    public partial class Fmr_Add_Clientes : Form
    {
        public Fmr_Add_Clientes()
        {
            InitializeComponent();
        }
        private void Frm_Reg_Prod_Load(object sender, EventArgs e)
        {  
            textIDCliente.Text = RN_Tipo_Documento.RN_Numero_ID(8);
            Distrito();
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();

            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);

            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }
        private bool Validar_Caja_Texto()
        {
            Frm_Filtro Filtro = new Frm_Filtro();
          

            if (textIDCliente.Text.Trim().Length < 2)
            {
                Filtro.Show();
                MessageBox.Show("Ingrese el ID del Cliente", "ID Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Filtro.Hide();
                textIDCliente.Focus();
                return false;
            }
            if (textNombreCliente.Text.Trim().Length < 2)
            {
                Filtro.Show();
                MessageBox.Show("Ingrese el Nombre del Cliente", "Nombre Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Filtro.Hide();
                textNombreCliente.Focus();
                return false;
            }
            if (textDNICliente.Text.Trim().Length < 8)
            {
                Filtro.Show();
                MessageBox.Show("Ingrese el DNI del Cliente", "DNI Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Filtro.Hide();
                textDNICliente.Focus();
                return false;
            }
            if (Cbo_DsitritoCliente.SelectedIndex == -1)
            {
                Filtro.Show();
                MessageBox.Show("Selecciona un Distrito", "Distrito Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Filtro.Hide();
                Cbo_DsitritoCliente.Focus();
                return false;
            }
            if (textLiMitCreditCLiente.Text.Trim().Length == 0)
            {
                Filtro.Show();
                MessageBox.Show("Digite el limite del credito", "Credito Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Filtro.Hide();
                textLiMitCreditCLiente.Focus();
                return false;
            }
            return true;

        }
        private void Distrito()
        {
            RN_Distrito Dis = new RN_Distrito();
            DataTable Dato = new DataTable();
            Dato = Dis.RN_Motrar();

            if (Dato.Rows.Count > 0) 
            {
                Cbo_DsitritoCliente.DataSource = Dato;
                Cbo_DsitritoCliente.DisplayMember = "Distrito";
                Cbo_DsitritoCliente.ValueMember = "Id_Dis";
                Cbo_DsitritoCliente.SelectedIndex = -1;
            }

        }
        
        private void Registrar_Cliente()
        {
            try
            {
                RN_Clientes CLiN = new RN_Clientes();
                EN_Clientes CLiE = new EN_Clientes();

                CLiE.Idcliente = textIDCliente.Text;
                CLiE.Razonsocial = textNombreCliente.Text;
                CLiE.Dni = textDNICliente.Text;
                CLiE.Direccion = textDictCliente.Text;
                CLiE.Telefono = textTelCliente.Text;
                CLiE.Emiel = textCorreoCliente.Text;
                CLiE.IdDis = Convert.ToInt32(Cbo_DsitritoCliente.SelectedValue);
                CLiE.FechaAniver = FechaAniver.Value;
                CLiE.Contacto = textContactoCliente.Text;
                CLiE.LimiteCred = textLiMitCreditCLiente.Text;
                //CLiE.

                CLiN.RN_Insetar_Cliente(CLiE);

                if (BD_Cliente.saved == true)     
                {
                    Limpiar_TextBox();

                    RN_Tipo_Documento.RN_Actualizar_Tipo_Document_CorelativoProducto(8);

                    MessageBox.Show("Se guardo los Datos del Cliente" ,"Registrar_Cliente Fmr_CLiente", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Tag = "A";
                    this.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No Se Registro Corectamente el Cliente" + Ex.Message,"Registrar_Cliente Fmr_Cliente", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        public void Limpiar_TextBox()
        {
            textIDCliente.Text = " ";
            textNombreCliente.Text = " ";
            textDictCliente.Text = " ";
            textTelCliente.Text = " ";
            textDNICliente.Text = " ";
            textCorreoCliente.Text = " ";
            textContactoCliente.Text = " ";
            textLiMitCreditCLiente.Text = "0";
            Cbo_DsitritoCliente.SelectedIndex = -1;
        }
    
        private void btn_cerrar_Click_1(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void bunifuThinButtonRegistrar_Click(object sender, EventArgs e)
        {
            if (Validar_Caja_Texto() == true)
            {
                Registrar_Cliente();
            }
        }

        private void bunifuThinButtonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar_TextBox();
        }

        //nota el id del producto no es auto incrementable por eso me da un error al borrar el id de mi tabla Proveedor en algunas ocasiones 
    }
}
