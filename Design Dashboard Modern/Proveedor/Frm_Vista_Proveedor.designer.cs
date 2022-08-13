namespace Design_Dashboard_Modern.Proveedor
{
    partial class  Frm_Vista_Proveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Vista_Proveedor));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_titu = new System.Windows.Forms.Panel();
            this.btn_minimi = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAgregarProveedor = new System.Windows.Forms.Button();
            this.buttonEditarProveedor = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.txt_buscar_proveedor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.listViewProveedor = new System.Windows.Forms.ListView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mostrarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarIDProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.pnl_titu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_titu
            // 
            this.pnl_titu.BackColor = System.Drawing.Color.DimGray;
            this.pnl_titu.Controls.Add(this.btn_minimi);
            this.pnl_titu.Controls.Add(this.btn_cerrar);
            this.pnl_titu.Controls.Add(this.label1);
            this.pnl_titu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_titu.Location = new System.Drawing.Point(0, 0);
            this.pnl_titu.Name = "pnl_titu";
            this.pnl_titu.Size = new System.Drawing.Size(1145, 43);
            this.pnl_titu.TabIndex = 0;
            this.pnl_titu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_titu_MouseMove);
            // 
            // btn_minimi
            // 
            this.btn_minimi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimi.FlatAppearance.BorderSize = 0;
            this.btn_minimi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_minimi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_minimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimi.ForeColor = System.Drawing.Color.White;
            this.btn_minimi.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimi.Image")));
            this.btn_minimi.Location = new System.Drawing.Point(1053, 4);
            this.btn_minimi.Name = "btn_minimi";
            this.btn_minimi.Size = new System.Drawing.Size(32, 32);
            this.btn_minimi.TabIndex = 7;
            this.btn_minimi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_minimi.UseVisualStyleBackColor = true;
            this.btn_minimi.Click += new System.EventHandler(this.btn_minimi_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1103, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(32, 32);
            this.btn_cerrar.TabIndex = 6;
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Explorador de Proveedores";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.buttonAgregarProveedor);
            this.panel1.Controls.Add(this.buttonEditarProveedor);
            this.panel1.Controls.Add(this.buttonBuscar);
            this.panel1.Controls.Add(this.txt_buscar_proveedor);
            this.panel1.Location = new System.Drawing.Point(1, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 47);
            this.panel1.TabIndex = 1;
            // 
            // buttonAgregarProveedor
            // 
            this.buttonAgregarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAgregarProveedor.FlatAppearance.BorderSize = 0;
            this.buttonAgregarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonAgregarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarProveedor.ForeColor = System.Drawing.Color.White;
            this.buttonAgregarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarProveedor.Image")));
            this.buttonAgregarProveedor.Location = new System.Drawing.Point(12, 7);
            this.buttonAgregarProveedor.Name = "buttonAgregarProveedor";
            this.buttonAgregarProveedor.Size = new System.Drawing.Size(32, 32);
            this.buttonAgregarProveedor.TabIndex = 13;
            this.buttonAgregarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonAgregarProveedor, "Agregar Proveedor");
            this.buttonAgregarProveedor.UseVisualStyleBackColor = true;
            this.buttonAgregarProveedor.Click += new System.EventHandler(this.buttonAgregarProveedor_Click);
            // 
            // buttonEditarProveedor
            // 
            this.buttonEditarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditarProveedor.FlatAppearance.BorderSize = 0;
            this.buttonEditarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonEditarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonEditarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarProveedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarProveedor.ForeColor = System.Drawing.Color.White;
            this.buttonEditarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarProveedor.Image")));
            this.buttonEditarProveedor.Location = new System.Drawing.Point(67, 7);
            this.buttonEditarProveedor.Name = "buttonEditarProveedor";
            this.buttonEditarProveedor.Size = new System.Drawing.Size(32, 32);
            this.buttonEditarProveedor.TabIndex = 12;
            this.buttonEditarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonEditarProveedor, "Eliminar Proveedor");
            this.buttonEditarProveedor.UseVisualStyleBackColor = true;
            this.buttonEditarProveedor.Click += new System.EventHandler(this.buttonEditarProveedor_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(1104, 8);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(32, 32);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // txt_buscar_proveedor
            // 
            this.txt_buscar_proveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_buscar_proveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_buscar_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_buscar_proveedor.HintForeColor = System.Drawing.Color.Empty;
            this.txt_buscar_proveedor.HintText = "";
            this.txt_buscar_proveedor.isPassword = false;
            this.txt_buscar_proveedor.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_buscar_proveedor.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_buscar_proveedor.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txt_buscar_proveedor.LineThickness = 3;
            this.txt_buscar_proveedor.Location = new System.Drawing.Point(801, 12);
            this.txt_buscar_proveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar_proveedor.Name = "txt_buscar_proveedor";
            this.txt_buscar_proveedor.Size = new System.Drawing.Size(340, 33);
            this.txt_buscar_proveedor.TabIndex = 10;
            this.txt_buscar_proveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_buscar_proveedor.OnValueChanged += new System.EventHandler(this.txt_buscar_proveedor_OnValueChanged);
            // 
            // listViewProveedor
            // 
            this.listViewProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProveedor.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewProveedor.HideSelection = false;
            this.listViewProveedor.Location = new System.Drawing.Point(12, 137);
            this.listViewProveedor.Name = "listViewProveedor";
            this.listViewProveedor.Size = new System.Drawing.Size(1125, 452);
            this.listViewProveedor.TabIndex = 9;
            this.listViewProveedor.UseCompatibleStateImageBehavior = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 116);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1123, 15);
            this.bunifuSeparator1.TabIndex = 8;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.mostrarTodosToolStripMenuItem,
            this.toolStripSeparator2,
            this.nuevoProveedorToolStripMenuItem,
            this.toolStripSeparator1,
            this.copiarIDProveedor,
            this.toolStripSeparator4});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 94);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // mostrarTodosToolStripMenuItem
            // 
            this.mostrarTodosToolStripMenuItem.Name = "mostrarTodosToolStripMenuItem";
            this.mostrarTodosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarTodosToolStripMenuItem.Text = "Editar Proveedor";
            this.mostrarTodosToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            this.nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            this.nuevoProveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoProveedorToolStripMenuItem.Text = "Nuevo Proveedor ";
            this.nuevoProveedorToolStripMenuItem.Click += new System.EventHandler(this.nuevoProveedorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // copiarIDProveedor
            // 
            this.copiarIDProveedor.Name = "copiarIDProveedor";
            this.copiarIDProveedor.Size = new System.Drawing.Size(180, 22);
            this.copiarIDProveedor.Text = "Copiar ID Proveedor";
            this.copiarIDProveedor.Click += new System.EventHandler(this.copiarIDProveedor_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // Frm_Vista_Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 601);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.listViewProveedor);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_titu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Vista_Proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explorador de Productos";
            this.Load += new System.EventHandler(this.Frm_Explo_Prod_Load);
            this.pnl_titu.ResumeLayout(false);
            this.pnl_titu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnl_titu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_minimi;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_buscar_proveedor;
        private System.Windows.Forms.ListView listViewProveedor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAgregarProveedor;
        private System.Windows.Forms.Button buttonEditarProveedor;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem nuevoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarIDProveedor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}