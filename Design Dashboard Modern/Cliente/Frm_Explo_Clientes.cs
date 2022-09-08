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
using Capa_Datos;
using Capa_Entidad;
using System.Runtime.InteropServices;

namespace Design_Dashboard_Modern.Cliente
{
    public partial class Frm_Explo_Clientes : Form
    {
        public Frm_Explo_Clientes()
        {
            InitializeComponent();
        }

        private void Frm_Explo_Prod_Load(object sender, EventArgs e)
        {
            Configurar_ListVew();
            Cargar_Los_Clientes();
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void btn_minimi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_titu_MouseMove(object sender, MouseEventArgs e)
        {
            Utilitario obj = new Utilitario();

            if (e.Button == MouseButtons.Left)
            {
                obj.Mover_formulario(this);

            }
        }
        private void Configurar_ListVew()
        {
            var ListViewCliente = listViewCliente;

            ListViewCliente.Items.Clear();
            ListViewCliente.Columns.Clear();
            ListViewCliente.View = View.Details;
            ListViewCliente.GridLines = false;
            ListViewCliente.FullRowSelect = true;
            ListViewCliente.Scrollable = true;
            ListViewCliente.HideSelection = false;
            ListViewCliente.Columns.Add("Id Cliente",80, HorizontalAlignment.Left );//0
            ListViewCliente.Columns.Add("Datos del Cliente", 270, HorizontalAlignment.Center);//1
            ListViewCliente.Columns.Add("Dni", 130, HorizontalAlignment.Center);//2
            ListViewCliente.Columns.Add("Direccion", 210, HorizontalAlignment.Center);//3
            ListViewCliente.Columns.Add("telefono", 180, HorizontalAlignment.Center);//4
            ListViewCliente.Columns.Add("Limite de credito", 150, HorizontalAlignment.Center);//5
            ListViewCliente.Columns.Add("Estado", 110, HorizontalAlignment.Center);//5
        }
        private void LLenar_ListVew(DataTable V) // llenar el listview
        {
            listViewCliente.Items.Clear();

            for (int i = 0; i < V.Rows.Count; i++)
            {
                DataRow Dr = V.Rows[i];
                ListViewItem Lista = new ListViewItem(Dr["Id_Cliente"].ToString());
                Lista.SubItems.Add(Dr["Razon_Social_Nombres"].ToString());
                Lista.SubItems.Add(Dr["DNI"].ToString());
                Lista.SubItems.Add(Dr["Direccion"].ToString());
                Lista.SubItems.Add(Dr["Telefono"].ToString());
                Lista.SubItems.Add(Dr["Limit_Credit"].ToString());
                Lista.SubItems.Add(Dr["Estado_Cli"].ToString());
                listViewCliente.Items.Add(Lista);
            }
            Colores_Filas();
            PanelResult.Visible = false;
            lbl_TotalItems.Text = listViewCliente.Items.Count.ToString();

        }
        private void Colores_Filas()
        {
            int Count = 0;
            for (int i= 0; i < listViewCliente.Items.Count; i++ )
            {
                if (Count % 2 == 1)
                {
                    listViewCliente.Items[i].BackColor = Color.WhiteSmoke;
                }
                Count++;
            }
        }
        public void Cargar_Los_Clientes()
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
                listViewCliente.Items.Clear();
                PanelResult.Visible = true;
            }
        }
        public void Buscar_Los_Clientes(string valor)
        {
            RN_Clientes Cli = new RN_Clientes();
            DataTable BuscarClienes = new DataTable();

            BuscarClienes = Cli.RN_Bucar_Cliente( valor,"Activo");

            if (BuscarClienes.Rows.Count > 0)
            {
                LLenar_ListVew(BuscarClienes);
            }
            else
            {
                listViewCliente.Items.Clear();
                PanelResult.Visible = true;
            }
        }

        private void txt_buscar_proveedor_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_buscar_Clientes.Text.Trim().Length > 0)
            {
                Buscar_Los_Clientes(txt_buscar_Clientes.Text);
            }
            else
            {
                if (String.IsNullOrEmpty(txt_buscar_Clientes.Text))
                {
                    PanelResult.Visible = false;
                    Cargar_Los_Clientes();
                }
            }
        }
        private void txt_buscar_Clientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PanelResult.Visible = false;
                Cargar_Los_Clientes();
            }
        }
       

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Fmr_Add_Clientes AddCli = new Fmr_Add_Clientes();

            filtro.Show();
            AddCli.ShowDialog();
            filtro.Hide();

            if (AddCli.Tag.ToString() == "A")
            {
                Cargar_Los_Clientes();
            }
        }
        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonEditar_Click(sender, e);
        }
        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Fmr_Add_Clientes AddCli = new Fmr_Add_Clientes();

            filtro.Show();
            AddCli.ShowDialog();
            filtro.Hide();

            if (AddCli.Tag.ToString() == "A")
            {
                Cargar_Los_Clientes();
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
          
            Fmr_Editar_Clientes EditCli = new Fmr_Editar_Clientes();

            if (listViewCliente.SelectedIndices.Count == 0)
            {
                filtro.Show();
                MessageBox.Show("Seleccione el item que seas ediar","Editar Cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
                filtro.Hide();
            }
            else
            {
                var lis = listViewCliente.SelectedItems[0];
                string idCliente = lis.SubItems[0].Text;

                filtro.Show();
                EditCli.Tag = idCliente;
                EditCli.ShowDialog();
                filtro.Hide();

                if (EditCli.Tag.ToString() == "A")
                {
                    Cargar_Los_Clientes();
                }
            }
        }

        private void eliminarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
           
            //Fmr_Editar_Clientes EditCli = new Fmr_Editar_Clientes();
            RN_Clientes CliEnt = new RN_Clientes();

            if (listViewCliente.SelectedIndices.Count == 0)
            {
                filtro.Show();
                MessageBox.Show("Seleccione el item que seas Eliminar","Eliminar Cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
                filtro.Hide();
            }
            else
            {
                string message = "Estas seguro que desea elimar el Cliente?";
                string caption = "Eliminar Cliente";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(this, message, caption, buttons,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);

                if (result == DialogResult.Yes)
                {
                    var lis = listViewCliente.SelectedItems[0];
                    string idCliente = lis.SubItems[0].Text;


                    CliEnt.RN_Eliminar_Cliente(idCliente);

                    Cargar_Los_Clientes();
                }

            }
        }
        [DllImport("User32.dll", EntryPoint = "ReleaseCapture")]
        private  extern static void ReleaseCapture();
        [DllImport("User32.dll")]
        private extern static void SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void pnl_titu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }
    }
}
