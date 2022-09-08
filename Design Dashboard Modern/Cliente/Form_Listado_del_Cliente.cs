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
using Capa_Entidad;
using Capa_Datos;

namespace Design_Dashboard_Modern.Cliente
{
    public partial class Form_Listado_del_Cliente : Form
    {
        public Form_Listado_del_Cliente()
        {
            InitializeComponent();
        }
        private void Form_Listado_del_Cliente_Load(object sender, EventArgs e)
        {
            Configurar_ListVew();
            Cargar_Los_Clientes();
        }
        private void Configurar_ListVew()
        {
            var listVewCli = listViewcliente;

            listVewCli.Items.Clear();
            listVewCli.Columns.Clear();
            listVewCli.View = View.Details;
            listVewCli.GridLines = false;
            listVewCli.FullRowSelect = true;
            listVewCli.Scrollable = true;
            listVewCli.HideSelection = false;
            listVewCli.Columns.Add("Id Cliente",0, HorizontalAlignment.Left);//0
            listVewCli.Columns.Add("Nombre del cliente", 252, HorizontalAlignment.Left);//1
            listVewCli.Columns.Add("Dni", 128, HorizontalAlignment.Left);//2
            listVewCli.Columns.Add("Estado", 164, HorizontalAlignment.Left);//3
 
        }
        private void LLenar_ListVew(DataTable V) // llenar el listview
        {
            listViewcliente.Items.Clear();

            for (int i = 0; i < V.Rows.Count; i++)
            {
                DataRow Dr = V.Rows[i];
                ListViewItem Lista = new ListViewItem(Dr["Id_Cliente"].ToString());
                Lista.SubItems.Add(Dr["Razon_Social_Nombres"].ToString());
                Lista.SubItems.Add(Dr["DNI"].ToString());
                Lista.SubItems.Add(Dr["Estado_Cli"].ToString());
                listViewcliente.Items.Add(Lista);
            }
            Colores_Filas();
        }
        private void Colores_Filas()
        {
            int Count = 0;
            for (int i = 0; i < listViewcliente.Items.Count; i++)
            {
                if (Count % 2 == 1)
                {
                    listViewcliente.Items[i].BackColor = Color.AliceBlue;
                }
                Count++;
            }
        }
        private void Cargar_Los_Clientes()
        {
            RN_Clientes Cli = new RN_Clientes();
            DataTable CargarClientes = new DataTable();

            CargarClientes = Cli.RN_Listar_Clientes("Activo");

            if (CargarClientes.Rows.Count > 0)
            {
                LLenar_ListVew(CargarClientes);
            }
            else
            {
                listViewcliente.Items.Clear();
                //PanelCliente.Visible = false;
            }
        }
        private void Buscar_Los_Clientes(string valor)
        {
            RN_Clientes Cli = new RN_Clientes();
            DataTable BuscarClienes = new DataTable();

            BuscarClienes = Cli.RN_Bucar_Cliente(valor, "Activo");

            if (BuscarClienes.Rows.Count > 0)
            {
                LLenar_ListVew(BuscarClienes);
            }
            else
            {
                listViewcliente.Items.Clear();
                //PanelCliente.Visible = true;
            }
        }

