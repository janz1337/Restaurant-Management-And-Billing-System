
namespace Restaurant_Management_And_Billing_System
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelNavBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSales = new System.Windows.Forms.TabPage();
            this.btnGenerate = new XanderUI.XUIButton();
            this.reportDatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabDash = new System.Windows.Forms.TabPage();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.txtClear = new XanderUI.XUIButton();
            this.btnSave = new XanderUI.XUIButton();
            this.itemDatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dgvInventory = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txtPieces = new Restaurant_Management_And_Billing_System.TextboxCustom();
            this.txtPrice = new Restaurant_Management_And_Billing_System.TextboxCustom();
            this.txtBread = new Restaurant_Management_And_Billing_System.TextboxCustom();
            this.tabInventory = new System.Windows.Forms.TabPage();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.LinkLabel();
            this.labelMax = new System.Windows.Forms.LinkLabel();
            this.labelClose = new System.Windows.Forms.LinkLabel();
            this.labelNormal = new System.Windows.Forms.LinkLabel();
            this.panelNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavBar
            // 
            this.panelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelNavBar.Controls.Add(this.pictureBox1);
            this.panelNavBar.Controls.Add(this.panelNav);
            this.panelNavBar.Controls.Add(this.btnInventory);
            this.panelNavBar.Controls.Add(this.btnProduct);
            this.panelNavBar.Controls.Add(this.btnSales);
            this.panelNavBar.Controls.Add(this.btnHome);
            this.panelNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNavBar.Location = new System.Drawing.Point(0, 0);
            this.panelNavBar.Name = "panelNavBar";
            this.panelNavBar.Size = new System.Drawing.Size(223, 596);
            this.panelNavBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Restaurant_Management_And_Billing_System.Properties.Resources.Untitled_11;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 149);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.panelNav.Location = new System.Drawing.Point(0, 171);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(6, 100);
            this.panelNav.TabIndex = 4;
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnInventory.Image = global::Restaurant_Management_And_Billing_System.Properties.Resources.comparison;
            this.btnInventory.Location = new System.Drawing.Point(-1, 315);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(224, 49);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventory    ";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnProduct.Image = global::Restaurant_Management_And_Billing_System.Properties.Resources.inventory;
            this.btnProduct.Location = new System.Drawing.Point(-1, 267);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(224, 49);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "Product       ";
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSales
            // 
            this.btnSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnSales.Image = global::Restaurant_Management_And_Billing_System.Properties.Resources.graph;
            this.btnSales.Location = new System.Drawing.Point(-1, 217);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(224, 49);
            this.btnSales.TabIndex = 1;
            this.btnSales.Text = "Sales           ";
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnHome.Image = global::Restaurant_Management_And_Billing_System.Properties.Resources.shopping_online;
            this.btnHome.Location = new System.Drawing.Point(-1, 167);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(224, 49);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Dashboard";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabSales);
            this.tabControl1.Controls.Add(this.tabDash);
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabInventory);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 0);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 596);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 3;
            // 
            // tabSales
            // 
            this.tabSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabSales.Controls.Add(this.btnGenerate);
            this.tabSales.Controls.Add(this.reportDatePicker);
            this.tabSales.Controls.Add(this.chart1);
            this.tabSales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabSales.Location = new System.Drawing.Point(213, 4);
            this.tabSales.Margin = new System.Windows.Forms.Padding(0);
            this.tabSales.Name = "tabSales";
            this.tabSales.Size = new System.Drawing.Size(768, 588);
            this.tabSales.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnGenerate.ButtonImage = null;
            this.btnGenerate.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnGenerate.ButtonText = "Generate Report";
            this.btnGenerate.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.btnGenerate.ClickTextColor = System.Drawing.Color.Black;
            this.btnGenerate.CornerRadius = 5;
            this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGenerate.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.btnGenerate.HoverTextColor = System.Drawing.Color.White;
            this.btnGenerate.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnGenerate.Location = new System.Drawing.Point(505, 145);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(202, 40);
            this.btnGenerate.TabIndex = 18;
            this.btnGenerate.TextColor = System.Drawing.Color.White;
            this.btnGenerate.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // reportDatePicker
            // 
            this.reportDatePicker.BackColor = System.Drawing.Color.SeaGreen;
            this.reportDatePicker.BorderRadius = 5;
            this.reportDatePicker.ForeColor = System.Drawing.Color.White;
            this.reportDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reportDatePicker.FormatCustom = "";
            this.reportDatePicker.Location = new System.Drawing.Point(713, 147);
            this.reportDatePicker.Name = "reportDatePicker";
            this.reportDatePicker.Size = new System.Drawing.Size(37, 36);
            this.reportDatePicker.TabIndex = 16;
            this.reportDatePicker.Value = new System.DateTime(2020, 11, 30, 12, 18, 36, 498);
            this.reportDatePicker.onValueChanged += new System.EventHandler(this.reportDatePicker_onValueChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 213);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Best Seller";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(758, 375);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // tabDash
            // 
            this.tabDash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabDash.Location = new System.Drawing.Point(213, 4);
            this.tabDash.Margin = new System.Windows.Forms.Padding(0);
            this.tabDash.Name = "tabDash";
            this.tabDash.Size = new System.Drawing.Size(768, 588);
            this.tabDash.TabIndex = 1;
            // 
            // tabProduct
            // 
            this.tabProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabProduct.Controls.Add(this.txtClear);
            this.tabProduct.Controls.Add(this.btnSave);
            this.tabProduct.Controls.Add(this.itemDatePicker);
            this.tabProduct.Controls.Add(this.dgvInventory);
            this.tabProduct.Controls.Add(this.txtPieces);
            this.tabProduct.Controls.Add(this.txtPrice);
            this.tabProduct.Controls.Add(this.txtBread);
            this.tabProduct.Location = new System.Drawing.Point(213, 4);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Size = new System.Drawing.Size(768, 588);
            this.tabProduct.TabIndex = 3;
            // 
            // txtClear
            // 
            this.txtClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.txtClear.ButtonImage = null;
            this.txtClear.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.txtClear.ButtonText = "Clear";
            this.txtClear.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.txtClear.ClickTextColor = System.Drawing.Color.Black;
            this.txtClear.CornerRadius = 5;
            this.txtClear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClear.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.txtClear.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.txtClear.HoverTextColor = System.Drawing.Color.White;
            this.txtClear.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.txtClear.Location = new System.Drawing.Point(139, 244);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(99, 40);
            this.txtClear.TabIndex = 18;
            this.txtClear.TextColor = System.Drawing.Color.White;
            this.txtClear.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnSave.ButtonImage = null;
            this.btnSave.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSave.ButtonText = "Save";
            this.btnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(54)))), ((int)(((byte)(22)))));
            this.btnSave.ClickTextColor = System.Drawing.Color.Black;
            this.btnSave.CornerRadius = 5;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(230)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.White;
            this.btnSave.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSave.Location = new System.Drawing.Point(34, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 40);
            this.btnSave.TabIndex = 17;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // itemDatePicker
            // 
            this.itemDatePicker.BackColor = System.Drawing.Color.SeaGreen;
            this.itemDatePicker.BorderRadius = 5;
            this.itemDatePicker.ForeColor = System.Drawing.Color.White;
            this.itemDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.itemDatePicker.FormatCustom = "";
            this.itemDatePicker.Location = new System.Drawing.Point(398, 121);
            this.itemDatePicker.Name = "itemDatePicker";
            this.itemDatePicker.Size = new System.Drawing.Size(37, 36);
            this.itemDatePicker.TabIndex = 15;
            this.itemDatePicker.Value = new System.DateTime(2020, 11, 30, 12, 18, 36, 498);
            this.itemDatePicker.onValueChanged += new System.EventHandler(this.itemDatePicker_onValueChanged_1);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventory.DoubleBuffered = true;
            this.dgvInventory.EnableHeadersVisualStyles = false;
            this.dgvInventory.HeaderBgColor = System.Drawing.Color.Black;
            this.dgvInventory.HeaderForeColor = System.Drawing.Color.White;
            this.dgvInventory.Location = new System.Drawing.Point(16, 311);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInventory.Size = new System.Drawing.Size(756, 281);
            this.dgvInventory.TabIndex = 14;
            this.dgvInventory.DoubleClick += new System.EventHandler(this.dgvInventory_DoubleClick);
            // 
            // txtPieces
            // 
            this.txtPieces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtPieces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPieces.BottomBorderColor = System.Drawing.Color.Gray;
            this.txtPieces.BottomBorderOnFocusColor = System.Drawing.Color.Lime;
            this.txtPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPieces.ForeColor = System.Drawing.Color.DimGray;
            this.txtPieces.Location = new System.Drawing.Point(33, 196);
            this.txtPieces.Name = "txtPieces";
            this.txtPieces.Size = new System.Drawing.Size(402, 27);
            this.txtPieces.TabIndex = 16;
            this.txtPieces.Text = "Pieces";
            this.txtPieces.Enter += new System.EventHandler(this.txtPieces_Enter);
            this.txtPieces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPieces_KeyPress);
            this.txtPieces.Leave += new System.EventHandler(this.txtPieces_Leave);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.BottomBorderColor = System.Drawing.Color.Gray;
            this.txtPrice.BottomBorderOnFocusColor = System.Drawing.Color.Lime;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrice.Location = new System.Drawing.Point(34, 163);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(401, 27);
            this.txtPrice.TabIndex = 13;
            this.txtPrice.Text = "Price";
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtBread
            // 
            this.txtBread.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtBread.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBread.BottomBorderColor = System.Drawing.Color.Gray;
            this.txtBread.BottomBorderOnFocusColor = System.Drawing.Color.Lime;
            this.txtBread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBread.ForeColor = System.Drawing.Color.DimGray;
            this.txtBread.Location = new System.Drawing.Point(34, 130);
            this.txtBread.Name = "txtBread";
            this.txtBread.Size = new System.Drawing.Size(345, 27);
            this.txtBread.TabIndex = 12;
            this.txtBread.Text = "Bread";
            this.txtBread.Enter += new System.EventHandler(this.txtBread_Enter);
            this.txtBread.Leave += new System.EventHandler(this.txtBread_Leave);
            // 
            // tabInventory
            // 
            this.tabInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabInventory.Location = new System.Drawing.Point(213, 4);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.Size = new System.Drawing.Size(768, 588);
            this.tabInventory.TabIndex = 4;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelTitleBar.Controls.Add(this.labelHeader);
            this.panelTitleBar.Controls.Add(this.labelMin);
            this.panelTitleBar.Controls.Add(this.labelMax);
            this.panelTitleBar.Controls.Add(this.labelClose);
            this.panelTitleBar.Controls.Add(this.labelNormal);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(223, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(762, 67);
            this.panelTitleBar.TabIndex = 5;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            this.panelTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseMove);
            this.panelTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseUp);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Century Gothic", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelHeader.Location = new System.Drawing.Point(6, 24);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(163, 34);
            this.labelHeader.TabIndex = 8;
            this.labelHeader.Text = "Dashboard";
            // 
            // labelMin
            // 
            this.labelMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMin.AutoSize = true;
            this.labelMin.DisabledLinkColor = System.Drawing.Color.Yellow;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labelMin.LinkColor = System.Drawing.Color.Yellow;
            this.labelMin.Location = new System.Drawing.Point(661, 24);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(27, 18);
            this.labelMin.TabIndex = 6;
            this.labelMin.TabStop = true;
            this.labelMin.Text = "⚫";
            this.labelMin.VisitedLinkColor = System.Drawing.Color.Red;
            this.labelMin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelMin_LinkClicked);
            // 
            // labelMax
            // 
            this.labelMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMax.AutoSize = true;
            this.labelMax.DisabledLinkColor = System.Drawing.Color.Lime;
            this.labelMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMax.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labelMax.LinkColor = System.Drawing.Color.LimeGreen;
            this.labelMax.Location = new System.Drawing.Point(686, 24);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 18);
            this.labelMax.TabIndex = 5;
            this.labelMax.TabStop = true;
            this.labelMax.Text = "⚫";
            this.labelMax.VisitedLinkColor = System.Drawing.Color.Red;
            this.labelMax.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelMax_LinkClicked);
            // 
            // labelClose
            // 
            this.labelClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClose.AutoSize = true;
            this.labelClose.DisabledLinkColor = System.Drawing.Color.Red;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labelClose.LinkColor = System.Drawing.Color.Red;
            this.labelClose.Location = new System.Drawing.Point(711, 24);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(27, 18);
            this.labelClose.TabIndex = 4;
            this.labelClose.TabStop = true;
            this.labelClose.Text = "⚫";
            this.labelClose.VisitedLinkColor = System.Drawing.Color.Red;
            this.labelClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelClose_LinkClicked);
            // 
            // labelNormal
            // 
            this.labelNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNormal.AutoSize = true;
            this.labelNormal.DisabledLinkColor = System.Drawing.Color.Lime;
            this.labelNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNormal.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.labelNormal.LinkColor = System.Drawing.Color.LimeGreen;
            this.labelNormal.Location = new System.Drawing.Point(686, 24);
            this.labelNormal.Name = "labelNormal";
            this.labelNormal.Size = new System.Drawing.Size(27, 18);
            this.labelNormal.TabIndex = 7;
            this.labelNormal.TabStop = true;
            this.labelNormal.Text = "⚫";
            this.labelNormal.VisitedLinkColor = System.Drawing.Color.Red;
            this.labelNormal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelNormal_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(985, 596);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelNavBar);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavBar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDash;
        private System.Windows.Forms.TabPage tabSales;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.TabPage tabInventory;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.LinkLabel labelClose;
        private System.Windows.Forms.LinkLabel labelMin;
        private System.Windows.Forms.LinkLabel labelMax;
        private System.Windows.Forms.LinkLabel labelNormal;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private XanderUI.XUIButton txtClear;
        private XanderUI.XUIButton btnSave;
        private TextboxCustom txtPieces;
        private Bunifu.Framework.UI.BunifuDatepicker itemDatePicker;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvInventory;
        private TextboxCustom txtPrice;
        private TextboxCustom txtBread;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.Framework.UI.BunifuDatepicker reportDatePicker;
        private XanderUI.XUIButton btnGenerate;
    }
}

