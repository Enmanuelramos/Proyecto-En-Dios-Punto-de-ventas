//importar 
using Design_Dashboard_Modern.Producto;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Capa_Datos;
using Capa_Entidad;
using Capa_Negocio;
using Design_Dashboard_Modern.Utilitarios;

namespace Design_Dashboard_Modern.Compras
{
    public partial class Frm_Compras : Form
    {
        public Frm_Compras()
        {
            InitializeComponent();
        }

        private void Frm_Ventana_Ventas_Load(object sender, EventArgs e)
        {
            Configurar_ListVew();
            Llenar_Combo_Proveedor();
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
            this.Close();
            this.Tag = "";
        }

        private void btn_minimi_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void Configurar_ListVew()
        {
            var ListvewDetalle = lsv_Det;

            ListvewDetalle.Items.Clear();
            ListvewDetalle.Columns.Clear();
            ListvewDetalle.View = View.Details;
            ListvewDetalle.GridLines = false;
            ListvewDetalle.FullRowSelect = true;
            ListvewDetalle.Scrollable = true;
            ListvewDetalle.HideSelection = false;
            ListvewDetalle.Columns.Add("Ide Prod", 80, HorizontalAlignment.Left);//0
            ListvewDetalle.Columns.Add("Descripcion del Producto", 377, HorizontalAlignment.Left);//1
            ListvewDetalle.Columns.Add("Cant", 80, HorizontalAlignment.Left);//2
            ListvewDetalle.Columns.Add("Pre Unit", 90, HorizontalAlignment.Right);//3
            ListvewDetalle.Columns.Add("Importe", 90, HorizontalAlignment.Right);//5

        }
        private void Llenar_Combo_Proveedor()
        {

            RN_Proveedor ProVer = new RN_Proveedor();
            DataTable Datos = new DataTable();

            Datos = ProVer.RN_Mostrar_Proveerdor();

            if (Datos.Rows.Count > 0)
            {
                var CBO = cbo_provee;

                CBO.DataSource = Datos;
                CBO.DisplayMember = "NOMBRE";
                CBO.ValueMember = "IDPROVEE";
                CBO.SelectedIndex = -1;
            }
        }

        public static string XidProducto;
        public static string XnomProduct;
        public static double Xcant;
        public static double Xprecio;
        public static double Ximporte;

