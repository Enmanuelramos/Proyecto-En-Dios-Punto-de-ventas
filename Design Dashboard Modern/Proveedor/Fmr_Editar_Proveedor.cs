using System;
using System.Data;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;


//pasar los da tos
namespace Design_Dashboard_Modern.Proveedor
{
    public partial class Fmr_Editar_Proveedor : Form
    {
        public Fmr_Editar_Proveedor()
        {
            InitializeComponent();
        }
        private void Fmr_Add_Proveedor_Load(object sender, EventArgs e)
        {
            textIDproveedor.Text = RN_Tipo_Documento.RN_Numero_ID(5);
            Buscar_proveedor_Para_Editar(this.Tag.ToString());
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "A";
            this.Close();
        }

        string xFortoruta = "";

        //listo
        private void lbl_Abrir_Click(object sender, EventArgs e)
        {
           var FilePath = string.Empty;

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    xFortoruta = openFileDialog1.FileName;
                    PictIMGProduct.Load(xFortoruta); 
                }
                
            }
            catch (Exception Ex)
            {
                //esto es para cargar una imagen por defecto 
                PictIMGProduct.Load(Application.StartupPath + @"\Captura.png"); // ojo no se quiere cargar la imagen por defecto
                xFortoruta = Application.StartupPath + @"\Captura.png";

                MessageBox.Show("Error al cargar la imagen" + Ex.Message);
            }
            
        }

        private bool Validar_Caja_Texto()
        {
            Frm_Filtro Filtro = new Frm_Filtro();

            if (textIDproveedor.Text == string.Empty)
            {
                Filtro.Show();
                MessageBox.Show("Ingrese el ID de Proveedor" , "Proveedor ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Filtro.Hide();
                return false;
            }
            if (textNombreProveedor.Text == string.Empty)
            {
                Filtro.Show();
                MessageBox.Show("Ingrese el Nombre Proveedor", "Proveedor ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Filtro.Hide();
                textNombreProveedor.Focus();
                return false;
            }
            if (textDictProveedor.Text.Trim().Length < 2)
            {
                Filtro.Show();
                MessageBox.Show("Ingrese La Direccion Proveedor", "Proveedor ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Filtro.Hide();
                return false;
            }
            if (textTelProveedor.Text == string.Empty)
            {
                Filtro.Show();
                MessageBox.Show("Ingrese El Telefono del Proveedor", "Proveedor ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Filtro.Hide();
                return false;
            }
            if (textRubroProveedor.Text == string.Empty)
            {
                Filtro.Show();
                MessageBox.Show("Ingrese Rubro", "Proveedor ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Filtro.Hide();
                return false;
            }
            if (textDNIProveedor.Text == string.Empty)
            {
                Filtro.Show();
                MessageBox.Show("Ingrese el DNI del Proveedor", "Proveedor ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Filtro.Hide();
                return false;
            }
            if (textCorreo.Text == string.Empty)
            {
                Filtro.Show();
                MessageBox.Show("Ingrese el Correo del Proveedor", "Proveedor ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Filtro.Hide();

                return false;
                }
            if (textContacto.Text == string.Empty)
            {
                Filtro.Show();
                MessageBox.Show("Ingrese el Nombre del Contacto Proveedor", "Proveedor ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Filtro.Hide();

                return false;
            }
            return true;

        }

        private void Editar_Proveedor()

        {
            try
            {
               EN_Proveedor ProReg = new EN_Proveedor();
               RN_Proveedor ProVee = new RN_Proveedor();

                ProReg.Idproveedor = textIDproveedor.Text;
                ProReg.Nombre = textNombreProveedor.Text;
                ProReg.Direccion = textDictProveedor.Text;
                ProReg.Telefono = textTelProveedor.Text;
                ProReg.Rubro = textRubroProveedor.Text;
                ProReg.Ruc = textDNIProveedor.Text;
                ProReg.Correo = textCorreo.Text;
                ProReg.Contacto = textContacto.Text;
                ProReg.Fotologo = xFortoruta;

                ProVee.RN_Modificar_Proveedor(ProReg);

                Limpiar_TextBox();
                this.Tag = "A";
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No Se Registro Corectamente el Proveedor" + Ex.Message, "Registrar_Proveedor Fmr_Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        private void Buscar_proveedor_Para_Editar(string idPro)
        {
            RN_Proveedor Obj = new RN_Proveedor();
            DataTable data = new DataTable();

            try
            {
                data = Obj.RN_Buscar_Proveerdor(idPro);
                if (data.Rows.Count > 0)
                {
                    //estamos trabajando con matrices fila y columna, columna 0 y fila corespondiente
                    textIDproveedor.Text = Convert.ToString(data.Rows[0]["IDPROVEE"]);
                    textNombreProveedor.Text = Convert.ToString(data.Rows[0]["NOMBRE"]);
                    textDictProveedor.Text = Convert.ToString(data.Rows[0]["DIRECCION"]);
                    textTelProveedor.Text = Convert.ToString(data.Rows[0]["TELEFONO"]);
                    textRubroProveedor.Text = Convert.ToString(data.Rows[0]["RUBRO"]);
                    textDNIProveedor.Text = Convert.ToString(data.Rows[0]["RUC"]);
                    textCorreo.Text = Convert.ToString(data.Rows[0]["CORREO"]);
                    textContacto.Text = Convert.ToString(data.Rows[0]["CONTACTO"]);
                    xFortoruta = Convert.ToString(data.Rows[0]["FOTO_LOGO"]);

                    PictIMGProduct.Load(xFortoruta); // esto es para cargar la imagen osea la ruta donde esta la imagen guardada
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("No Se Registro Corectamente el Proveedor" + Ex.Message, "Registrar_Proveedor Fmr_Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        public void Limpiar_TextBox()
        {
            textIDproveedor.Text = " ";
            textNombreProveedor.Text = " ";
            textDictProveedor.Text = " ";
            textTelProveedor.Text = " ";
            textRubroProveedor.Text = " ";
            textDNIProveedor.Text = " ";
            textCorreo.Text = " ";
            textContacto.Text = " ";
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (Validar_Caja_Texto() == true)
            {
                Editar_Proveedor();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Limpiar_TextBox();
        }

        
    }
}
