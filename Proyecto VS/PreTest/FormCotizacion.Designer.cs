
namespace PreTest
{
    partial class FormCotizacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TitleContainer = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TiendaContainer = new System.Windows.Forms.Panel();
            this.TiendaDireccionText = new System.Windows.Forms.Label();
            this.TiendaNombreText = new System.Windows.Forms.Label();
            this.VendedorContainer = new System.Windows.Forms.Panel();
            this.CotizacionesHistorialLink = new System.Windows.Forms.LinkLabel();
            this.VendedorInfoText = new System.Windows.Forms.Label();
            this.CotizacionContainer = new System.Windows.Forms.Panel();
            this.CotizadorInnerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CotizacionMontoText = new System.Windows.Forms.Label();
            this.CotizacionMontoLabel = new System.Windows.Forms.Label();
            this.CotizarButton = new System.Windows.Forms.Button();
            this.PrendaCalidadPrecioContainer = new System.Windows.Forms.SplitContainer();
            this.PrendaCalidadPremiumToggle = new System.Windows.Forms.RadioButton();
            this.PrendaCalidadLabel = new System.Windows.Forms.Label();
            this.PrendaCalidadStandardToggle = new System.Windows.Forms.RadioButton();
            this.PrendaCantidadInputText = new System.Windows.Forms.TextBox();
            this.PrendaCantidadLabel = new System.Windows.Forms.Label();
            this.PrendaPrecioLabel = new System.Windows.Forms.Label();
            this.PrendaPrecioInputText = new System.Windows.Forms.TextBox();
            this.PrendaPrecioTiitleLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PrendaStockText = new System.Windows.Forms.Label();
            this.PrendaStockLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PantalonChupinBox = new System.Windows.Forms.CheckBox();
            this.CamisaCuelloMaoBox = new System.Windows.Forms.CheckBox();
            this.CamisaMangaCortaBox = new System.Windows.Forms.CheckBox();
            this.PantalonToggle = new System.Windows.Forms.RadioButton();
            this.CamisaToggle = new System.Windows.Forms.RadioButton();
            this.PrendaTitleLabel = new System.Windows.Forms.Label();
            this.TitleContainer.SuspendLayout();
            this.TiendaContainer.SuspendLayout();
            this.VendedorContainer.SuspendLayout();
            this.CotizacionContainer.SuspendLayout();
            this.CotizadorInnerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrendaCalidadPrecioContainer)).BeginInit();
            this.PrendaCalidadPrecioContainer.Panel1.SuspendLayout();
            this.PrendaCalidadPrecioContainer.Panel2.SuspendLayout();
            this.PrendaCalidadPrecioContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleContainer
            // 
            this.TitleContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TitleContainer.Controls.Add(this.TitleLabel);
            this.TitleContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleContainer.Location = new System.Drawing.Point(0, 0);
            this.TitleContainer.Name = "TitleContainer";
            this.TitleContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleContainer.Size = new System.Drawing.Size(727, 66);
            this.TitleContainer.TabIndex = 0;
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.SystemColors.Highlight;
            this.TitleLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(727, 66);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Cotizador Express";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TiendaContainer
            // 
            this.TiendaContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TiendaContainer.Controls.Add(this.TiendaDireccionText);
            this.TiendaContainer.Controls.Add(this.TiendaNombreText);
            this.TiendaContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.TiendaContainer.Location = new System.Drawing.Point(0, 66);
            this.TiendaContainer.Name = "TiendaContainer";
            this.TiendaContainer.Size = new System.Drawing.Size(727, 40);
            this.TiendaContainer.TabIndex = 1;
            // 
            // TiendaDireccionText
            // 
            this.TiendaDireccionText.AutoSize = true;
            this.TiendaDireccionText.Dock = System.Windows.Forms.DockStyle.Right;
            this.TiendaDireccionText.Location = new System.Drawing.Point(582, 0);
            this.TiendaDireccionText.Name = "TiendaDireccionText";
            this.TiendaDireccionText.Padding = new System.Windows.Forms.Padding(10);
            this.TiendaDireccionText.Size = new System.Drawing.Size(143, 35);
            this.TiendaDireccionText.TabIndex = 1;
            this.TiendaDireccionText.Text = "Dirección de la Tienda";
            this.TiendaDireccionText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TiendaNombreText
            // 
            this.TiendaNombreText.AutoSize = true;
            this.TiendaNombreText.Dock = System.Windows.Forms.DockStyle.Left;
            this.TiendaNombreText.Location = new System.Drawing.Point(0, 0);
            this.TiendaNombreText.Name = "TiendaNombreText";
            this.TiendaNombreText.Padding = new System.Windows.Forms.Padding(10);
            this.TiendaNombreText.Size = new System.Drawing.Size(109, 35);
            this.TiendaNombreText.TabIndex = 0;
            this.TiendaNombreText.Text = "Nombre Tienda";
            this.TiendaNombreText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VendedorContainer
            // 
            this.VendedorContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VendedorContainer.Controls.Add(this.CotizacionesHistorialLink);
            this.VendedorContainer.Controls.Add(this.VendedorInfoText);
            this.VendedorContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.VendedorContainer.Location = new System.Drawing.Point(0, 106);
            this.VendedorContainer.Name = "VendedorContainer";
            this.VendedorContainer.Size = new System.Drawing.Size(727, 40);
            this.VendedorContainer.TabIndex = 2;
            // 
            // CotizacionesHistorialLink
            // 
            this.CotizacionesHistorialLink.AutoSize = true;
            this.CotizacionesHistorialLink.Dock = System.Windows.Forms.DockStyle.Right;
            this.CotizacionesHistorialLink.Location = new System.Drawing.Point(584, 0);
            this.CotizacionesHistorialLink.Name = "CotizacionesHistorialLink";
            this.CotizacionesHistorialLink.Padding = new System.Windows.Forms.Padding(10);
            this.CotizacionesHistorialLink.Size = new System.Drawing.Size(141, 35);
            this.CotizacionesHistorialLink.TabIndex = 1;
            this.CotizacionesHistorialLink.TabStop = true;
            this.CotizacionesHistorialLink.Text = "Historial Cotizaciones";
            this.CotizacionesHistorialLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CotizacionesHistorialLink_LinkClicked);
            // 
            // VendedorInfoText
            // 
            this.VendedorInfoText.AutoSize = true;
            this.VendedorInfoText.Dock = System.Windows.Forms.DockStyle.Left;
            this.VendedorInfoText.Location = new System.Drawing.Point(0, 0);
            this.VendedorInfoText.Name = "VendedorInfoText";
            this.VendedorInfoText.Padding = new System.Windows.Forms.Padding(10);
            this.VendedorInfoText.Size = new System.Drawing.Size(281, 35);
            this.VendedorInfoText.TabIndex = 0;
            this.VendedorInfoText.Text = "Nombre y Apellido Vendedor | Código Vendedor";
            this.VendedorInfoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CotizacionContainer
            // 
            this.CotizacionContainer.Controls.Add(this.CotizadorInnerPanel);
            this.CotizacionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CotizacionContainer.Location = new System.Drawing.Point(0, 146);
            this.CotizacionContainer.Name = "CotizacionContainer";
            this.CotizacionContainer.Size = new System.Drawing.Size(727, 405);
            this.CotizacionContainer.TabIndex = 3;
            // 
            // CotizadorInnerPanel
            // 
            this.CotizadorInnerPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CotizadorInnerPanel.Controls.Add(this.panel1);
            this.CotizadorInnerPanel.Controls.Add(this.PrendaCalidadPrecioContainer);
            this.CotizadorInnerPanel.Controls.Add(this.panel3);
            this.CotizadorInnerPanel.Controls.Add(this.panel2);
            this.CotizadorInnerPanel.Controls.Add(this.PrendaTitleLabel);
            this.CotizadorInnerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CotizadorInnerPanel.Location = new System.Drawing.Point(0, 0);
            this.CotizadorInnerPanel.Name = "CotizadorInnerPanel";
            this.CotizadorInnerPanel.Padding = new System.Windows.Forms.Padding(30);
            this.CotizadorInnerPanel.Size = new System.Drawing.Size(727, 405);
            this.CotizadorInnerPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CotizacionMontoText);
            this.panel1.Controls.Add(this.CotizacionMontoLabel);
            this.panel1.Controls.Add(this.CotizarButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(30, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 100);
            this.panel1.TabIndex = 3;
            // 
            // CotizacionMontoText
            // 
            this.CotizacionMontoText.AutoSize = true;
            this.CotizacionMontoText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CotizacionMontoText.Location = new System.Drawing.Point(299, 27);
            this.CotizacionMontoText.Name = "CotizacionMontoText";
            this.CotizacionMontoText.Size = new System.Drawing.Size(293, 45);
            this.CotizacionMontoText.TabIndex = 2;
            this.CotizacionMontoText.Text = "_____________________";
            // 
            // CotizacionMontoLabel
            // 
            this.CotizacionMontoLabel.AutoSize = true;
            this.CotizacionMontoLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CotizacionMontoLabel.Location = new System.Drawing.Point(243, 27);
            this.CotizacionMontoLabel.Name = "CotizacionMontoLabel";
            this.CotizacionMontoLabel.Size = new System.Drawing.Size(37, 45);
            this.CotizacionMontoLabel.TabIndex = 1;
            this.CotizacionMontoLabel.Text = "$";
            // 
            // CotizarButton
            // 
            this.CotizarButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CotizarButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CotizarButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.CotizarButton.Location = new System.Drawing.Point(17, 24);
            this.CotizarButton.Name = "CotizarButton";
            this.CotizarButton.Size = new System.Drawing.Size(180, 54);
            this.CotizarButton.TabIndex = 0;
            this.CotizarButton.Text = "Cotizar";
            this.CotizarButton.UseVisualStyleBackColor = false;
            this.CotizarButton.Click += new System.EventHandler(this.CotizarButton_Click);
            // 
            // PrendaCalidadPrecioContainer
            // 
            this.PrendaCalidadPrecioContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrendaCalidadPrecioContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrendaCalidadPrecioContainer.Location = new System.Drawing.Point(30, 186);
            this.PrendaCalidadPrecioContainer.Name = "PrendaCalidadPrecioContainer";
            // 
            // PrendaCalidadPrecioContainer.Panel1
            // 
            this.PrendaCalidadPrecioContainer.Panel1.Controls.Add(this.PrendaCalidadPremiumToggle);
            this.PrendaCalidadPrecioContainer.Panel1.Controls.Add(this.PrendaCalidadLabel);
            this.PrendaCalidadPrecioContainer.Panel1.Controls.Add(this.PrendaCalidadStandardToggle);
            this.PrendaCalidadPrecioContainer.Panel1MinSize = 250;
            // 
            // PrendaCalidadPrecioContainer.Panel2
            // 
            this.PrendaCalidadPrecioContainer.Panel2.Controls.Add(this.PrendaCantidadInputText);
            this.PrendaCalidadPrecioContainer.Panel2.Controls.Add(this.PrendaCantidadLabel);
            this.PrendaCalidadPrecioContainer.Panel2.Controls.Add(this.PrendaPrecioLabel);
            this.PrendaCalidadPrecioContainer.Panel2.Controls.Add(this.PrendaPrecioInputText);
            this.PrendaCalidadPrecioContainer.Panel2.Controls.Add(this.PrendaPrecioTiitleLabel);
            this.PrendaCalidadPrecioContainer.Panel2MinSize = 250;
            this.PrendaCalidadPrecioContainer.Size = new System.Drawing.Size(667, 71);
            this.PrendaCalidadPrecioContainer.SplitterDistance = 277;
            this.PrendaCalidadPrecioContainer.SplitterWidth = 10;
            this.PrendaCalidadPrecioContainer.TabIndex = 2;
            // 
            // PrendaCalidadPremiumToggle
            // 
            this.PrendaCalidadPremiumToggle.AutoSize = true;
            this.PrendaCalidadPremiumToggle.Location = new System.Drawing.Point(114, 27);
            this.PrendaCalidadPremiumToggle.Name = "PrendaCalidadPremiumToggle";
            this.PrendaCalidadPremiumToggle.Size = new System.Drawing.Size(74, 19);
            this.PrendaCalidadPremiumToggle.TabIndex = 2;
            this.PrendaCalidadPremiumToggle.TabStop = true;
            this.PrendaCalidadPremiumToggle.Text = "Premium";
            this.PrendaCalidadPremiumToggle.UseVisualStyleBackColor = true;
            this.PrendaCalidadPremiumToggle.CheckedChanged += new System.EventHandler(this.PrendaCalidadPremiumToggle_CheckedChanged);
            // 
            // PrendaCalidadLabel
            // 
            this.PrendaCalidadLabel.AutoSize = true;
            this.PrendaCalidadLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrendaCalidadLabel.Location = new System.Drawing.Point(0, 0);
            this.PrendaCalidadLabel.Name = "PrendaCalidadLabel";
            this.PrendaCalidadLabel.Size = new System.Drawing.Size(103, 15);
            this.PrendaCalidadLabel.TabIndex = 1;
            this.PrendaCalidadLabel.Text = "Calidad de Prenda";
            // 
            // PrendaCalidadStandardToggle
            // 
            this.PrendaCalidadStandardToggle.AutoSize = true;
            this.PrendaCalidadStandardToggle.Location = new System.Drawing.Point(17, 27);
            this.PrendaCalidadStandardToggle.Name = "PrendaCalidadStandardToggle";
            this.PrendaCalidadStandardToggle.Size = new System.Drawing.Size(72, 19);
            this.PrendaCalidadStandardToggle.TabIndex = 0;
            this.PrendaCalidadStandardToggle.TabStop = true;
            this.PrendaCalidadStandardToggle.Text = "Standard";
            this.PrendaCalidadStandardToggle.UseVisualStyleBackColor = true;
            this.PrendaCalidadStandardToggle.CheckedChanged += new System.EventHandler(this.PrendaCalidadStandardToggle_CheckedChanged);
            // 
            // PrendaCantidadInputText
            // 
            this.PrendaCantidadInputText.Location = new System.Drawing.Point(209, 26);
            this.PrendaCantidadInputText.Name = "PrendaCantidadInputText";
            this.PrendaCantidadInputText.Size = new System.Drawing.Size(100, 23);
            this.PrendaCantidadInputText.TabIndex = 4;
            this.PrendaCantidadInputText.TextChanged += new System.EventHandler(this.PrendaCantidadInputText_TextChanged);
            // 
            // PrendaCantidadLabel
            // 
            this.PrendaCantidadLabel.AutoSize = true;
            this.PrendaCantidadLabel.Location = new System.Drawing.Point(148, 29);
            this.PrendaCantidadLabel.Name = "PrendaCantidadLabel";
            this.PrendaCantidadLabel.Size = new System.Drawing.Size(55, 15);
            this.PrendaCantidadLabel.TabIndex = 3;
            this.PrendaCantidadLabel.Text = "Cantidad";
            // 
            // PrendaPrecioLabel
            // 
            this.PrendaPrecioLabel.AutoSize = true;
            this.PrendaPrecioLabel.Location = new System.Drawing.Point(7, 31);
            this.PrendaPrecioLabel.Name = "PrendaPrecioLabel";
            this.PrendaPrecioLabel.Size = new System.Drawing.Size(13, 15);
            this.PrendaPrecioLabel.TabIndex = 2;
            this.PrendaPrecioLabel.Text = "$";
            // 
            // PrendaPrecioInputText
            // 
            this.PrendaPrecioInputText.Location = new System.Drawing.Point(26, 26);
            this.PrendaPrecioInputText.Name = "PrendaPrecioInputText";
            this.PrendaPrecioInputText.Size = new System.Drawing.Size(100, 23);
            this.PrendaPrecioInputText.TabIndex = 1;
            this.PrendaPrecioInputText.TextChanged += new System.EventHandler(this.PrendaPrecioInputText_TextChanged);
            // 
            // PrendaPrecioTiitleLabel
            // 
            this.PrendaPrecioTiitleLabel.AutoSize = true;
            this.PrendaPrecioTiitleLabel.Location = new System.Drawing.Point(3, 0);
            this.PrendaPrecioTiitleLabel.Name = "PrendaPrecioTiitleLabel";
            this.PrendaPrecioTiitleLabel.Size = new System.Drawing.Size(142, 15);
            this.PrendaPrecioTiitleLabel.TabIndex = 0;
            this.PrendaPrecioTiitleLabel.Text = "Precio unitario y cantidad";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.PrendaStockText);
            this.panel3.Controls.Add(this.PrendaStockLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(30, 130);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 56);
            this.panel3.TabIndex = 1;
            // 
            // PrendaStockText
            // 
            this.PrendaStockText.AutoSize = true;
            this.PrendaStockText.Location = new System.Drawing.Point(192, 21);
            this.PrendaStockText.Name = "PrendaStockText";
            this.PrendaStockText.Size = new System.Drawing.Size(37, 15);
            this.PrendaStockText.TabIndex = 1;
            this.PrendaStockText.Text = "______";
            // 
            // PrendaStockLabel
            // 
            this.PrendaStockLabel.AutoSize = true;
            this.PrendaStockLabel.Location = new System.Drawing.Point(17, 21);
            this.PrendaStockLabel.Name = "PrendaStockLabel";
            this.PrendaStockLabel.Size = new System.Drawing.Size(169, 15);
            this.PrendaStockLabel.TabIndex = 0;
            this.PrendaStockLabel.Text = "Unidades de stock disponibles:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PantalonChupinBox);
            this.panel2.Controls.Add(this.CamisaCuelloMaoBox);
            this.panel2.Controls.Add(this.CamisaMangaCortaBox);
            this.panel2.Controls.Add(this.PantalonToggle);
            this.panel2.Controls.Add(this.CamisaToggle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(30, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 100);
            this.panel2.TabIndex = 0;
            // 
            // PantalonChupinBox
            // 
            this.PantalonChupinBox.AutoSize = true;
            this.PantalonChupinBox.Location = new System.Drawing.Point(185, 63);
            this.PantalonChupinBox.Name = "PantalonChupinBox";
            this.PantalonChupinBox.Size = new System.Drawing.Size(65, 19);
            this.PantalonChupinBox.TabIndex = 5;
            this.PantalonChupinBox.Text = "Chupín";
            this.PantalonChupinBox.UseVisualStyleBackColor = true;
            this.PantalonChupinBox.CheckedChanged += new System.EventHandler(this.PantalonChupinBox_CheckedChanged);
            // 
            // CamisaCuelloMaoBox
            // 
            this.CamisaCuelloMaoBox.AutoSize = true;
            this.CamisaCuelloMaoBox.Location = new System.Drawing.Point(329, 17);
            this.CamisaCuelloMaoBox.Name = "CamisaCuelloMaoBox";
            this.CamisaCuelloMaoBox.Size = new System.Drawing.Size(87, 19);
            this.CamisaCuelloMaoBox.TabIndex = 4;
            this.CamisaCuelloMaoBox.Text = "Cuello Mao";
            this.CamisaCuelloMaoBox.UseVisualStyleBackColor = true;
            this.CamisaCuelloMaoBox.CheckedChanged += new System.EventHandler(this.CamisaCuelloMaoBox_CheckedChanged);
            // 
            // CamisaMangaCortaBox
            // 
            this.CamisaMangaCortaBox.AutoSize = true;
            this.CamisaMangaCortaBox.Location = new System.Drawing.Point(185, 17);
            this.CamisaMangaCortaBox.Name = "CamisaMangaCortaBox";
            this.CamisaMangaCortaBox.Size = new System.Drawing.Size(95, 19);
            this.CamisaMangaCortaBox.TabIndex = 3;
            this.CamisaMangaCortaBox.Text = "Manga Corta";
            this.CamisaMangaCortaBox.UseVisualStyleBackColor = true;
            this.CamisaMangaCortaBox.CheckedChanged += new System.EventHandler(this.CamisaMangaCortaBox_CheckedChanged);
            // 
            // PantalonToggle
            // 
            this.PantalonToggle.AutoSize = true;
            this.PantalonToggle.Location = new System.Drawing.Point(17, 62);
            this.PantalonToggle.Name = "PantalonToggle";
            this.PantalonToggle.Size = new System.Drawing.Size(72, 19);
            this.PantalonToggle.TabIndex = 2;
            this.PantalonToggle.Text = "Pantalón";
            this.PantalonToggle.UseVisualStyleBackColor = true;
            this.PantalonToggle.CheckedChanged += new System.EventHandler(this.PantalonToggle_CheckedChanged);
            // 
            // CamisaToggle
            // 
            this.CamisaToggle.AutoSize = true;
            this.CamisaToggle.Location = new System.Drawing.Point(17, 17);
            this.CamisaToggle.Name = "CamisaToggle";
            this.CamisaToggle.Size = new System.Drawing.Size(64, 19);
            this.CamisaToggle.TabIndex = 1;
            this.CamisaToggle.Text = "Camisa";
            this.CamisaToggle.UseVisualStyleBackColor = true;
            this.CamisaToggle.CheckedChanged += new System.EventHandler(this.CamisaToggle_CheckedChanged);
            // 
            // PrendaTitleLabel
            // 
            this.PrendaTitleLabel.AutoSize = true;
            this.PrendaTitleLabel.Location = new System.Drawing.Point(30, 12);
            this.PrendaTitleLabel.Name = "PrendaTitleLabel";
            this.PrendaTitleLabel.Size = new System.Drawing.Size(44, 15);
            this.PrendaTitleLabel.TabIndex = 0;
            this.PrendaTitleLabel.Text = "Prenda";
            // 
            // FormCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 551);
            this.Controls.Add(this.CotizacionContainer);
            this.Controls.Add(this.VendedorContainer);
            this.Controls.Add(this.TiendaContainer);
            this.Controls.Add(this.TitleContainer);
            this.Name = "FormCotizacion";
            this.Text = "Cotizador Express";
            this.TitleContainer.ResumeLayout(false);
            this.TiendaContainer.ResumeLayout(false);
            this.TiendaContainer.PerformLayout();
            this.VendedorContainer.ResumeLayout(false);
            this.VendedorContainer.PerformLayout();
            this.CotizacionContainer.ResumeLayout(false);
            this.CotizadorInnerPanel.ResumeLayout(false);
            this.CotizadorInnerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PrendaCalidadPrecioContainer.Panel1.ResumeLayout(false);
            this.PrendaCalidadPrecioContainer.Panel1.PerformLayout();
            this.PrendaCalidadPrecioContainer.Panel2.ResumeLayout(false);
            this.PrendaCalidadPrecioContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrendaCalidadPrecioContainer)).EndInit();
            this.PrendaCalidadPrecioContainer.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitleContainer;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel TiendaContainer;
        private System.Windows.Forms.Label TiendaNombreText;
        private System.Windows.Forms.Label TiendaDireccionText;
        private System.Windows.Forms.Panel VendedorContainer;
        private System.Windows.Forms.LinkLabel CotizacionesHistorialLink;
        private System.Windows.Forms.Label VendedorInfoText;
        private System.Windows.Forms.Panel CotizacionContainer;
        private System.Windows.Forms.Panel CotizadorInnerPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox PantalonChupinBox;
        private System.Windows.Forms.CheckBox CamisaCuelloMaoBox;
        private System.Windows.Forms.CheckBox CamisaMangaCortaBox;
        private System.Windows.Forms.RadioButton PantalonToggle;
        private System.Windows.Forms.RadioButton CamisaToggle;
        private System.Windows.Forms.Label PrendaTitleLabel;
        private System.Windows.Forms.SplitContainer PrendaCalidadPrecioContainer;
        private System.Windows.Forms.Label PrendaStockText;
        private System.Windows.Forms.Label PrendaStockLabel;
        private System.Windows.Forms.Label PrendaCalidadLabel;
        private System.Windows.Forms.RadioButton PrendaCalidadStandardToggle;
        private System.Windows.Forms.RadioButton PrendaCalidadPremiumToggle;
        private System.Windows.Forms.TextBox PrendaCantidadInputText;
        private System.Windows.Forms.Label PrendaCantidadLabel;
        private System.Windows.Forms.Label PrendaPrecioLabel;
        private System.Windows.Forms.TextBox PrendaPrecioInputText;
        private System.Windows.Forms.Label PrendaPrecioTiitleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CotizacionMontoLabel;
        private System.Windows.Forms.Button CotizarButton;
        private System.Windows.Forms.Label CotizacionMontoText;
    }
}