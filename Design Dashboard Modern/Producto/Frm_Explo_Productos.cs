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
using Design_Dashboard_Modern.Utilitarios;
using Design_Dashboard_Modern.Producto;

//en el lisvew le falto marca para que el usuario la pueda visualisar

namespace Design_Dashboard_Modern.Producto
{
    public partial class Frm_Explo_Productos : Form
    {
        public Frm_Explo_Productos()
        {
            InitializeComponent();
        }

        private void Frm_Explo_Prod_Load(object sender, EventArgs e)
        {
            Configurar_ListVew();
            Cargar_Los_Productos();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Configurar_ListVew()
        {
            var listVewMarca = listViewProducto;

            listVewMarca.Items.Clear();
            listVewMarca.Columns.Clear();
            listVewMarca.View = View.Details;
            listVewMarca.GridLines = false;
            listVewMarca.FullRowSelect = true;
            listVewMarca.Scrollable = true;
            listVewMarca.HideSelection = false;
            listVewMarca.Columns.Add("ID", 100, HorizontalAlignment.Left);//0
            listVewMarca.Columns.Add("Nombre del Producto", 244, HorizontalAlignment.Center);//1
            listVewMarca.Columns.Add("Stock", 100, HorizontalAlignment.Center);//2
            listVewMarca.Columns.Add("Pre Compra", 100, HorizontalAlignment.Center);//3
            listVewMarca.Columns.Add("Frank", 131, HorizontalAlignment.Center);//4
            listVewMarca.Columns.Add("Precio Venta 1", 110, HorizontalAlignment.Center);//5
            listVewMarca.Columns.Add("Precio Venta 2", 110, HorizontalAlignment.Center);//5
            listVewMarca.Columns.Add("Utilidad", 90, HorizontalAlignment.Center);//5
            listVewMarca.Columns.Add("Total", 90, HorizontalAlignment.Center);//5
            listVewMarca.Columns.Add("Estado", 90, HorizontalAlignment.Center);//5

        }
        private void LLenar_ListVew(DataTable V)
        {
            listViewProducto.Items.Clear();

            for (int i = 0; i < V.Rows.Count; i++)
            {
                DataRow Dr = V.Rows[i];
                ListViewItem Lista = new ListViewItem(Dr["Id_Pro"].ToString());
                Lista.SubItems.Add(Dr["Descripcion_Larga"].ToString());
                Lista.SubItems.Add(Dr["Stock_Actual"].ToString());
                Lista.SubItems.Add(Dr["Pre_CompraS"].ToString());
                Lista.SubItems.Add(Dr["Frank"].ToString());
                Lista.SubItems.Add(Dr["Pre_vntaxMenor"].ToString());
                Lista.SubItems.Add(Dr["Pre_vntaxMayor"].ToString());
                Lista.SubItems.Add(Dr["UtilidadUnit"].ToString());
                Lista.SubItems.Add(Dr["Valor_porCant"].ToString());
                Lista.SubItems.Add(Dr["Estado_Pro"].ToString());
                Lista.SubItems.Add(Dr["Marca"].ToString());
                listViewProducto.Items.Add(Lista);
            }
            Colores_Filas();
            //PanelResult.Visible = false;
        }
        private void Colores_Filas()
        {
            int Count = 0;
            for (int i = 0; i < listViewProducto.Items.Count; i++)
            {
                if (Count % 2 == 1)
                {
                    listViewProducto.Items[i].BackColor = Color.WhiteSmoke;
                }
                Count++;
            }
        }
        public void Cargar_Los_Productos()
        {

            RN_Producto Pro = new RN_Producto();
            DataTable CargarProductos = new DataTable();

            CargarProductos = Pro.RN_Mostrar_Productos();

            if (CargarProductos.Rows.Count > 0)
            {
                LLenar_ListVew(CargarProductos);
            }
            else
            {
                listViewProducto.Items.Clear();
                PanelResult.Visible = true;
            }
        }
        public void Buscar_Los_Productos(string V)
        {
            RN_Producto Pro = new RN_Producto();
            DataTable BuscarProductos = new DataTable();

            BuscarProductos = Pro.RN_Buscar_Productos(V);

            if (BuscarProductos.Rows.Count > 0)
            {
                LLenar_ListVew(BuscarProductos);
            }
            else
            {
                listViewProducto.Items.Clear();
                PanelResult.Visible = true;
            }
        }
        private void txt_buscar_Producto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PanelResult.Visible = false;
                Cargar_Los_Productos();
            }
        }
        private void txt_buscar_Producto_OnValueChanged(object sender, EventArgs e)
        {
            if (txt_buscar_Producto.Text.Trim().Length > 0)
            {
                Buscar_Los_Productos(txt_buscar_Producto.Text);
            }
            else
            {
                if (String.IsNullOrEmpty(txt_buscar_Producto.Text))
                {
                    PanelResult.Visible = false;
                    Cargar_Los_Productos();
                }
            }

        }

        private void copiarIDProveedor_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            //Frm_Advertencia Advert = new Frm_Advertencia();

            if (listViewProducto.SelectedIndices.Count == 0) //esto quiere decir que el usuario no ha seleccionado nada en la tabla
            {
                MessageBox.Show("Si desea copiar el ID seleccione un Item", "ID del Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var lis = listViewProducto.SelectedItems[0];
                string idProveedor = lis.SubItems[0].Text;

                Clipboard.Clear();
                Clipboard.SetText(idProveedor.Trim());

            }
        }
        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {

            Frm_Filtro filtro = new Frm_Filtro();
            Frm_Agregar_Productos Add = new Frm_Agregar_Productos();

            filtro.Show();
            Add.ShowDialog();
            filtro.Hide();

            if (Add.Tag.ToString() == "A")
            {
                Cargar_Los_Productos();
            }
        }
        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Frm_Agregar_Productos Add = new Frm_Agregar_Productos();

            filtro.Show();
            Add.ShowDialog();
            filtro.Hide();

            if (Add.Tag.ToString() == "A")
            {
                Cargar_Los_Productos();
            }
        }
        private void mostrarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Frm_Editar_Productos edit = new Frm_Editar_Productos(); //error

            if (listViewProducto.SelectedIndices.Count == 0) //esto quiere decir que el usuario no ha seleccionado nada en la tabla
            {
                filtro.Show();
                MessageBox.Show("Seleccione el item que deseas ediar","Editar productos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //Advert.textBox1.Text = "Seleccione el item que seas ediar"; ;
                //Advert.ShowDialog();
                filtro.Hide();
            }
            else
            {
                var lis = listViewProducto.SelectedItems[0];
                string idProveedor = lis.SubItems[0].Text;

                filtro.Show();
                edit.Tag = idProveedor;
                edit.ShowDialog();
                filtro.Hide();

                if (edit.Tag.ToString() == "A")
                {
                    Cargar_Los_Productos();
                }
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();

            Frm_Editar_Productos edit = new Frm_Editar_Productos();

            if (listViewProducto.SelectedIndices.Count == 0)
            {
                filtro.Show();
                MessageBox.Show("seleccione un Item para poder editar");
                filtro.Hide();
            }
            else
            {
                var lis = listViewProducto.SelectedItems[0];
                string idProducto = lis.SubItems[0].Text;

                filtro.Show();
                edit.Tag = idProducto;
                edit.ShowDialog();
                filtro.Hide();

                if (edit.Tag.ToString() == "A")
                {
                    Cargar_Los_Productos();
                }

            }
        }
    }
}
