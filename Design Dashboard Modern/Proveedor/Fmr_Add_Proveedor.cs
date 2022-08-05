using System;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;


//pasar los da tos
namespace Design_Dashboard_Modern.Proveedor
{
    public partial class Fmr_Add_Proveedor : Form
    {
        public Fmr_Add_Proveedor()
        {
            InitializeComponent();
        }
        private void Fmr_Add_Proveedor_Load(object sender, EventArgs e)
        {
            textIDproveedor.Text = RN_Tipo_Documento.RN_Numero_ID(5);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        string xFortoruta;

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
        
        private void Registrar_Proveedor()
        {

            try
            {
                RN_Proveedor ProVee = new RN_Proveedor();
                EN_Proveedor ProReg = new EN_Proveedor();

                ProReg.Idproveedor = textIDproveedor.Text;
                ProReg.Nombre = textNombreProveedor.Text;
                ProReg.Direccion = textDictProveedor.Text;
                ProReg.Telefono = textTelProveedor.Text;
                ProReg.Rubro = textRubroProveedor.Text;
                ProReg.Ruc = textDNIProveedor.Text;
                ProReg.Correo = textCorreo.Text;
                ProReg.Contacto = textContacto.Text;
                ProReg.Fotologo = xFortoruta;


                ProVee.RN_Insertar_Proveedor(ProReg);

                Limpiar_TextBox();
                this.Tag = "A";
                this.Close();
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
                Registrar_Proveedor();
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Limpiar_TextBox();
        }

        
    }
}