        private void Calcular()
        {
            double xtotal =0;
            double xcantida = 0;
            double xprecio = 0;
            double ximporte = 0;
            double xitv = 0;
            double xsubtotal = 0;

            for (int i=0; i < lsv_Det.Items.Count; i++)
            {
                // para entender mas este bucle el listvew es una matriz con fila y colummna
                // la variable [i] son las filas [-] y los numeros son las colummna [|]

                xcantida = Convert.ToDouble(lsv_Det.Items[i].SubItems[2].Text);
                xprecio = Convert.ToDouble(lsv_Det.Items[i].SubItems[3].Text);

                //Calculando el importe
                ximporte = xprecio * xcantida;
                lsv_Det.Items[i].SubItems[4].Text = ximporte.ToString("###0,00"); 

                //Calculo del total
                xtotal = xtotal + Convert.ToDouble(lsv_Det.Items[i].SubItems[2].Text);// esta sumando la cantidad en un acumulador

                //calcular los impuestos itebis 0.18
                xsubtotal = xtotal / 1.18;
                xitv = xsubtotal * 0.18;

                lbl_subtotal.Text = xsubtotal.ToString("###0,00");
                lbl_itbis.Text = xitv.ToString("###0,00");
                lbl_TotalPagar.Text = xtotal.ToString("###,00");

            }
        }
        private void Agregar_Producto_AlCarrito()
        {
            try
            {
                if (lsv_Det.Items.Count == 0)
                {
                    ListViewItem item = new ListViewItem();
                    item = lsv_Det.Items.Add(XidProducto);
                    item.SubItems.Add(XnomProduct.Trim());
                    item.SubItems.Add(Xcant.ToString());
                    item.SubItems.Add(Xprecio.ToString());
                    item.SubItems.Add(Ximporte.ToString());

                    Calcular();
                    lsv_Det.Focus();
                    lsv_Det.Items[0].Selected = true;

                    pnl_sinProd.Visible = false;
                }
                else
                {
                    //validar que el producto no se ingrese dos veces
                    for (int i = 0; i < lsv_Det.Items.Count; i++)
                    {
                        if (lsv_Det.Items[i].Text.Trim() == XidProducto.Trim()) //nota por el trim no se me ejecuto el mensaje es muy importante esa parte
                        //esto quiere decir si en el listvew o en la tabla hay un producto del mismo tipo 
                        // con el for me recorre el lisvew completo para poder indentificar el producto
                        {
                            MessageBox.Show("El producto fue agregado al carrito", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return; // se utiliza para romper el bucle 
                        }
                    }
                    ListViewItem item = new ListViewItem();
                    item = lsv_Det.Items.Add(XidProducto);
                    item.SubItems.Add(XnomProduct);
                    item.SubItems.Add(Xcant.ToString());
                    item.SubItems.Add(Xprecio.ToString());
                    item.SubItems.Add(Ximporte.ToString());

                    Calcular();
                    lsv_Det.Focus();
                    lsv_Det.Items[0].Selected = true;
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_Nuevo_buscarProd_Click(object sender, EventArgs e)
        {

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            Frm_Filtro fill = new Frm_Filtro();
            Frm_List_Pro_Compra com = new Frm_List_Pro_Compra();

            fill.Show();
            com.txt_buscar_Producto.Focus();
            com.ShowDialog();
            fill.Hide();

            if (com.Tag.ToString() == "A")
            {
                Agregar_Producto_AlCarrito();
            }
        }

        private void bt_editPre_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Frm_Solo_Precio Precio = new Frm_Solo_Precio();

            if (lsv_Det.SelectedIndices.Count == 0)
            {
                MessageBox.Show("ingrese el atiem para modificar el precio", "Editar precio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double Precio_ingresado = 0;
                double Precio_Editado = 0;

                Precio_ingresado = Convert.ToDouble(lsv_Det.SelectedItems[0].SubItems[3].Text);

                filtro.Show();
                Precio.txt_cant.Text = Precio_ingresado.ToString();
                Precio.ShowDialog();
                filtro.Hide();

                if (Precio.Tag.ToString() == "A")
                {
                    Precio_Editado = Convert.ToDouble(Precio.txt_cant.Text);
                    lsv_Det.SelectedItems[0].SubItems[3].Text = Precio_Editado.ToString();
                    Calcular();
                }
            }
        }

        private void bt_editCant_Click(object sender, EventArgs e)
        {
            Frm_Filtro filtro = new Frm_Filtro();
            Frm_Solo_Cantidad Cantidad = new Frm_Solo_Cantidad();

            if (lsv_Det.SelectedIndices.Count == 0)
            {
                MessageBox.Show("ingrese el atiem para modificar la cantidad", "Editar precio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                double Cantidad_ingresado = 0;
                double Cantidad_Editado = 0;

                Cantidad_ingresado = Convert.ToDouble(lsv_Det.SelectedItems[0].SubItems[2].Text);

                filtro.Show();
                Cantidad.txt_cant.Text = Cantidad_ingresado.ToString();
                Cantidad.ShowDialog();
                filtro.Hide();

                if (Cantidad.Tag.ToString() == "A")
                {
                    Cantidad_Editado = Convert.ToDouble(Cantidad.txt_cant.Text);
                    lsv_Det.SelectedItems[0].SubItems[2].Text = Cantidad_Editado.ToString();
                    Calcular();
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lsv_Det.SelectedIndices.Count == 0)
                {
                    MessageBox.Show("seleccione una fila para poder borrar", "eliminar elemento del carrito", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                }
                var lis = lsv_Det.SelectedItems[0];

                for (int i = lsv_Det.SelectedItems.Count - 1; i >= 0; i--)
                {
                    lsv_Det.Items.Remove(lsv_Det.SelectedItems[i]);
                }
                Calcular();
            }
            catch (Exception Ex)
            {
                string sms = Ex.Message;
            }
        }

        private void Frm_Compras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                if (pnl_sinProd.Visible == true)
                {
                    btn_Nuevo_buscarProd_Click(sender,e);
                }
            }
            if(e.KeyCode == Keys.F4)
            {
                if(pnl_sinProd.Visible == false)
                {
                    bt_add_Click(sender, e);
                }
            }
            if (e.KeyCode == Keys.F5)
            {
                if (pnl_sinProd.Visible == false)
                {
                    btn_procesar_Click(sender, e);
                }
            }
            if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.A))
            {
                if (pnl_sinProd.Visible == false)
                {
                    cbo_provee.Focus();
                }
            }

        }
        private bool Validar_Compras()
        {
            if (lsv_Det.Items.Count == 0)
            {
                Frm_Filtro filtro = new Frm_Filtro();
                filtro.Show();
                MessageBox.Show("Debes de ingresar un registro de compra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lsv_Det.Focus();
                return false;
            }
            if (cbo_provee.SelectedIndex == -1)
            {
                Frm_Filtro filtro = new Frm_Filtro();
                filtro.Show();
                MessageBox.Show("Selecciona el nombre del proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbo_provee.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txt_NroFisico.Text))
            {
                Frm_Filtro filtro = new Frm_Filtro();
                filtro.Show();
                MessageBox.Show("Ingrese el numero fisico", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_NroFisico.Focus();
                return false;

            }
            if (cbo_tipoPago.SelectedIndex == -1)
            {
                Frm_Filtro filtro = new Frm_Filtro();
                filtro.Show();
                MessageBox.Show("selecciona el tipo de pago", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbo_tipoPago.Focus();
                return false;
            }
            if (String.IsNullOrEmpty(txt_IdComp.Text))
                {
                Frm_Filtro filtro = new Frm_Filtro();
                filtro.Show();
                MessageBox.Show("Ingrese Primary Key", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_IdComp.Focus();
                return false;
            }
            if (cbo_tipoDoc.SelectedIndex == -1)
            {
                Frm_Filtro filtro = new Frm_Filtro();
                filtro.Show();
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbo_tipoDoc.Focus();
                return false;
            }
            return true;
        }


        private double Buscar_Frank_Producto(string IdPro)
        {
            RN_Producto Rnpro = new RN_Producto();
            DataTable dato = new DataTable();

            double Frank = 0;
            dato = Rnpro.RN_Buscar_Productos(IdPro);

            if (dato.Rows.Count > 0)
            {
                Frank = Convert.ToDouble(dato.Rows[0]["Frank"]);
                return Frank;
            }
            else
            {
                return 0;
            }

        }
        private void Registrar_Compra()
        {
            EN_Ingreso_Compra IngCom = new EN_Ingreso_Compra();
            EN_Det_Ingreso_Compra DetCom = new EN_Det_Ingreso_Compra();
            RN_Ingreso_Compra IngCoR = new RN_Ingreso_Compra();
            RN_Producto RnProduct = new RN_Producto();

            try
            {

                IngCom.IdCom = txt_IdComp.Text;
                IngCom.Nro_Fac_Fisico = txt_NroFisico.Text;
                IngCom.IdProvee = cbo_provee.SelectedValue.ToString();
                IngCom.SubTotal_Com = lbl_subtotal.Text;
                IngCom.FechaIngre = dtp_FechaCom.Value;
                IngCom.IdUsu = Convert.ToInt32(Cls_Libreria.IdUsu); // de donde salio Cls_Libreria ojo estudiar esa parte
                IngCom.ModalidadPago = cbo_tipoPago.Text;
                IngCom.TiempoEspera = 0;
                IngCom.FechaVence = dtp_FechaVenc.Value;
                IngCom.EstadoIngre = "Activo";
                IngCom.RecibiConforme = recibiConforme;
                IngCom.Datos_Adicional = txt_obser.Text;
                IngCom.Tipo_Doc_Compra = cbo_tipoDoc.Text;

                IngCoR.RN_ingreso_Compra(IngCom);

                if (BD_Ingreso_Compra.guardar == true)
                {
                    RN_Tipo_Documento.RN_Actualizar_Tipo_Document_CorelativoProducto(9);

                    //Detelle de Compra

                    for (int i = 0; i < lsv_Det.Items.Count; i++)
                    {
                        var items = lsv_Det.Items[i];
                        DetCom.Id_ingreso = txt_IdComp.Text;
                        //esta es la parte que del lisvew estoy tomando los datos para agregarlo al detalle de compra
                        DetCom.Id_Pro = items.SubItems[0].Text;
                        DetCom.Cantidad = items.SubItems[2].Text;
                        DetCom.Precio = items.SubItems[3].Text;
                        DetCom.Importe = items.SubItems[4].Text;

                        IngCoR.RN_Ingrese_Detalle_IngresoCompra(DetCom);

                        Registar_MovimientoDe_Kardex(DetCom.Id_Pro.Trim(), DetCom.Cantidad, DetCom.Precio);

                        //Actiualizacion el precio del producto
                        double utilidad = 0;
                        double valorAlmacen = 0;
                        string PreCom = "";
                        double PreVent = 0;
                        double Xfrank = 0;
                        // convertir en string
                        string prevent = "";
                        string Utilidad = "";
                        string ValorAlmacen = "";

                        Xfrank = Buscar_Frank_Producto(DetCom.Id_Pro.Trim());
                        PreVent = Xfrank * Convert.ToDouble(PreCom);
                        utilidad = PreVent - Convert.ToDouble(PreCom);
                        valorAlmacen =  Convert.ToDouble( DetCom.Cantidad) * Convert.ToDouble(PreCom);

                        prevent = Convert.ToString(PreVent);
                        Utilidad = Convert.ToString(utilidad);
                        ValorAlmacen = Convert.ToString(valorAlmacen);

                        RnProduct.RN_Actulizar_Precios_Compra_Venta_Producto(DetCom.Id_Pro.Trim(), PreCom, prevent, Utilidad, ValorAlmacen);

                    }
                    Frm_Filtro Filtro = new Frm_Filtro();
                    Frm_Msm_Bueno bueno = new Frm_Msm_Bueno();

                    Filtro.Show();
                    bueno.Lbl_msm1.Text = "Los datos de la Compra de han registrado correctamente";
                    bueno.ShowDialog();
                    Filtro.Hide();

                    lsv_Det.Items.Clear();
                    cbo_provee.SelectedIndex = -1;
                    txt_NroFisico.Text = "";
                    cbo_tipoDoc.Text = "";
                    cbo_tipoPago.Text = "";
                    txt_obser.Text = "";

                    this.Tag = "A";
                    //this.Close();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error al regitrar la compra" + Ex);
            }

        }
        private void Registar_MovimientoDe_Kardex(string IdProd, string Xcant, string PrecioCmpra)
        {
            RN_Kardex RnKar = new RN_Kardex();
            EN_Kardex Enkar = new EN_Kardex();
            RN_Producto RnPro = new RN_Producto();
            DataTable data = new DataTable();
            DataTable datoPro = new DataTable();

            string idkarDex = "";
            string itemsKar = "";
            string stockPro = "";
            string PreComPro = "";


            try
            {
                if (RnKar.BD_Verificar_Producto_SiTieneKardex(IdProd) == true)
                {
                    data = RnKar.RN_Buscar_KardexDetalle_porProducto(IdProd.Trim());

                    if (data.Rows.Count > 0)
                    {
                        idkarDex = Convert.ToString(data.Rows[0]["Id_krdx"]);
                        itemsKar = Convert.ToString( data.Rows.Count);

                        datoPro = RnPro.RN_Buscar_Productos(IdProd.Trim());
                        stockPro = Convert.ToString(datoPro.Rows[0]["Stock_Actual"]);
                        PreComPro = Convert.ToString(datoPro.Rows[0]["Pre_CompraS"]);

                        Enkar.IdKardex = idkarDex;
                        Enkar.Item = Convert.ToInt32( itemsKar) + 1;
                        Enkar.Doc_soporte = txt_NroFisico.Text;
                        Enkar.Det_operacion = "Compra De Mercaderia";
                        //entrada
                        Enkar.Cantidad_In = Xcant;
                        Enkar.Precio_Unit_In = PrecioCmpra;

                        double xcant = Convert.ToDouble(Xcant);
                        double precioCmpra = Convert.ToDouble(PrecioCmpra);

                        Enkar.Costo_Total_In = Convert.ToString( xcant * precioCmpra);
                        //salida
                        Enkar.Cantidad_Out = "";
                        Enkar.Precio_Unt_Out = "";
                        Enkar.Importe_Total_Out = "";
                        //saldos
                        Enkar.Cantidad_Saldo = Convert.ToString( Convert.ToDouble( stockPro) * Convert.ToDouble(Xcant));
                        Enkar.Promedio = PrecioCmpra;
                        Enkar.Costo_Total_Saldo = Convert.ToString(Convert.ToDouble( PrecioCmpra) * Convert.ToDouble(Enkar.Cantidad_Saldo));

                        RnKar.RN_Registrar_Detalle_Kardex(Enkar);
                        RnPro.RN_Sumar_stock_Producto(IdProd.Trim(), Xcant);

                    }
                }
            }
            catch (Exception Ex)
            {
                string sms = Ex.Message;
                MessageBox.Show(sms);
            }
        }
        private void btn_procesar_Click(object sender, EventArgs e)
        {
            if (Validar_Compras() == true)
            {
                Registrar_Compra();
            }
        }
        bool recibiConforme = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                recibiConforme = true;
            }
            else
            {
                recibiConforme = false;
            }
        }

        private void bunifuThinButtonRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
