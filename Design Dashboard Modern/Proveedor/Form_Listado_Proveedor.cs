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

namespace Design_Dashboard_Modern.Proveedor
{
    public partial class Form_Listado_Proveedor : Form
    {
        public Form_Listado_Proveedor()
        {
            InitializeComponent();
            
        }
        private void Form_Listado_Proveedor_Load(object sender, EventArgs e)
        {
            Configurar_List_Vew();
            Cargar_Proveedor();
        }
        private void Configurar_List_Vew()
        {
            var List_Listar_Proveedor = list_ListarProveedor;

            List_Listar_Proveedor.Items.Clear();// esto es para limpiar los items
            List_Listar_Proveedor.Columns.Clear();
            List_Listar_Proveedor.View = View.Details;
            List_Listar_Proveedor.GridLines = false;
            List_Listar_Proveedor.FullRowSelect = true;
            List_Listar_Proveedor.Scrollable = true;
            List_Listar_Proveedor.HideSelection = false;
            List_Listar_Proveedor.Columns.Add("ID ", 0, HorizontalAlignment.Left);//0
            List_Listar_Proveedor.Columns.Add(" Nombre Del Proveedor", 405, HorizontalAlignment.Left);//1
        }
        private void LLenar_Lisvew_Producto(DataTable v)
        {
            list_ListarProveedor.Items.Clear(); // estoy limpiando el lisvew para que no haya error

            for (int i = 0; i < v.Rows.Count; i++)
            {
                DataRow Dr = v.Rows[i]; // los datos optenidos de la fila del listvew cuando se recorra el ciclo se van a guardar en Dr
                ListViewItem lista = new ListViewItem(Dr["IDPROVEE"].ToString());
                lista.SubItems.Add(Dr["NOMBRE"].ToString());
                list_ListarProveedor.Items.Add(lista);
            }
        }
        private void Cargar_Proveedor()
        {
            DataTable Data = new DataTable();
            RN_Proveedor ProVee = new RN_Proveedor();

            Data = ProVee.RN_Mostrar_Proveerdor();

            if (Data.Rows.Count > 0)
            {
                LLenar_Lisvew_Producto(Data);
            }
            else
            {
                list_ListarProveedor.Items.Clear();
            }
        }
        private void list_ListarProveedor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (list_ListarProveedor.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Seleccione un Proveedor ", "Advertencia de Seguridad", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                textBoxID.Text = list_ListarProveedor.SelectedItems[0].SubItems[0].Text;
                textBoxNombre.Text = list_ListarProveedor.SelectedItems[0].SubItems[1].Text;

                this.Tag = "A";
                this.Close();
            }
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void list_ListarProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Seleccione un Proveedor ", "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                textBoxID.Text = list_ListarProveedor.SelectedItems[0].SubItems[0].Text;
                textBoxNombre.Text = list_ListarProveedor.SelectedItems[0].SubItems[1].Text;

                this.Tag = "A";
                this.Close();
            }
        }
    }
}
