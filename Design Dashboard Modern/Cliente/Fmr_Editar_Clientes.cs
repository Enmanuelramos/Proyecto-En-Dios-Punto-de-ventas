using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Dashboard_Modern.Utilitarios;
using Capa_Datos;
using Capa_Entidad;
using Capa_Negocio;

namespace Design_Dashboard_Modern.Cliente
{
    public partial class Fmr_Editar_Clientes : Form
    {
        public Fmr_Editar_Clientes()
        {
            InitializeComponent();
        }
        private void Frm_Reg_Prod_Load(object sender, EventArgs e)
        {
            Buscar_Clientes_Para_Editar(this.Tag.ToString());
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
        private void Buscar_Clientes_Para_Editar(string idCli)
        {
            RN_Clientes Cli = new RN_Clientes();
            DataTable data = new DataTable();

            Distrito();

            try
            {
                data = Cli.RN_Bucar_Cliente(idCli, "activo");

                if (data.Rows.Count > 0)
                {
                    //estamos trabajando con matrices fila y columna, columna 0 y fila corespondiente
                    textIDCliente.Text = Convert.ToString(data.Rows[0]["Id_Cliente"]);
                    textNombreCliente.Text = Convert.ToString(data.Rows[0]["Razon_Social_Nombres"]);
                    textDictCliente.Text = Convert.ToString(data.Rows[0]["Direccion"]);
                    textTelCliente.Text = Convert.ToString(data.Rows[0]["Telefono"]);
                    textDNICliente.Text = Convert.ToString(data.Rows[0]["DNI"]);
                    textCorreoCliente.Text = Convert.ToString(data.Rows[0]["E_Mail"]);
                    textContactoCliente.Text = Convert.ToString(data.Rows[0]["Contacto"]);
                    textLiMitCreditCLiente.Text = Convert.ToString(data.Rows[0]["Limit_Credit"]);
                    Cbo_DsitritoCliente.SelectedValue = Convert.ToString(data.Rows[0]["Id_Dis"]);
                    FechaAniver.Value = Convert.ToDateTime(data.Rows[0]["Fcha_Ncmnto_Anivsrio"]);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No Se edito Corectamente el Cliente " + Ex.Message, "Editar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void Editar_Cliente()
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

                CLiN.RN_ModificarCliente(CLiE);

                if (BD_Cliente.Edito == true)     
                {
                    Limpiar_TextBox();
                   // RN_Tipo_Documento.RN_Actualizar_Tipo_Document_CorelativoProducto(8);
                    MessageBox.Show("Se Edito los Datos del Cliente" ,"Modificar los Cliente Fmr_CLiente", MessageBoxButtons.OK, MessageBoxIcon.Question);
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

        private void bunifuThinButtonEditar_Click(object sender, EventArgs e)
        {
            if (Validar_Caja_Texto() == true)
            {
                Editar_Cliente();
            }
        }

        private void bunifuThinButtonLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar_TextBox();
        }
    }
}