        private bool Validar_Caja_Texto()
        {
            Frm_Filtro Filtro = new Frm_Filtro();
           // Frm_Advertencia Advertencia = new Frm_Advertencia();

            if (IDCliente.Text.Trim().Length < 2)
            {
                Filtro.Show();
                //Advertencia.textBox1.Text = "Ingrese o Genere el ID del Cliene";
                //Advertencia.Show();
                MessageBox.Show("Ingrese o Genere el ID del Cliene","Listado Cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Filtro.Hide();
                IDCliente.Focus();
                return false;
            }
            if (NombreCliente.Text.Trim().Length < 2)
            {
                Filtro.Show();
                //Advertencia.textBox1.Text = "Ingrese El nombre del cliente";
                //Advertencia.Show();
                MessageBox.Show("Ingrese El nombre del cliente", "Listado Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Filtro.Hide();
                NombreCliente.Focus();
                return false;
            }
            if (cedula.Text.Trim().Length < 2)
            {
                Filtro.Show();
                //Advertencia.textBox1.Text = "Ingrese El nombre del cliente";
                //Advertencia.Show();
                MessageBox.Show("Ingrese El nombre del cliente", "Listado Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Filtro.Hide();
                cedula.Focus();
                return false;
            }
            if (Ubicacion.Text.Trim().Length < 2)
            {
                Filtro.Show();
                //Advertencia.textBox1.Text = "Ingrese El nombre del cliente";
                //Advertencia.Show();
                MessageBox.Show("Ingrese El nombre del cliente", "Listado Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Filtro.Hide();
                Ubicacion.Focus();
                return false;
            }
            return true;

        }
        private void Registrar_Cliente()
        {
            try
            {
                RN_Clientes CLiN = new RN_Clientes();
                EN_Clientes CLiE = new EN_Clientes();

                CLiE.Idcliente = IDCliente.Text;
                CLiE.Razonsocial = NombreCliente.Text;
                CLiE.Dni = cedula.Text;
                CLiE.Direccion = Ubicacion.Text;
                CLiE.Telefono = "0";
                CLiE.Emiel = "-";
                CLiE.IdDis = 1;
                CLiE.FechaAniver = FechaAniver.Value;
                CLiE.Contacto = "-";
                CLiE.LimiteCred =  Convert.ToString("0");
                CLiN.RN_Insetar_Cliente(CLiE);

                if (BD_Cliente.saved == true)
                {  

                    RN_Tipo_Documento.RN_Actualizar_Tipo_Document_CorelativoProducto(8);

                    MessageBox.Show("Se guardo los Datos del Cliente", "Registrar_Cliente Fmr_CLiente", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    txt_buscar_Clientes.Text = IDCliente.Text;
                    Limpiar_TextBox();
                    PanelCliente.Visible = false;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No Se Registro Corectamente el Cliente" + Ex.Message, "Registrar_Cliente Fmr_Cliente", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            PanelCliente.Visible = false;
            Limpiar_TextBox();
        }

        private void ButtonListo_Click(object sender, EventArgs e)
        {
            if (Validar_Caja_Texto() == true)
            {
                Registrar_Cliente();
            }
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            IDCliente.Text = RN_Tipo_Documento.RN_Numero_ID(8);
            PanelCliente.Visible = true;
            NombreCliente.Focus();
        }
        private void Limpiar_TextBox()
        {
            IDCliente.Text = " ";
            NombreCliente.Text = " ";
            cedula.Text = " ";
            Ubicacion.Text = " ";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Tag = "A";
            this.Close();
        }

        private void txt_buscar_Clientes_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_buscar_Clientes.Text.Trim().Length >2)
            {
                Buscar_Los_Clientes(txt_buscar_Clientes.Text);
            }
        }

        private void txt_buscar_Clientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_buscar_Clientes.Text.Trim().Length > 2)
                {
                    Buscar_Los_Clientes(txt_buscar_Clientes.Text);
                }
                else
                {
                    Cargar_Los_Clientes();
                }
            }
        }
        private void Seleccionar_Cliente()
        {
            if (listViewcliente.SelectedIndices.Count == 0)
            {

            }
            else
            {
                var Lista = listViewcliente.SelectedItems[0];
                labelID.Text = Lista.SubItems[0].Text;
                labelNom.Text = Lista.SubItems[1].Text;
                lblruc.Text = Lista.SubItems[2].Text;

                this.Tag = "A";
                this.Close();
            }
        }
        private void listViewcliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Seleccionar_Cliente();
        }

        private void listViewcliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Seleccionar_Cliente();
            }
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();

            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);

            }
        }
    }
}
