namespace Design_Dashboard_Modern.Cliente
{    
    partial class Frm_Explo_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Explo_Clientes));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_titu = new System.Windows.Forms.Panel();
            this.btn_minimi = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewCliente = new System.Windows.Forms.ListView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonEditarCliente = new System.Windows.Forms.Button();
            this.buttonAgregarCliente = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mostrarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarIDProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_buscar_Clientes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PanelResult = new System.Windows.Forms.Panel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TotalItems = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.pnl_titu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.PanelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.pnl_titu.Size = new System.Drawing.Size(1059, 43);
            this.pnl_titu.TabIndex = 0;
            this.pnl_titu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_titu_MouseDown);
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
            this.btn_minimi.Location = new System.Drawing.Point(967, 4);
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
            this.btn_cerrar.Location = new System.Drawing.Point(1017, 4);
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
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Explorador de Clientes";
            // 
            // listViewCliente
            // 
            this.listViewCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewCliente.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewCliente.HideSelection = false;
            this.listViewCliente.Location = new System.Drawing.Point(12, 128);
            this.listViewCliente.Name = "listViewCliente";
            this.listViewCliente.Size = new System.Drawing.Size(1037, 465);
            this.listViewCliente.TabIndex = 9;
            this.listViewCliente.UseCompatibleStateImageBehavior = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // buttonEditarCliente
            // 
            this.buttonEditarCliente.FlatAppearance.BorderSize = 0;
            this.buttonEditarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonEditarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditarCliente.ForeColor = System.Drawing.Color.White;
            this.buttonEditarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditarCliente.Image")));
            this.buttonEditarCliente.Location = new System.Drawing.Point(52, 7);
            this.buttonEditarCliente.Name = "buttonEditarCliente";
            this.buttonEditarCliente.Size = new System.Drawing.Size(32, 32);
            this.buttonEditarCliente.TabIndex = 14;
            this.buttonEditarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonEditarCliente, "Editar Cliente");
            this.buttonEditarCliente.UseVisualStyleBackColor = true;
            this.buttonEditarCliente.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonAgregarCliente
            // 
            this.buttonAgregarCliente.FlatAppearance.BorderSize = 0;
            this.buttonAgregarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonAgregarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.buttonAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregarCliente.Image")));
            this.buttonAgregarCliente.Location = new System.Drawing.Point(8, 7);
            this.buttonAgregarCliente.Name = "buttonAgregarCliente";
            this.buttonAgregarCliente.Size = new System.Drawing.Size(32, 32);
            this.buttonAgregarCliente.TabIndex = 13;
            this.buttonAgregarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.buttonAgregarCliente, "Agregar Cliente");
            this.buttonAgregarCliente.UseVisualStyleBackColor = true;
            this.buttonAgregarCliente.Click += new System.EventHandler(this.buttonAgregarProducto_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 102);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1042, 20);
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
            this.toolStripSeparator4,
            this.eliminarClientesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 116);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(165, 6);
            // 
            // mostrarTodosToolStripMenuItem
            // 
            this.mostrarTodosToolStripMenuItem.Name = "mostrarTodosToolStripMenuItem";
            this.mostrarTodosToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.mostrarTodosToolStripMenuItem.Text = "Editar Clienes";
            this.mostrarTodosToolStripMenuItem.Click += new System.EventHandler(this.mostrarTodosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(165, 6);
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            this.nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            this.nuevoProveedorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nuevoProveedorToolStripMenuItem.Text = "Nuevo Clientes";
            this.nuevoProveedorToolStripMenuItem.Click += new System.EventHandler(this.nuevoProveedorToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // copiarIDProveedor
            // 
            this.copiarIDProveedor.Name = "copiarIDProveedor";
            this.copiarIDProveedor.Size = new System.Drawing.Size(168, 22);
            this.copiarIDProveedor.Text = "Copiar ID Clientes";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(165, 6);
            // 
            // eliminarClientesToolStripMenuItem
            // 
            this.eliminarClientesToolStripMenuItem.Name = "eliminarClientesToolStripMenuItem";
            this.eliminarClientesToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.eliminarClientesToolStripMenuItem.Text = "Eliminar Clientes";
            this.eliminarClientesToolStripMenuItem.Click += new System.EventHandler(this.eliminarClientesToolStripMenuItem_Click);
            // 
            // BunifuElipse2
            // 
            this.BunifuElipse2.ElipseRadius = 30;
            this.BunifuElipse2.TargetControl = this.txt_buscar_Clientes;
            // 
            // txt_buscar_Clientes
            // 
            this.txt_buscar_Clientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar_Clientes.BackColor = System.Drawing.Color.LightGray;
            this.txt_buscar_Clientes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_buscar_Clientes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_buscar_Clientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_buscar_Clientes.HintForeColor = System.Drawing.Color.Empty;
            this.txt_buscar_Clientes.HintText = "";
            this.txt_buscar_Clientes.isPassword = false;
            this.txt_buscar_Clientes.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_buscar_Clientes.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_buscar_Clientes.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txt_buscar_Clientes.LineThickness = 3;
            this.txt_buscar_Clientes.Location = new System.Drawing.Point(726, 10);
            this.txt_buscar_Clientes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar_Clientes.Name = "txt_buscar_Clientes";
            this.txt_buscar_Clientes.Size = new System.Drawing.Size(327, 33);
            this.txt_buscar_Clientes.TabIndex = 10;
            this.txt_buscar_Clientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_buscar_Clientes.OnValueChanged += new System.EventHandler(this.txt_buscar_proveedor_OnValueChanged);
            this.txt_buscar_Clientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_Clientes_KeyDown);
            // 
            // PanelResult
            // 
            this.PanelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelResult.Controls.Add(this.bunifuSeparator2);
            this.PanelResult.Controls.Add(this.pictureBox1);
            this.PanelResult.Controls.Add(this.label7);
            this.PanelResult.Controls.Add(this.label6);
            this.PanelResult.Location = new System.Drawing.Point(1, 102);
            this.PanelResult.Name = "PanelResult";
            this.PanelResult.Size = new System.Drawing.Size(1058, 519);
            this.PanelResult.TabIndex = 14;
            this.PanelResult.Visible = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(42, 337);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(958, 35);
            this.bunifuSeparator2.TabIndex = 3;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(463, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(309, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(453, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Intenta Realizar una Busqueda Con Valores";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(361, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 36);
            this.label6.TabIndex = 0;
            this.label6.Text = "Busqueda Sin Repuesta";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total de Items";
            // 
            // lbl_TotalItems
            // 
            this.lbl_TotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TotalItems.Location = new System.Drawing.Point(610, 25);
            this.lbl_TotalItems.Name = "lbl_TotalItems";
            this.lbl_TotalItems.Size = new System.Drawing.Size(74, 13);
            this.lbl_TotalItems.TabIndex = 16;
            this.lbl_TotalItems.Text = "00";
            this.lbl_TotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lbl_TotalItems);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonEditarCliente);
            this.panel1.Controls.Add(this.buttonAgregarCliente);
            this.panel1.Controls.Add(this.buttonBuscar);
            this.panel1.Controls.Add(this.txt_buscar_Clientes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 47);
            this.panel1.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.BackColor = System.Drawing.Color.LightGray;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.buttonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(1014, 12);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(32, 28);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // Frm_Explo_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 614);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.PanelResult);
            this.Controls.Add(this.listViewCliente);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_titu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Explo_Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Frm_Explo_Prod_Load);
            this.pnl_titu.ResumeLayout(false);
            this.pnl_titu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.PanelResult.ResumeLayout(false);
            this.PanelResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    private System.Windows.Forms.Panel pnl_titu;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btn_cerrar;
    private System.Windows.Forms.Button btn_minimi;
    private System.Windows.Forms.ListView listViewCliente;
    private System.Windows.Forms.ToolTip toolTip1;
    private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mostrarTodosToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem nuevoProveedorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copiarIDProveedor;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private Bunifu.Framework.UI.BunifuElipse BunifuElipse2;
    private System.Windows.Forms.Panel PanelResult;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.PictureBox pictureBox1;
    private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.ToolStripMenuItem eliminarClientesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_TotalItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEditarCliente;
        private System.Windows.Forms.Button buttonAgregarCliente;
        private System.Windows.Forms.Button buttonBuscar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_buscar_Clientes;
    }
}