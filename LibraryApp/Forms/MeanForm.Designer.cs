using System.Windows.Forms;

namespace LibraryApp.Forms
{
    partial class MeanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeanForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnManagers = new System.Windows.Forms.Button();
            this.BtnCustomers = new System.Windows.Forms.Button();
            this.BtnBooks = new System.Windows.Forms.Button();
            this.BtnOrders = new System.Windows.Forms.Button();
            this.Pcrİcon = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LblLibrary = new System.Windows.Forms.Label();
            this.PnlOrders = new System.Windows.Forms.Panel();
            this.TabOrders = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.PnlBooks = new System.Windows.Forms.Panel();
            this.PnlFilterBooks = new System.Windows.Forms.Panel();
            this.LblType = new System.Windows.Forms.Label();
            this.CbbFilterBooks = new System.Windows.Forms.ComboBox();
            this.LblFilter = new System.Windows.Forms.Label();
            this.CbbSortBooks = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CbbSearchBooks = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSearchBooks = new System.Windows.Forms.TextBox();
            this.BtnUpdateBook = new System.Windows.Forms.Button();
            this.BtnDeleteBook = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnAddBook = new System.Windows.Forms.Button();
            this.LblUnderlineCountBook = new System.Windows.Forms.Label();
            this.TxtCountBook = new System.Windows.Forms.TextBox();
            this.LblUnderlinePriceBook = new System.Windows.Forms.Label();
            this.TxtPriceBook = new System.Windows.Forms.TextBox();
            this.LblUnderlineWritterBook = new System.Windows.Forms.Label();
            this.TxtWritterBook = new System.Windows.Forms.TextBox();
            this.LblUnderlineNameBook = new System.Windows.Forms.Label();
            this.TxtNameBook = new System.Windows.Forms.TextBox();
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PnlCustomers = new System.Windows.Forms.Panel();
            this.PnlFilterCustomers = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CbbFilterCustomers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbbSortCustomers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CbbSearchCustomers = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSearchCustomers = new System.Windows.Forms.TextBox();
            this.LblDateBirthCutomer = new System.Windows.Forms.Label();
            this.DgvCustomers = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.BtnUpdateCustomer = new System.Windows.Forms.Button();
            this.BtnDeleteCustomer = new System.Windows.Forms.Button();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.LblUnderDateBirthCutomer = new System.Windows.Forms.Label();
            this.LblUnderPhoneNumberCustomer = new System.Windows.Forms.Label();
            this.TxtPhoneNumberCustomer = new System.Windows.Forms.TextBox();
            this.LblUnderSurnameCustomer = new System.Windows.Forms.Label();
            this.TxtSurnameCustomer = new System.Windows.Forms.TextBox();
            this.LblUnderNameCustomer = new System.Windows.Forms.Label();
            this.TxtNameCustomer = new System.Windows.Forms.TextBox();
            this.PnlManagers = new System.Windows.Forms.Panel();
            this.TxtPasswordManager = new System.Windows.Forms.TextBox();
            this.DgvManagers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnUpdateManager = new System.Windows.Forms.Button();
            this.BtnDeleteManager = new System.Windows.Forms.Button();
            this.BtnAddManager = new System.Windows.Forms.Button();
            this.LblUnderPasswordManager = new System.Windows.Forms.Label();
            this.LblUnderUsernameManager = new System.Windows.Forms.Label();
            this.TxtUsernameManager = new System.Windows.Forms.TextBox();
            this.LblUnderSurnameManager = new System.Windows.Forms.Label();
            this.TxtSurnameManager = new System.Windows.Forms.TextBox();
            this.LblUnderNameManager = new System.Windows.Forms.Label();
            this.TxtNameManager = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcrİcon)).BeginInit();
            this.PnlOrders.SuspendLayout();
            this.TabOrders.SuspendLayout();
            this.PnlBooks.SuspendLayout();
            this.PnlFilterBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.PnlCustomers.SuspendLayout();
            this.PnlFilterCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            this.PnlManagers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvManagers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.BtnManagers);
            this.panel1.Controls.Add(this.BtnCustomers);
            this.panel1.Controls.Add(this.BtnBooks);
            this.panel1.Controls.Add(this.BtnOrders);
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 758);
            this.panel1.TabIndex = 0;
            // 
            // BtnManagers
            // 
            this.BtnManagers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.BtnManagers.FlatAppearance.BorderSize = 0;
            this.BtnManagers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnManagers.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManagers.ForeColor = System.Drawing.Color.White;
            this.BtnManagers.Location = new System.Drawing.Point(0, 167);
            this.BtnManagers.Name = "BtnManagers";
            this.BtnManagers.Size = new System.Drawing.Size(164, 45);
            this.BtnManagers.TabIndex = 3;
            this.BtnManagers.Text = "İdarəedicilər";
            this.BtnManagers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnManagers.UseVisualStyleBackColor = false;
            this.BtnManagers.Click += new System.EventHandler(this.BtnManagers_Click);
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.BtnCustomers.FlatAppearance.BorderSize = 0;
            this.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomers.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomers.ForeColor = System.Drawing.Color.White;
            this.BtnCustomers.Location = new System.Drawing.Point(0, 119);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(164, 45);
            this.BtnCustomers.TabIndex = 2;
            this.BtnCustomers.Text = "Müştərilər";
            this.BtnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomers.UseVisualStyleBackColor = false;
            this.BtnCustomers.Click += new System.EventHandler(this.BtnCustomers_Click);
            // 
            // BtnBooks
            // 
            this.BtnBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.BtnBooks.FlatAppearance.BorderSize = 0;
            this.BtnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBooks.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBooks.ForeColor = System.Drawing.Color.White;
            this.BtnBooks.Location = new System.Drawing.Point(0, 71);
            this.BtnBooks.Name = "BtnBooks";
            this.BtnBooks.Size = new System.Drawing.Size(164, 45);
            this.BtnBooks.TabIndex = 1;
            this.BtnBooks.Text = "Kitablar";
            this.BtnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBooks.UseVisualStyleBackColor = false;
            this.BtnBooks.Click += new System.EventHandler(this.BtnBooks_Click);
            // 
            // BtnOrders
            // 
            this.BtnOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.BtnOrders.FlatAppearance.BorderSize = 0;
            this.BtnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrders.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrders.ForeColor = System.Drawing.Color.White;
            this.BtnOrders.Location = new System.Drawing.Point(0, 23);
            this.BtnOrders.Name = "BtnOrders";
            this.BtnOrders.Size = new System.Drawing.Size(164, 45);
            this.BtnOrders.TabIndex = 0;
            this.BtnOrders.Text = "Sifarişlər";
            this.BtnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOrders.UseVisualStyleBackColor = false;
            this.BtnOrders.Click += new System.EventHandler(this.BtnOrders_Click);
            // 
            // Pcrİcon
            // 
            this.Pcrİcon.Image = ((System.Drawing.Image)(resources.GetObject("Pcrİcon.Image")));
            this.Pcrİcon.Location = new System.Drawing.Point(1, -1);
            this.Pcrİcon.Name = "Pcrİcon";
            this.Pcrİcon.Size = new System.Drawing.Size(166, 124);
            this.Pcrİcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pcrİcon.TabIndex = 1;
            this.Pcrİcon.TabStop = false;
            // 
            // LblLibrary
            // 
            this.LblLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.LblLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLibrary.Location = new System.Drawing.Point(166, -1);
            this.LblLibrary.Name = "LblLibrary";
            this.LblLibrary.Size = new System.Drawing.Size(1290, 124);
            this.LblLibrary.TabIndex = 2;
            this.LblLibrary.Text = "K İ T A B X A N A";
            this.LblLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PnlOrders
            // 
            this.PnlOrders.Controls.Add(this.TabOrders);
            this.PnlOrders.Location = new System.Drawing.Point(164, 126);
            this.PnlOrders.Name = "PnlOrders";
            this.PnlOrders.Size = new System.Drawing.Size(1292, 755);
            this.PnlOrders.TabIndex = 3;
            this.PnlOrders.Visible = false;
            // 
            // TabOrders
            // 
            this.TabOrders.Controls.Add(this.tabPage2);
            this.TabOrders.Controls.Add(this.tabPage1);
            this.TabOrders.Controls.Add(this.tabPage3);
            this.TabOrders.Cursor = System.Windows.Forms.Cursors.No;
            this.TabOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabOrders.Location = new System.Drawing.Point(0, 0);
            this.TabOrders.Name = "TabOrders";
            this.TabOrders.SelectedIndex = 0;
            this.TabOrders.Size = new System.Drawing.Size(1292, 755);
            this.TabOrders.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1284, 711);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "            Yeni sifariş yarat             ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1284, 711);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "             Kitabı qaytar             ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1284, 711);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "             Kirayə kitabları izlə             ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // PnlBooks
            // 
            this.PnlBooks.AccessibleName = "";
            this.PnlBooks.BackColor = System.Drawing.Color.White;
            this.PnlBooks.Controls.Add(this.PnlFilterBooks);
            this.PnlBooks.Controls.Add(this.label4);
            this.PnlBooks.Controls.Add(this.CbbSearchBooks);
            this.PnlBooks.Controls.Add(this.label3);
            this.PnlBooks.Controls.Add(this.TxtSearchBooks);
            this.PnlBooks.Controls.Add(this.BtnUpdateBook);
            this.PnlBooks.Controls.Add(this.BtnDeleteBook);
            this.PnlBooks.Controls.Add(this.label5);
            this.PnlBooks.Controls.Add(this.BtnAddBook);
            this.PnlBooks.Controls.Add(this.LblUnderlineCountBook);
            this.PnlBooks.Controls.Add(this.TxtCountBook);
            this.PnlBooks.Controls.Add(this.LblUnderlinePriceBook);
            this.PnlBooks.Controls.Add(this.TxtPriceBook);
            this.PnlBooks.Controls.Add(this.LblUnderlineWritterBook);
            this.PnlBooks.Controls.Add(this.TxtWritterBook);
            this.PnlBooks.Controls.Add(this.LblUnderlineNameBook);
            this.PnlBooks.Controls.Add(this.TxtNameBook);
            this.PnlBooks.Controls.Add(this.DgvBooks);
            this.PnlBooks.Location = new System.Drawing.Point(164, 123);
            this.PnlBooks.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.PnlBooks.Name = "PnlBooks";
            this.PnlBooks.Size = new System.Drawing.Size(1282, 758);
            this.PnlBooks.TabIndex = 4;
            this.PnlBooks.Visible = false;
            // 
            // PnlFilterBooks
            // 
            this.PnlFilterBooks.Controls.Add(this.LblType);
            this.PnlFilterBooks.Controls.Add(this.CbbFilterBooks);
            this.PnlFilterBooks.Controls.Add(this.LblFilter);
            this.PnlFilterBooks.Controls.Add(this.CbbSortBooks);
            this.PnlFilterBooks.Location = new System.Drawing.Point(854, 287);
            this.PnlFilterBooks.Name = "PnlFilterBooks";
            this.PnlFilterBooks.Size = new System.Drawing.Size(217, 198);
            this.PnlFilterBooks.TabIndex = 25;
            // 
            // LblType
            // 
            this.LblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblType.ForeColor = System.Drawing.Color.Black;
            this.LblType.Location = new System.Drawing.Point(8, 133);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(122, 23);
            this.LblType.TabIndex = 18;
            this.LblType.Text = "Sıralama";
            // 
            // CbbFilterBooks
            // 
            this.CbbFilterBooks.AccessibleName = "";
            this.CbbFilterBooks.BackColor = System.Drawing.Color.White;
            this.CbbFilterBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbFilterBooks.FormattingEnabled = true;
            this.CbbFilterBooks.Items.AddRange(new object[] {
            " Hamısı",
            " Kitabxanada olanlar ",
            " İcarədə olanlar"});
            this.CbbFilterBooks.Location = new System.Drawing.Point(10, 49);
            this.CbbFilterBooks.Name = "CbbFilterBooks";
            this.CbbFilterBooks.Size = new System.Drawing.Size(198, 28);
            this.CbbFilterBooks.TabIndex = 17;
            this.CbbFilterBooks.SelectedIndexChanged += new System.EventHandler(this.CbbSortBooks_SelectedIndexChanged);
            // 
            // LblFilter
            // 
            this.LblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFilter.ForeColor = System.Drawing.Color.Black;
            this.LblFilter.Location = new System.Drawing.Point(8, 16);
            this.LblFilter.Name = "LblFilter";
            this.LblFilter.Size = new System.Drawing.Size(122, 23);
            this.LblFilter.TabIndex = 19;
            this.LblFilter.Text = "Filtrələ";
            // 
            // CbbSortBooks
            // 
            this.CbbSortBooks.AccessibleName = "";
            this.CbbSortBooks.BackColor = System.Drawing.Color.White;
            this.CbbSortBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbSortBooks.FormattingEnabled = true;
            this.CbbSortBooks.Items.AddRange(new object[] {
            "Ada görə",
            "Tarixə görə",
            "Qiymətə görə",
            "Saya görə"});
            this.CbbSortBooks.Location = new System.Drawing.Point(12, 159);
            this.CbbSortBooks.Name = "CbbSortBooks";
            this.CbbSortBooks.Size = new System.Drawing.Size(198, 28);
            this.CbbSortBooks.TabIndex = 20;
            this.CbbSortBooks.SelectedIndexChanged += new System.EventHandler(this.CbbSortBooks_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(188, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 5);
            this.label4.TabIndex = 24;
            // 
            // CbbSearchBooks
            // 
            this.CbbSearchBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbbSearchBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbSearchBooks.FormattingEnabled = true;
            this.CbbSearchBooks.Items.AddRange(new object[] {
            "Ada görə axtar",
            "Yazara görə axtar"});
            this.CbbSearchBooks.Location = new System.Drawing.Point(188, 225);
            this.CbbSearchBooks.Name = "CbbSearchBooks";
            this.CbbSearchBooks.Size = new System.Drawing.Size(195, 28);
            this.CbbSearchBooks.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(431, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 5);
            this.label3.TabIndex = 22;
            // 
            // TxtSearchBooks
            // 
            this.TxtSearchBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchBooks.ForeColor = System.Drawing.Color.Silver;
            this.TxtSearchBooks.Location = new System.Drawing.Point(431, 225);
            this.TxtSearchBooks.Multiline = true;
            this.TxtSearchBooks.Name = "TxtSearchBooks";
            this.TxtSearchBooks.Size = new System.Drawing.Size(181, 29);
            this.TxtSearchBooks.TabIndex = 21;
            this.TxtSearchBooks.Text = "Axtarış edin...";
            this.TxtSearchBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearchBooks.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.TxtSearchBooks.Enter += new System.EventHandler(this.TxtSearchBooks_Enter);
            this.TxtSearchBooks.Leave += new System.EventHandler(this.TxtSearchBooks_Leave);
            // 
            // BtnUpdateBook
            // 
            this.BtnUpdateBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnUpdateBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateBook.Location = new System.Drawing.Point(959, 15);
            this.BtnUpdateBook.Name = "BtnUpdateBook";
            this.BtnUpdateBook.Size = new System.Drawing.Size(145, 48);
            this.BtnUpdateBook.TabIndex = 16;
            this.BtnUpdateBook.Text = "Yenilə";
            this.BtnUpdateBook.UseVisualStyleBackColor = false;
            this.BtnUpdateBook.Visible = false;
            this.BtnUpdateBook.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDeleteBook
            // 
            this.BtnDeleteBook.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteBook.Location = new System.Drawing.Point(1145, 15);
            this.BtnDeleteBook.Name = "BtnDeleteBook";
            this.BtnDeleteBook.Size = new System.Drawing.Size(92, 48);
            this.BtnDeleteBook.TabIndex = 15;
            this.BtnDeleteBook.Text = "Sil";
            this.BtnDeleteBook.UseVisualStyleBackColor = false;
            this.BtnDeleteBook.Visible = false;
            this.BtnDeleteBook.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // BtnAddBook
            // 
            this.BtnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddBook.Location = new System.Drawing.Point(1042, 15);
            this.BtnAddBook.Name = "BtnAddBook";
            this.BtnAddBook.Size = new System.Drawing.Size(145, 48);
            this.BtnAddBook.TabIndex = 9;
            this.BtnAddBook.Text = "Əlavə et";
            this.BtnAddBook.UseVisualStyleBackColor = false;
            this.BtnAddBook.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblUnderlineCountBook
            // 
            this.LblUnderlineCountBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblUnderlineCountBook.Location = new System.Drawing.Point(821, 53);
            this.LblUnderlineCountBook.Name = "LblUnderlineCountBook";
            this.LblUnderlineCountBook.Size = new System.Drawing.Size(104, 5);
            this.LblUnderlineCountBook.TabIndex = 8;
            // 
            // TxtCountBook
            // 
            this.TxtCountBook.AllowDrop = true;
            this.TxtCountBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCountBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCountBook.ForeColor = System.Drawing.Color.Silver;
            this.TxtCountBook.Location = new System.Drawing.Point(824, 26);
            this.TxtCountBook.Multiline = true;
            this.TxtCountBook.Name = "TxtCountBook";
            this.TxtCountBook.Size = new System.Drawing.Size(85, 25);
            this.TxtCountBook.TabIndex = 7;
            this.TxtCountBook.Text = "Sayı";
            this.TxtCountBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCountBook.Enter += new System.EventHandler(this.TxtCountBook_Enter);
            this.TxtCountBook.Leave += new System.EventHandler(this.TxtCountBook_Leave);
            // 
            // LblUnderlinePriceBook
            // 
            this.LblUnderlinePriceBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblUnderlinePriceBook.Location = new System.Drawing.Point(614, 53);
            this.LblUnderlinePriceBook.Name = "LblUnderlinePriceBook";
            this.LblUnderlinePriceBook.Size = new System.Drawing.Size(150, 5);
            this.LblUnderlinePriceBook.TabIndex = 6;
            // 
            // TxtPriceBook
            // 
            this.TxtPriceBook.AllowDrop = true;
            this.TxtPriceBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPriceBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPriceBook.ForeColor = System.Drawing.Color.Silver;
            this.TxtPriceBook.Location = new System.Drawing.Point(617, 26);
            this.TxtPriceBook.Multiline = true;
            this.TxtPriceBook.Name = "TxtPriceBook";
            this.TxtPriceBook.Size = new System.Drawing.Size(136, 24);
            this.TxtPriceBook.TabIndex = 5;
            this.TxtPriceBook.Text = "Qiyməti";
            this.TxtPriceBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPriceBook.Enter += new System.EventHandler(this.TxtPriceBook_Enter);
            this.TxtPriceBook.Leave += new System.EventHandler(this.TxtPriceBook_Leave);
            // 
            // LblUnderlineWritterBook
            // 
            this.LblUnderlineWritterBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblUnderlineWritterBook.Location = new System.Drawing.Point(303, 53);
            this.LblUnderlineWritterBook.Name = "LblUnderlineWritterBook";
            this.LblUnderlineWritterBook.Size = new System.Drawing.Size(253, 5);
            this.LblUnderlineWritterBook.TabIndex = 4;
            // 
            // TxtWritterBook
            // 
            this.TxtWritterBook.AllowDrop = true;
            this.TxtWritterBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtWritterBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWritterBook.ForeColor = System.Drawing.Color.Silver;
            this.TxtWritterBook.Location = new System.Drawing.Point(306, 26);
            this.TxtWritterBook.Multiline = true;
            this.TxtWritterBook.Name = "TxtWritterBook";
            this.TxtWritterBook.Size = new System.Drawing.Size(239, 24);
            this.TxtWritterBook.TabIndex = 3;
            this.TxtWritterBook.Text = "Yazarı";
            this.TxtWritterBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtWritterBook.Enter += new System.EventHandler(this.TxtWritterBook_Enter);
            this.TxtWritterBook.Leave += new System.EventHandler(this.TxtWritterBook_Leave);
            // 
            // LblUnderlineNameBook
            // 
            this.LblUnderlineNameBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblUnderlineNameBook.Location = new System.Drawing.Point(35, 53);
            this.LblUnderlineNameBook.Name = "LblUnderlineNameBook";
            this.LblUnderlineNameBook.Size = new System.Drawing.Size(216, 5);
            this.LblUnderlineNameBook.TabIndex = 2;
            // 
            // TxtNameBook
            // 
            this.TxtNameBook.AllowDrop = true;
            this.TxtNameBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNameBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNameBook.ForeColor = System.Drawing.Color.Silver;
            this.TxtNameBook.Location = new System.Drawing.Point(38, 28);
            this.TxtNameBook.Multiline = true;
            this.TxtNameBook.Name = "TxtNameBook";
            this.TxtNameBook.Size = new System.Drawing.Size(204, 24);
            this.TxtNameBook.TabIndex = 1;
            this.TxtNameBook.Text = "Kitabın adı";
            this.TxtNameBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNameBook.Enter += new System.EventHandler(this.TxtNameBook_Enter);
            this.TxtNameBook.Leave += new System.EventHandler(this.TxtNameBook_Leave);
            // 
            // DgvBooks
            // 
            this.DgvBooks.AccessibleName = " ";
            this.DgvBooks.AllowUserToAddRows = false;
            this.DgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBooks.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvBooks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvBooks.ColumnHeadersHeight = 40;
            this.DgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvBooks.Cursor = System.Windows.Forms.Cursors.AppStarting;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvBooks.Location = new System.Drawing.Point(0, 297);
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvBooks.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DgvBooks.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvBooks.RowTemplate.Height = 24;
            this.DgvBooks.Size = new System.Drawing.Size(837, 458);
            this.DgvBooks.TabIndex = 0;
            this.DgvBooks.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBooks_RowHeaderMouseDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id:";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Adı:";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Yazar:";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Aylıq qiymət:";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sayı:";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status:";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // PnlCustomers
            // 
            this.PnlCustomers.AccessibleName = "";
            this.PnlCustomers.BackColor = System.Drawing.Color.White;
            this.PnlCustomers.Controls.Add(this.PnlFilterCustomers);
            this.PnlCustomers.Controls.Add(this.label6);
            this.PnlCustomers.Controls.Add(this.CbbSearchCustomers);
            this.PnlCustomers.Controls.Add(this.label7);
            this.PnlCustomers.Controls.Add(this.TxtSearchCustomers);
            this.PnlCustomers.Controls.Add(this.LblDateBirthCutomer);
            this.PnlCustomers.Controls.Add(this.DgvCustomers);
            this.PnlCustomers.Controls.Add(this.DtpDateBirth);
            this.PnlCustomers.Controls.Add(this.BtnUpdateCustomer);
            this.PnlCustomers.Controls.Add(this.BtnDeleteCustomer);
            this.PnlCustomers.Controls.Add(this.BtnAddCustomer);
            this.PnlCustomers.Controls.Add(this.LblUnderDateBirthCutomer);
            this.PnlCustomers.Controls.Add(this.LblUnderPhoneNumberCustomer);
            this.PnlCustomers.Controls.Add(this.TxtPhoneNumberCustomer);
            this.PnlCustomers.Controls.Add(this.LblUnderSurnameCustomer);
            this.PnlCustomers.Controls.Add(this.TxtSurnameCustomer);
            this.PnlCustomers.Controls.Add(this.LblUnderNameCustomer);
            this.PnlCustomers.Controls.Add(this.TxtNameCustomer);
            this.PnlCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlCustomers.ForeColor = System.Drawing.Color.Silver;
            this.PnlCustomers.Location = new System.Drawing.Point(164, 123);
            this.PnlCustomers.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.PnlCustomers.Name = "PnlCustomers";
            this.PnlCustomers.Size = new System.Drawing.Size(1279, 755);
            this.PnlCustomers.TabIndex = 7;
            this.PnlCustomers.Visible = false;
            // 
            // PnlFilterCustomers
            // 
            this.PnlFilterCustomers.Controls.Add(this.label1);
            this.PnlFilterCustomers.Controls.Add(this.CbbFilterCustomers);
            this.PnlFilterCustomers.Controls.Add(this.label2);
            this.PnlFilterCustomers.Controls.Add(this.CbbSortCustomers);
            this.PnlFilterCustomers.Location = new System.Drawing.Point(976, 284);
            this.PnlFilterCustomers.Name = "PnlFilterCustomers";
            this.PnlFilterCustomers.Size = new System.Drawing.Size(230, 211);
            this.PnlFilterCustomers.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filtrələ";
            // 
            // CbbFilterCustomers
            // 
            this.CbbFilterCustomers.AccessibleName = "";
            this.CbbFilterCustomers.BackColor = System.Drawing.Color.White;
            this.CbbFilterCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbFilterCustomers.FormattingEnabled = true;
            this.CbbFilterCustomers.Items.AddRange(new object[] {
            " Hamısı",
            " Aktiv",
            " Kitab götürməyənlər"});
            this.CbbFilterCustomers.Location = new System.Drawing.Point(17, 55);
            this.CbbFilterCustomers.Name = "CbbFilterCustomers";
            this.CbbFilterCustomers.Size = new System.Drawing.Size(198, 28);
            this.CbbFilterCustomers.TabIndex = 17;
            this.CbbFilterCustomers.SelectedIndexChanged += new System.EventHandler(this.CbbSortCustomers_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Sıralama";
            // 
            // CbbSortCustomers
            // 
            this.CbbSortCustomers.AccessibleName = "";
            this.CbbSortCustomers.BackColor = System.Drawing.Color.White;
            this.CbbSortCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbSortCustomers.FormattingEnabled = true;
            this.CbbSortCustomers.Items.AddRange(new object[] {
            "Tarixə görə",
            "Ada görə"});
            this.CbbSortCustomers.Location = new System.Drawing.Point(19, 169);
            this.CbbSortCustomers.Name = "CbbSortCustomers";
            this.CbbSortCustomers.Size = new System.Drawing.Size(198, 28);
            this.CbbSortCustomers.TabIndex = 20;
            this.CbbSortCustomers.SelectedIndexChanged += new System.EventHandler(this.CbbSortCustomers_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(188, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 5);
            this.label6.TabIndex = 30;
            // 
            // CbbSearchCustomers
            // 
            this.CbbSearchCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbbSearchCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbbSearchCustomers.FormattingEnabled = true;
            this.CbbSearchCustomers.Items.AddRange(new object[] {
            "Ada görə axtar",
            "Soyada görə axtar"});
            this.CbbSearchCustomers.Location = new System.Drawing.Point(188, 225);
            this.CbbSearchCustomers.Name = "CbbSearchCustomers";
            this.CbbSearchCustomers.Size = new System.Drawing.Size(195, 28);
            this.CbbSearchCustomers.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(432, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 5);
            this.label7.TabIndex = 28;
            // 
            // TxtSearchCustomers
            // 
            this.TxtSearchCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearchCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchCustomers.ForeColor = System.Drawing.Color.Silver;
            this.TxtSearchCustomers.Location = new System.Drawing.Point(432, 225);
            this.TxtSearchCustomers.Multiline = true;
            this.TxtSearchCustomers.Name = "TxtSearchCustomers";
            this.TxtSearchCustomers.Size = new System.Drawing.Size(181, 29);
            this.TxtSearchCustomers.TabIndex = 27;
            this.TxtSearchCustomers.Text = "Axtarış edin...";
            this.TxtSearchCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearchCustomers.TextChanged += new System.EventHandler(this.TxtSearchCustomers_TextChanged);
            this.TxtSearchCustomers.Enter += new System.EventHandler(this.TxtSearchCustomers_Enter);
            this.TxtSearchCustomers.Leave += new System.EventHandler(this.TxtSearchCustomers_Leave_1);
            // 
            // LblDateBirthCutomer
            // 
            this.LblDateBirthCutomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateBirthCutomer.Location = new System.Drawing.Point(662, 18);
            this.LblDateBirthCutomer.Name = "LblDateBirthCutomer";
            this.LblDateBirthCutomer.Size = new System.Drawing.Size(83, 29);
            this.LblDateBirthCutomer.TabIndex = 26;
            this.LblDateBirthCutomer.Text = "Doğ t.:";
            this.LblDateBirthCutomer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DgvCustomers
            // 
            this.DgvCustomers.AllowUserToAddRows = false;
            this.DgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCustomers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCustomers.ColumnHeadersHeight = 40;
            this.DgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column7,
            this.Column18});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCustomers.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvCustomers.Location = new System.Drawing.Point(0, 297);
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.DgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvCustomers.RowTemplate.Height = 24;
            this.DgvCustomers.Size = new System.Drawing.Size(974, 461);
            this.DgvCustomers.TabIndex = 25;
            this.DgvCustomers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvCustomers_RowHeaderMouseDoubleClick);
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Id";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Visible = false;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Adı:";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Soyadı:";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Əlaqə nöm:";
            this.Column16.MinimumWidth = 6;
            this.Column16.Name = "Column16";
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Doğum t:";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Qeydiyyat t:";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Status:";
            this.Column18.MinimumWidth = 6;
            this.Column18.Name = "Column18";
            // 
            // DtpDateBirth
            // 
            this.DtpDateBirth.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DtpDateBirth.CustomFormat = "   dd-MM-yyyy";
            this.DtpDateBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDateBirth.Location = new System.Drawing.Point(745, 20);
            this.DtpDateBirth.MaxDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.DtpDateBirth.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.DtpDateBirth.Name = "DtpDateBirth";
            this.DtpDateBirth.Size = new System.Drawing.Size(167, 27);
            this.DtpDateBirth.TabIndex = 24;
            this.DtpDateBirth.Value = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            // 
            // BtnUpdateCustomer
            // 
            this.BtnUpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateCustomer.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateCustomer.Location = new System.Drawing.Point(959, 15);
            this.BtnUpdateCustomer.Name = "BtnUpdateCustomer";
            this.BtnUpdateCustomer.Size = new System.Drawing.Size(145, 48);
            this.BtnUpdateCustomer.TabIndex = 16;
            this.BtnUpdateCustomer.Text = "Yenilə";
            this.BtnUpdateCustomer.UseVisualStyleBackColor = false;
            this.BtnUpdateCustomer.Visible = false;
            this.BtnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
            // 
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteCustomer.Location = new System.Drawing.Point(1145, 15);
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.Size = new System.Drawing.Size(92, 48);
            this.BtnDeleteCustomer.TabIndex = 15;
            this.BtnDeleteCustomer.Text = "Sil";
            this.BtnDeleteCustomer.UseVisualStyleBackColor = false;
            this.BtnDeleteCustomer.Visible = false;
            this.BtnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.BtnAddCustomer.Location = new System.Drawing.Point(1042, 15);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(145, 48);
            this.BtnAddCustomer.TabIndex = 9;
            this.BtnAddCustomer.Text = "Əlavə et";
            this.BtnAddCustomer.UseVisualStyleBackColor = false;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // LblUnderDateBirthCutomer
            // 
            this.LblUnderDateBirthCutomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblUnderDateBirthCutomer.Location = new System.Drawing.Point(665, 53);
            this.LblUnderDateBirthCutomer.Name = "LblUnderDateBirthCutomer";
            this.LblUnderDateBirthCutomer.Size = new System.Drawing.Size(247, 5);
            this.LblUnderDateBirthCutomer.TabIndex = 8;
            // 
            // LblUnderPhoneNumberCustomer
            // 
            this.LblUnderPhoneNumberCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblUnderPhoneNumberCustomer.Location = new System.Drawing.Point(453, 53);
            this.LblUnderPhoneNumberCustomer.Name = "LblUnderPhoneNumberCustomer";
            this.LblUnderPhoneNumberCustomer.Size = new System.Drawing.Size(171, 5);
            this.LblUnderPhoneNumberCustomer.TabIndex = 6;
            // 
            // TxtPhoneNumberCustomer
            // 
            this.TxtPhoneNumberCustomer.AllowDrop = true;
            this.TxtPhoneNumberCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPhoneNumberCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPhoneNumberCustomer.ForeColor = System.Drawing.Color.Silver;
            this.TxtPhoneNumberCustomer.Location = new System.Drawing.Point(456, 23);
            this.TxtPhoneNumberCustomer.Multiline = true;
            this.TxtPhoneNumberCustomer.Name = "TxtPhoneNumberCustomer";
            this.TxtPhoneNumberCustomer.Size = new System.Drawing.Size(168, 24);
            this.TxtPhoneNumberCustomer.TabIndex = 5;
            this.TxtPhoneNumberCustomer.Text = "Tel: 0501234567";
            this.TxtPhoneNumberCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPhoneNumberCustomer.Enter += new System.EventHandler(this.TxtPhoneNumberCustomer_Enter);
            this.TxtPhoneNumberCustomer.Leave += new System.EventHandler(this.TxtPhoneNumberCustomer_Leave);
            // 
            // LblUnderSurnameCustomer
            // 
            this.LblUnderSurnameCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblUnderSurnameCustomer.Location = new System.Drawing.Point(240, 53);
            this.LblUnderSurnameCustomer.Name = "LblUnderSurnameCustomer";
            this.LblUnderSurnameCustomer.Size = new System.Drawing.Size(171, 5);
            this.LblUnderSurnameCustomer.TabIndex = 4;
            // 
            // TxtSurnameCustomer
            // 
            this.TxtSurnameCustomer.AllowDrop = true;
            this.TxtSurnameCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSurnameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurnameCustomer.ForeColor = System.Drawing.Color.Silver;
            this.TxtSurnameCustomer.Location = new System.Drawing.Point(243, 26);
            this.TxtSurnameCustomer.Multiline = true;
            this.TxtSurnameCustomer.Name = "TxtSurnameCustomer";
            this.TxtSurnameCustomer.Size = new System.Drawing.Size(165, 24);
            this.TxtSurnameCustomer.TabIndex = 3;
            this.TxtSurnameCustomer.Text = "Soyadı";
            this.TxtSurnameCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSurnameCustomer.Enter += new System.EventHandler(this.TxtSurnameCustomer_Enter);
            this.TxtSurnameCustomer.Leave += new System.EventHandler(this.TxtSurnameCustomer_Leave);
            // 
            // LblUnderNameCustomer
            // 
            this.LblUnderNameCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblUnderNameCustomer.Location = new System.Drawing.Point(35, 53);
            this.LblUnderNameCustomer.Name = "LblUnderNameCustomer";
            this.LblUnderNameCustomer.Size = new System.Drawing.Size(158, 5);
            this.LblUnderNameCustomer.TabIndex = 2;
            // 
            // TxtNameCustomer
            // 
            this.TxtNameCustomer.AllowDrop = true;
            this.TxtNameCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNameCustomer.ForeColor = System.Drawing.Color.Silver;
            this.TxtNameCustomer.Location = new System.Drawing.Point(38, 28);
            this.TxtNameCustomer.Multiline = true;
            this.TxtNameCustomer.Name = "TxtNameCustomer";
            this.TxtNameCustomer.Size = new System.Drawing.Size(155, 24);
            this.TxtNameCustomer.TabIndex = 1;
            this.TxtNameCustomer.Text = "Müştərinin adı";
            this.TxtNameCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNameCustomer.Enter += new System.EventHandler(this.TxtNameCustomer_Enter);
            this.TxtNameCustomer.Leave += new System.EventHandler(this.TxtNameCustomer_Leave);
            // 
            // PnlManagers
            // 
            this.PnlManagers.AccessibleName = "";
            this.PnlManagers.BackColor = System.Drawing.Color.White;
            this.PnlManagers.Controls.Add(this.TxtPasswordManager);
            this.PnlManagers.Controls.Add(this.DgvManagers);
            this.PnlManagers.Controls.Add(this.BtnUpdateManager);
            this.PnlManagers.Controls.Add(this.BtnDeleteManager);
            this.PnlManagers.Controls.Add(this.BtnAddManager);
            this.PnlManagers.Controls.Add(this.LblUnderPasswordManager);
            this.PnlManagers.Controls.Add(this.LblUnderUsernameManager);
            this.PnlManagers.Controls.Add(this.TxtUsernameManager);
            this.PnlManagers.Controls.Add(this.LblUnderSurnameManager);
            this.PnlManagers.Controls.Add(this.TxtSurnameManager);
            this.PnlManagers.Controls.Add(this.LblUnderNameManager);
            this.PnlManagers.Controls.Add(this.TxtNameManager);
            this.PnlManagers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlManagers.ForeColor = System.Drawing.Color.Silver;
            this.PnlManagers.Location = new System.Drawing.Point(164, 122);
            this.PnlManagers.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.PnlManagers.Name = "PnlManagers";
            this.PnlManagers.Size = new System.Drawing.Size(1276, 756);
            this.PnlManagers.TabIndex = 8;
            this.PnlManagers.Visible = false;
            // 
            // TxtPasswordManager
            // 
            this.TxtPasswordManager.AllowDrop = true;
            this.TxtPasswordManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPasswordManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPasswordManager.ForeColor = System.Drawing.Color.Silver;
            this.TxtPasswordManager.Location = new System.Drawing.Point(716, 25);
            this.TxtPasswordManager.Multiline = true;
            this.TxtPasswordManager.Name = "TxtPasswordManager";
            this.TxtPasswordManager.Size = new System.Drawing.Size(165, 24);
            this.TxtPasswordManager.TabIndex = 27;
            this.TxtPasswordManager.Text = "Parol";
            this.TxtPasswordManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPasswordManager.Enter += new System.EventHandler(this.TxtParolManager_Enter);
            this.TxtPasswordManager.Leave += new System.EventHandler(this.TxtParolManager_Leave);
            // 
            // DgvManagers
            // 
            this.DgvManagers.AllowUserToAddRows = false;
            this.DgvManagers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvManagers.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.DgvManagers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvManagers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvManagers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvManagers.ColumnHeadersHeight = 40;
            this.DgvManagers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.Column8});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvManagers.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvManagers.Location = new System.Drawing.Point(0, 297);
            this.DgvManagers.Name = "DgvManagers";
            this.DgvManagers.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.DgvManagers.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvManagers.RowTemplate.Height = 24;
            this.DgvManagers.Size = new System.Drawing.Size(894, 459);
            this.DgvManagers.TabIndex = 25;
            this.DgvManagers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvManagers_RowHeaderMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id:";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 60F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Adı:";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Soyadı:";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "İstifadəçi adı:";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Parol";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // BtnUpdateManager
            // 
            this.BtnUpdateManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnUpdateManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateManager.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateManager.Location = new System.Drawing.Point(959, 15);
            this.BtnUpdateManager.Name = "BtnUpdateManager";
            this.BtnUpdateManager.Size = new System.Drawing.Size(145, 48);
            this.BtnUpdateManager.TabIndex = 16;
            this.BtnUpdateManager.Text = "Yenilə";
            this.BtnUpdateManager.UseVisualStyleBackColor = false;
            this.BtnUpdateManager.Visible = false;
            this.BtnUpdateManager.Click += new System.EventHandler(this.BtnUpdateManager_Click);
            // 
            // BtnDeleteManager
            // 
            this.BtnDeleteManager.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeleteManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteManager.ForeColor = System.Drawing.Color.White;
            this.BtnDeleteManager.Location = new System.Drawing.Point(1145, 15);
            this.BtnDeleteManager.Name = "BtnDeleteManager";
            this.BtnDeleteManager.Size = new System.Drawing.Size(92, 48);
            this.BtnDeleteManager.TabIndex = 15;
            this.BtnDeleteManager.Text = "Sil";
            this.BtnDeleteManager.UseVisualStyleBackColor = false;
            this.BtnDeleteManager.Visible = false;
            this.BtnDeleteManager.Click += new System.EventHandler(this.BtnDeleteManager_Click);
            // 
            // BtnAddManager
            // 
            this.BtnAddManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BtnAddManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddManager.ForeColor = System.Drawing.Color.White;
            this.BtnAddManager.Location = new System.Drawing.Point(1042, 15);
            this.BtnAddManager.Name = "BtnAddManager";
            this.BtnAddManager.Size = new System.Drawing.Size(145, 48);
            this.BtnAddManager.TabIndex = 9;
            this.BtnAddManager.Text = "Əlavə et";
            this.BtnAddManager.UseVisualStyleBackColor = false;
            this.BtnAddManager.Click += new System.EventHandler(this.BtnAddManager_Click);
            // 
            // LblUnderPasswordManager
            // 
            this.LblUnderPasswordManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblUnderPasswordManager.Location = new System.Drawing.Point(711, 53);
            this.LblUnderPasswordManager.Name = "LblUnderPasswordManager";
            this.LblUnderPasswordManager.Size = new System.Drawing.Size(170, 5);
            this.LblUnderPasswordManager.TabIndex = 8;
            // 
            // LblUnderUsernameManager
            // 
            this.LblUnderUsernameManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblUnderUsernameManager.Location = new System.Drawing.Point(416, 53);
            this.LblUnderUsernameManager.Name = "LblUnderUsernameManager";
            this.LblUnderUsernameManager.Size = new System.Drawing.Size(261, 5);
            this.LblUnderUsernameManager.TabIndex = 6;
            // 
            // TxtUsernameManager
            // 
            this.TxtUsernameManager.AllowDrop = true;
            this.TxtUsernameManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsernameManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsernameManager.ForeColor = System.Drawing.Color.Silver;
            this.TxtUsernameManager.Location = new System.Drawing.Point(419, 23);
            this.TxtUsernameManager.Multiline = true;
            this.TxtUsernameManager.Name = "TxtUsernameManager";
            this.TxtUsernameManager.Size = new System.Drawing.Size(258, 24);
            this.TxtUsernameManager.TabIndex = 5;
            this.TxtUsernameManager.Text = "İstifadəçi adı";
            this.TxtUsernameManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUsernameManager.Enter += new System.EventHandler(this.TxtUsernameManager_Enter);
            this.TxtUsernameManager.Leave += new System.EventHandler(this.TxtUsernameManager_Leave);
            // 
            // LblUnderSurnameManager
            // 
            this.LblUnderSurnameManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblUnderSurnameManager.Location = new System.Drawing.Point(240, 53);
            this.LblUnderSurnameManager.Name = "LblUnderSurnameManager";
            this.LblUnderSurnameManager.Size = new System.Drawing.Size(133, 5);
            this.LblUnderSurnameManager.TabIndex = 4;
            // 
            // TxtSurnameManager
            // 
            this.TxtSurnameManager.AllowDrop = true;
            this.TxtSurnameManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSurnameManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurnameManager.ForeColor = System.Drawing.Color.Silver;
            this.TxtSurnameManager.Location = new System.Drawing.Point(245, 23);
            this.TxtSurnameManager.Multiline = true;
            this.TxtSurnameManager.Name = "TxtSurnameManager";
            this.TxtSurnameManager.Size = new System.Drawing.Size(127, 24);
            this.TxtSurnameManager.TabIndex = 3;
            this.TxtSurnameManager.Text = "Soyadı";
            this.TxtSurnameManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSurnameManager.Enter += new System.EventHandler(this.TxtSurnameManager_Enter);
            this.TxtSurnameManager.Leave += new System.EventHandler(this.TxtSurnameManager_Leave);
            // 
            // LblUnderNameManager
            // 
            this.LblUnderNameManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblUnderNameManager.Location = new System.Drawing.Point(35, 53);
            this.LblUnderNameManager.Name = "LblUnderNameManager";
            this.LblUnderNameManager.Size = new System.Drawing.Size(140, 5);
            this.LblUnderNameManager.TabIndex = 2;
            // 
            // TxtNameManager
            // 
            this.TxtNameManager.AllowDrop = true;
            this.TxtNameManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNameManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNameManager.ForeColor = System.Drawing.Color.Silver;
            this.TxtNameManager.Location = new System.Drawing.Point(38, 23);
            this.TxtNameManager.Multiline = true;
            this.TxtNameManager.Name = "TxtNameManager";
            this.TxtNameManager.Size = new System.Drawing.Size(137, 24);
            this.TxtNameManager.TabIndex = 1;
            this.TxtNameManager.Text = "İdarəçinin adı";
            this.TxtNameManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtNameManager.Enter += new System.EventHandler(this.TxtNameManager_Enter);
            this.TxtNameManager.Leave += new System.EventHandler(this.TxtNameManager_Leave);
            // 
            // MeanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 878);
            this.Controls.Add(this.PnlManagers);
            this.Controls.Add(this.PnlCustomers);
            this.Controls.Add(this.PnlBooks);
            this.Controls.Add(this.PnlOrders);
            this.Controls.Add(this.LblLibrary);
            this.Controls.Add(this.Pcrİcon);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MeanForm";
            this.Text = "MeanForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pcrİcon)).EndInit();
            this.PnlOrders.ResumeLayout(false);
            this.TabOrders.ResumeLayout(false);
            this.PnlBooks.ResumeLayout(false);
            this.PnlBooks.PerformLayout();
            this.PnlFilterBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.PnlCustomers.ResumeLayout(false);
            this.PnlCustomers.PerformLayout();
            this.PnlFilterCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            this.PnlManagers.ResumeLayout(false);
            this.PnlManagers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvManagers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pcrİcon;
        private System.Windows.Forms.Button BtnOrders;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button BtnBooks;
        private Button BtnManagers;
        private Button BtnCustomers;
        private Label LblLibrary;
        private Panel PnlOrders;
        private TabControl TabOrders;
        private TabPage tabPage1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private TabPage tabPage3;
        private Panel PnlBooks;
        private DataGridView DgvBooks;
        private Label LblUnderlinePriceBook;
        private TextBox TxtPriceBook;
        private Label LblUnderlineWritterBook;
        private TextBox TxtWritterBook;
        private Label LblUnderlineNameBook;
        private TextBox TxtNameBook;
        private Label LblUnderlineCountBook;
        private TextBox TxtCountBook;
        private Button BtnAddBook;
        private Label label5;
        private Button BtnUpdateBook;
        private Button BtnDeleteBook;
        private Label LblType;
        private ComboBox CbbFilterBooks;
        private Label LblFilter;
        private ComboBox CbbSortBooks;
        private Panel PnlCustomers;
        private ComboBox CbbSortCustomers;
        private Label label1;
        private Label label2;
        private ComboBox CbbFilterCustomers;
        private Button BtnUpdateCustomer;
        private Button BtnDeleteCustomer;
        private Button BtnAddCustomer;
        private Label LblUnderDateBirthCutomer;
        private Label LblUnderPhoneNumberCustomer;
        private TextBox TxtPhoneNumberCustomer;
        private Label LblUnderSurnameCustomer;
        private TextBox TxtSurnameCustomer;
        private Label LblUnderNameCustomer;
        private TextBox TxtNameCustomer;
        private DateTimePicker DtpDateBirth;
        private DataGridView DgvCustomers;
        private Label LblDateBirthCutomer;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column18;
        private Panel PnlManagers;
        private DataGridView DgvManagers;
        private Button BtnUpdateManager;
        private Button BtnDeleteManager;
        private Button BtnAddManager;
        private Label LblUnderPasswordManager;
        private Label LblUnderUsernameManager;
        private TextBox TxtUsernameManager;
        private Label LblUnderSurnameManager;
        private TextBox TxtSurnameManager;
        private Label LblUnderNameManager;
        private TextBox TxtNameManager;
        private TextBox TxtPasswordManager;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn Column8;
        private TabPage tabPage2;
        private Label label3;
        private TextBox TxtSearchBooks;
        private ComboBox CbbSearchBooks;
        private Label label4;
        private Panel PnlFilterBooks;
        private Label label6;
        private ComboBox CbbSearchCustomers;
        private Label label7;
        private TextBox TxtSearchCustomers;
        private Panel PnlFilterCustomers;
    }
}