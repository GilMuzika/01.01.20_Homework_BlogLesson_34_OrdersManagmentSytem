namespace _01._01._20_Homework_BlogLesson_34_OrdersManagmentSytem_
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
            this.tbnTabControl1 = new System.Windows.Forms.TabControl();
            this.tabExistingClient = new System.Windows.Forms.TabPage();
            this.pnlClientAlredySignedIn = new System.Windows.Forms.Panel();
            this.dgvCurrentClientOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.numAmountOfOrder = new System.Windows.Forms.NumericUpDown();
            this.btnOrderTheproduct = new System.Windows.Forms.Button();
            this.lblProductInfo = new System.Windows.Forms.Label();
            this.cmbAllTheProducts = new System.Windows.Forms.ComboBox();
            this.lblAllTheProducts = new System.Windows.Forms.Label();
            this.pnlClientSignIn = new System.Windows.Forms.Panel();
            this.lblSignInOrUp = new System.Windows.Forms.Label();
            this.btnSignInClient = new System.Windows.Forms.Button();
            this.lblLogInUserName = new System.Windows.Forms.Label();
            this.txtSignInPass = new System.Windows.Forms.TextBox();
            this.txtSingInUserName = new System.Windows.Forms.TextBox();
            this.lblSignInPass = new System.Windows.Forms.Label();
            this.tabNewClient = new System.Windows.Forms.TabPage();
            this.btnAddNewClient = new System.Windows.Forms.Button();
            this.pnlLongNumberCreatorPanel1 = new _01._01._20_Homework_BlogLesson_34_OrdersManagmentSytem_.pnlLongNumberCreatorPanel();
            this.lblCreditCard = new System.Windows.Forms.Label();
            this.txtClientFamily = new System.Windows.Forms.TextBox();
            this.lblClientFamily = new System.Windows.Forms.Label();
            this.txtRealUserName = new System.Windows.Forms.TextBox();
            this.lblRealNewClientName = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tabNewSupplier = new System.Windows.Forms.TabPage();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.txtSupplierCompanyName = new System.Windows.Forms.TextBox();
            this.lblSupplierCompanyname = new System.Windows.Forms.Label();
            this.txtSupplierPassword = new System.Windows.Forms.TextBox();
            this.lblSupplierPass = new System.Windows.Forms.Label();
            this.txtSupplieruserName = new System.Windows.Forms.TextBox();
            this.lblSupplierUserName = new System.Windows.Forms.Label();
            this.tabNewProduct = new System.Windows.Forms.TabPage();
            this.pnlSuppierSigningIn = new System.Windows.Forms.Panel();
            this.btnSupplierSignIN = new System.Windows.Forms.Button();
            this.txtPasswordSupplier = new System.Windows.Forms.TextBox();
            this.txtUserNameSupplier = new System.Windows.Forms.TextBox();
            this.lblPasswordSupplier = new System.Windows.Forms.Label();
            this.UserNameSupplier = new System.Windows.Forms.Label();
            this.pnlAddNewProduct = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbNewProductSuppliers = new System.Windows.Forms.ComboBox();
            this.numProductAmount = new System.Windows.Forms.NumericUpDown();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductAmount = new System.Windows.Forms.Label();
            this.txtProsuctName = new System.Windows.Forms.TextBox();
            this.numProductPrice = new System.Windows.Forms.NumericUpDown();
            this.lblProductSupplier = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.tabTrackingTableWiew = new System.Windows.Forms.TabPage();
            this.dgvTrackingTable = new System.Windows.Forms.DataGridView();
            this.tbnTabControl1.SuspendLayout();
            this.tabExistingClient.SuspendLayout();
            this.pnlClientAlredySignedIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentClientOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountOfOrder)).BeginInit();
            this.pnlClientSignIn.SuspendLayout();
            this.tabNewClient.SuspendLayout();
            this.tabNewSupplier.SuspendLayout();
            this.tabNewProduct.SuspendLayout();
            this.pnlSuppierSigningIn.SuspendLayout();
            this.pnlAddNewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).BeginInit();
            this.tabTrackingTableWiew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackingTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tbnTabControl1
            // 
            this.tbnTabControl1.Controls.Add(this.tabExistingClient);
            this.tbnTabControl1.Controls.Add(this.tabNewClient);
            this.tbnTabControl1.Controls.Add(this.tabNewSupplier);
            this.tbnTabControl1.Controls.Add(this.tabNewProduct);
            this.tbnTabControl1.Controls.Add(this.tabTrackingTableWiew);
            this.tbnTabControl1.Location = new System.Drawing.Point(2, 1);
            this.tbnTabControl1.Name = "tbnTabControl1";
            this.tbnTabControl1.SelectedIndex = 0;
            this.tbnTabControl1.Size = new System.Drawing.Size(802, 450);
            this.tbnTabControl1.TabIndex = 0;
            // 
            // tabExistingClient
            // 
            this.tabExistingClient.Controls.Add(this.pnlClientAlredySignedIn);
            this.tabExistingClient.Controls.Add(this.pnlClientSignIn);
            this.tabExistingClient.Location = new System.Drawing.Point(4, 22);
            this.tabExistingClient.Name = "tabExistingClient";
            this.tabExistingClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabExistingClient.Size = new System.Drawing.Size(794, 424);
            this.tabExistingClient.TabIndex = 0;
            this.tabExistingClient.Text = "ExistingClient";
            this.tabExistingClient.UseVisualStyleBackColor = true;
            // 
            // pnlClientAlredySignedIn
            // 
            this.pnlClientAlredySignedIn.Controls.Add(this.dgvCurrentClientOrders);
            this.pnlClientAlredySignedIn.Controls.Add(this.label1);
            this.pnlClientAlredySignedIn.Controls.Add(this.numAmountOfOrder);
            this.pnlClientAlredySignedIn.Controls.Add(this.btnOrderTheproduct);
            this.pnlClientAlredySignedIn.Controls.Add(this.lblProductInfo);
            this.pnlClientAlredySignedIn.Controls.Add(this.cmbAllTheProducts);
            this.pnlClientAlredySignedIn.Controls.Add(this.lblAllTheProducts);
            this.pnlClientAlredySignedIn.Location = new System.Drawing.Point(6, 6);
            this.pnlClientAlredySignedIn.Name = "pnlClientAlredySignedIn";
            this.pnlClientAlredySignedIn.Size = new System.Drawing.Size(776, 409);
            this.pnlClientAlredySignedIn.TabIndex = 7;
            // 
            // dgvCurrentClientOrders
            // 
            this.dgvCurrentClientOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentClientOrders.Location = new System.Drawing.Point(3, 194);
            this.dgvCurrentClientOrders.Name = "dgvCurrentClientOrders";
            this.dgvCurrentClientOrders.Size = new System.Drawing.Size(770, 206);
            this.dgvCurrentClientOrders.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "in amount:";
            // 
            // numAmountOfOrder
            // 
            this.numAmountOfOrder.Location = new System.Drawing.Point(203, 144);
            this.numAmountOfOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmountOfOrder.Name = "numAmountOfOrder";
            this.numAmountOfOrder.Size = new System.Drawing.Size(67, 20);
            this.numAmountOfOrder.TabIndex = 4;
            this.numAmountOfOrder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnOrderTheproduct
            // 
            this.btnOrderTheproduct.Location = new System.Drawing.Point(16, 141);
            this.btnOrderTheproduct.Name = "btnOrderTheproduct";
            this.btnOrderTheproduct.Size = new System.Drawing.Size(119, 23);
            this.btnOrderTheproduct.TabIndex = 3;
            this.btnOrderTheproduct.Text = "Order the product";
            this.btnOrderTheproduct.UseVisualStyleBackColor = true;
            this.btnOrderTheproduct.Click += new System.EventHandler(this.btnOrderTheproduct_Click);
            // 
            // lblProductInfo
            // 
            this.lblProductInfo.AutoSize = true;
            this.lblProductInfo.Location = new System.Drawing.Point(120, 49);
            this.lblProductInfo.Name = "lblProductInfo";
            this.lblProductInfo.Size = new System.Drawing.Size(35, 13);
            this.lblProductInfo.TabIndex = 2;
            this.lblProductInfo.Text = "label1";
            // 
            // cmbAllTheProducts
            // 
            this.cmbAllTheProducts.FormattingEnabled = true;
            this.cmbAllTheProducts.Location = new System.Drawing.Point(120, 9);
            this.cmbAllTheProducts.Name = "cmbAllTheProducts";
            this.cmbAllTheProducts.Size = new System.Drawing.Size(187, 21);
            this.cmbAllTheProducts.TabIndex = 1;
            this.cmbAllTheProducts.SelectedIndexChanged += new System.EventHandler(this.cmbAllTheProducts_SelectedIndexChanged);
            // 
            // lblAllTheProducts
            // 
            this.lblAllTheProducts.AutoSize = true;
            this.lblAllTheProducts.Location = new System.Drawing.Point(13, 17);
            this.lblAllTheProducts.Name = "lblAllTheProducts";
            this.lblAllTheProducts.Size = new System.Drawing.Size(83, 13);
            this.lblAllTheProducts.TabIndex = 0;
            this.lblAllTheProducts.Text = "All the products:";
            // 
            // pnlClientSignIn
            // 
            this.pnlClientSignIn.Controls.Add(this.lblSignInOrUp);
            this.pnlClientSignIn.Controls.Add(this.btnSignInClient);
            this.pnlClientSignIn.Controls.Add(this.lblLogInUserName);
            this.pnlClientSignIn.Controls.Add(this.txtSignInPass);
            this.pnlClientSignIn.Controls.Add(this.txtSingInUserName);
            this.pnlClientSignIn.Controls.Add(this.lblSignInPass);
            this.pnlClientSignIn.Location = new System.Drawing.Point(6, 6);
            this.pnlClientSignIn.Name = "pnlClientSignIn";
            this.pnlClientSignIn.Size = new System.Drawing.Size(284, 188);
            this.pnlClientSignIn.TabIndex = 6;
            // 
            // lblSignInOrUp
            // 
            this.lblSignInOrUp.AutoSize = true;
            this.lblSignInOrUp.Location = new System.Drawing.Point(13, 17);
            this.lblSignInOrUp.Name = "lblSignInOrUp";
            this.lblSignInOrUp.Size = new System.Drawing.Size(81, 13);
            this.lblSignInOrUp.TabIndex = 0;
            this.lblSignInOrUp.Text = "Please Sign In. ";
            // 
            // btnSignInClient
            // 
            this.btnSignInClient.Location = new System.Drawing.Point(19, 123);
            this.btnSignInClient.Name = "btnSignInClient";
            this.btnSignInClient.Size = new System.Drawing.Size(75, 23);
            this.btnSignInClient.TabIndex = 5;
            this.btnSignInClient.Text = "Sign In";
            this.btnSignInClient.UseVisualStyleBackColor = true;
            this.btnSignInClient.Click += new System.EventHandler(this.btnSignInClient_Click);
            // 
            // lblLogInUserName
            // 
            this.lblLogInUserName.AutoSize = true;
            this.lblLogInUserName.Location = new System.Drawing.Point(16, 49);
            this.lblLogInUserName.Name = "lblLogInUserName";
            this.lblLogInUserName.Size = new System.Drawing.Size(63, 13);
            this.lblLogInUserName.TabIndex = 1;
            this.lblLogInUserName.Text = "User Name:";
            // 
            // txtSignInPass
            // 
            this.txtSignInPass.Location = new System.Drawing.Point(95, 74);
            this.txtSignInPass.Name = "txtSignInPass";
            this.txtSignInPass.Size = new System.Drawing.Size(112, 20);
            this.txtSignInPass.TabIndex = 4;
            // 
            // txtSingInUserName
            // 
            this.txtSingInUserName.Location = new System.Drawing.Point(95, 41);
            this.txtSingInUserName.Name = "txtSingInUserName";
            this.txtSingInUserName.Size = new System.Drawing.Size(112, 20);
            this.txtSingInUserName.TabIndex = 2;
            // 
            // lblSignInPass
            // 
            this.lblSignInPass.AutoSize = true;
            this.lblSignInPass.Location = new System.Drawing.Point(16, 81);
            this.lblSignInPass.Name = "lblSignInPass";
            this.lblSignInPass.Size = new System.Drawing.Size(59, 13);
            this.lblSignInPass.TabIndex = 3;
            this.lblSignInPass.Text = "Password: ";
            // 
            // tabNewClient
            // 
            this.tabNewClient.Controls.Add(this.btnAddNewClient);
            this.tabNewClient.Controls.Add(this.pnlLongNumberCreatorPanel1);
            this.tabNewClient.Controls.Add(this.lblCreditCard);
            this.tabNewClient.Controls.Add(this.txtClientFamily);
            this.tabNewClient.Controls.Add(this.lblClientFamily);
            this.tabNewClient.Controls.Add(this.txtRealUserName);
            this.tabNewClient.Controls.Add(this.lblRealNewClientName);
            this.tabNewClient.Controls.Add(this.txtNewPassword);
            this.tabNewClient.Controls.Add(this.lblPassword);
            this.tabNewClient.Controls.Add(this.txtNewUserName);
            this.tabNewClient.Controls.Add(this.lblUserName);
            this.tabNewClient.Location = new System.Drawing.Point(4, 22);
            this.tabNewClient.Name = "tabNewClient";
            this.tabNewClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewClient.Size = new System.Drawing.Size(794, 424);
            this.tabNewClient.TabIndex = 1;
            this.tabNewClient.Text = "New Client";
            this.tabNewClient.UseVisualStyleBackColor = true;
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.Location = new System.Drawing.Point(9, 259);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(103, 23);
            this.btnAddNewClient.TabIndex = 10;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.UseVisualStyleBackColor = true;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // pnlLongNumberCreatorPanel1
            // 
            this.pnlLongNumberCreatorPanel1.Location = new System.Drawing.Point(6, 214);
            this.pnlLongNumberCreatorPanel1.Name = "pnlLongNumberCreatorPanel1";
            this.pnlLongNumberCreatorPanel1.NumberOfCombos = 8;
            this.pnlLongNumberCreatorPanel1.RandomInitialValue = true;
            this.pnlLongNumberCreatorPanel1.Size = new System.Drawing.Size(247, 21);
            this.pnlLongNumberCreatorPanel1.SplitToSections = true;
            this.pnlLongNumberCreatorPanel1.TabIndex = 9;
            // 
            // lblCreditCard
            // 
            this.lblCreditCard.AutoSize = true;
            this.lblCreditCard.Location = new System.Drawing.Point(6, 198);
            this.lblCreditCard.Name = "lblCreditCard";
            this.lblCreditCard.Size = new System.Drawing.Size(68, 13);
            this.lblCreditCard.TabIndex = 8;
            this.lblCreditCard.Text = "Creadit Card:";
            // 
            // txtClientFamily
            // 
            this.txtClientFamily.Location = new System.Drawing.Point(112, 156);
            this.txtClientFamily.Name = "txtClientFamily";
            this.txtClientFamily.Size = new System.Drawing.Size(100, 20);
            this.txtClientFamily.TabIndex = 7;
            // 
            // lblClientFamily
            // 
            this.lblClientFamily.AutoSize = true;
            this.lblClientFamily.Location = new System.Drawing.Point(28, 163);
            this.lblClientFamily.Name = "lblClientFamily";
            this.lblClientFamily.Size = new System.Drawing.Size(39, 13);
            this.lblClientFamily.TabIndex = 6;
            this.lblClientFamily.Text = "Family:";
            // 
            // txtRealUserName
            // 
            this.txtRealUserName.Location = new System.Drawing.Point(112, 117);
            this.txtRealUserName.Name = "txtRealUserName";
            this.txtRealUserName.Size = new System.Drawing.Size(100, 20);
            this.txtRealUserName.TabIndex = 5;
            // 
            // lblRealNewClientName
            // 
            this.lblRealNewClientName.AutoSize = true;
            this.lblRealNewClientName.Location = new System.Drawing.Point(28, 125);
            this.lblRealNewClientName.Name = "lblRealNewClientName";
            this.lblRealNewClientName.Size = new System.Drawing.Size(63, 13);
            this.lblRealNewClientName.TabIndex = 4;
            this.lblRealNewClientName.Text = "Real Name:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(112, 66);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(100, 20);
            this.txtNewPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(28, 73);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.Location = new System.Drawing.Point(112, 35);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(100, 20);
            this.txtNewUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(28, 42);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name:";
            // 
            // tabNewSupplier
            // 
            this.tabNewSupplier.Controls.Add(this.btnAddSupplier);
            this.tabNewSupplier.Controls.Add(this.txtSupplierCompanyName);
            this.tabNewSupplier.Controls.Add(this.lblSupplierCompanyname);
            this.tabNewSupplier.Controls.Add(this.txtSupplierPassword);
            this.tabNewSupplier.Controls.Add(this.lblSupplierPass);
            this.tabNewSupplier.Controls.Add(this.txtSupplieruserName);
            this.tabNewSupplier.Controls.Add(this.lblSupplierUserName);
            this.tabNewSupplier.Location = new System.Drawing.Point(4, 22);
            this.tabNewSupplier.Name = "tabNewSupplier";
            this.tabNewSupplier.Size = new System.Drawing.Size(794, 424);
            this.tabNewSupplier.TabIndex = 2;
            this.tabNewSupplier.Text = "New Suppplier";
            this.tabNewSupplier.UseVisualStyleBackColor = true;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(29, 132);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnAddSupplier.TabIndex = 6;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // txtSupplierCompanyName
            // 
            this.txtSupplierCompanyName.Location = new System.Drawing.Point(110, 79);
            this.txtSupplierCompanyName.Name = "txtSupplierCompanyName";
            this.txtSupplierCompanyName.Size = new System.Drawing.Size(118, 20);
            this.txtSupplierCompanyName.TabIndex = 5;
            // 
            // lblSupplierCompanyname
            // 
            this.lblSupplierCompanyname.AutoSize = true;
            this.lblSupplierCompanyname.Location = new System.Drawing.Point(15, 87);
            this.lblSupplierCompanyname.Name = "lblSupplierCompanyname";
            this.lblSupplierCompanyname.Size = new System.Drawing.Size(85, 13);
            this.lblSupplierCompanyname.TabIndex = 4;
            this.lblSupplierCompanyname.Text = "Company Name:";
            // 
            // txtSupplierPassword
            // 
            this.txtSupplierPassword.Location = new System.Drawing.Point(110, 49);
            this.txtSupplierPassword.Name = "txtSupplierPassword";
            this.txtSupplierPassword.Size = new System.Drawing.Size(118, 20);
            this.txtSupplierPassword.TabIndex = 3;
            // 
            // lblSupplierPass
            // 
            this.lblSupplierPass.AutoSize = true;
            this.lblSupplierPass.Location = new System.Drawing.Point(15, 56);
            this.lblSupplierPass.Name = "lblSupplierPass";
            this.lblSupplierPass.Size = new System.Drawing.Size(51, 13);
            this.lblSupplierPass.TabIndex = 2;
            this.lblSupplierPass.Text = "Pasword:";
            // 
            // txtSupplieruserName
            // 
            this.txtSupplieruserName.Location = new System.Drawing.Point(110, 19);
            this.txtSupplieruserName.Name = "txtSupplieruserName";
            this.txtSupplieruserName.Size = new System.Drawing.Size(118, 20);
            this.txtSupplieruserName.TabIndex = 1;
            // 
            // lblSupplierUserName
            // 
            this.lblSupplierUserName.AutoSize = true;
            this.lblSupplierUserName.Location = new System.Drawing.Point(15, 26);
            this.lblSupplierUserName.Name = "lblSupplierUserName";
            this.lblSupplierUserName.Size = new System.Drawing.Size(61, 13);
            this.lblSupplierUserName.TabIndex = 0;
            this.lblSupplierUserName.Text = "User name:";
            // 
            // tabNewProduct
            // 
            this.tabNewProduct.Controls.Add(this.pnlSuppierSigningIn);
            this.tabNewProduct.Controls.Add(this.pnlAddNewProduct);
            this.tabNewProduct.Location = new System.Drawing.Point(4, 22);
            this.tabNewProduct.Name = "tabNewProduct";
            this.tabNewProduct.Size = new System.Drawing.Size(794, 424);
            this.tabNewProduct.TabIndex = 3;
            this.tabNewProduct.Text = "ExistingSupplier";
            this.tabNewProduct.UseVisualStyleBackColor = true;
            // 
            // pnlSuppierSigningIn
            // 
            this.pnlSuppierSigningIn.Controls.Add(this.btnSupplierSignIN);
            this.pnlSuppierSigningIn.Controls.Add(this.txtPasswordSupplier);
            this.pnlSuppierSigningIn.Controls.Add(this.txtUserNameSupplier);
            this.pnlSuppierSigningIn.Controls.Add(this.lblPasswordSupplier);
            this.pnlSuppierSigningIn.Controls.Add(this.UserNameSupplier);
            this.pnlSuppierSigningIn.Location = new System.Drawing.Point(6, 3);
            this.pnlSuppierSigningIn.Name = "pnlSuppierSigningIn";
            this.pnlSuppierSigningIn.Size = new System.Drawing.Size(275, 230);
            this.pnlSuppierSigningIn.TabIndex = 11;
            // 
            // btnSupplierSignIN
            // 
            this.btnSupplierSignIN.Location = new System.Drawing.Point(9, 91);
            this.btnSupplierSignIN.Name = "btnSupplierSignIN";
            this.btnSupplierSignIN.Size = new System.Drawing.Size(98, 23);
            this.btnSupplierSignIN.TabIndex = 4;
            this.btnSupplierSignIN.Text = "Sugn In";
            this.btnSupplierSignIN.UseVisualStyleBackColor = true;
            this.btnSupplierSignIN.Click += new System.EventHandler(this.btnSupplierSignIN_Click);
            // 
            // txtPasswordSupplier
            // 
            this.txtPasswordSupplier.Location = new System.Drawing.Point(131, 35);
            this.txtPasswordSupplier.Name = "txtPasswordSupplier";
            this.txtPasswordSupplier.Size = new System.Drawing.Size(128, 20);
            this.txtPasswordSupplier.TabIndex = 3;
            // 
            // txtUserNameSupplier
            // 
            this.txtUserNameSupplier.Location = new System.Drawing.Point(131, 9);
            this.txtUserNameSupplier.Name = "txtUserNameSupplier";
            this.txtUserNameSupplier.Size = new System.Drawing.Size(128, 20);
            this.txtUserNameSupplier.TabIndex = 2;
            // 
            // lblPasswordSupplier
            // 
            this.lblPasswordSupplier.AutoSize = true;
            this.lblPasswordSupplier.Location = new System.Drawing.Point(6, 42);
            this.lblPasswordSupplier.Name = "lblPasswordSupplier";
            this.lblPasswordSupplier.Size = new System.Drawing.Size(97, 13);
            this.lblPasswordSupplier.TabIndex = 1;
            this.lblPasswordSupplier.Text = "Supplier Password:";
            // 
            // UserNameSupplier
            // 
            this.UserNameSupplier.AutoSize = true;
            this.UserNameSupplier.Location = new System.Drawing.Point(3, 9);
            this.UserNameSupplier.Name = "UserNameSupplier";
            this.UserNameSupplier.Size = new System.Drawing.Size(104, 13);
            this.UserNameSupplier.TabIndex = 0;
            this.UserNameSupplier.Text = "Supplier User Name:";
            // 
            // pnlAddNewProduct
            // 
            this.pnlAddNewProduct.Controls.Add(this.btnAddProduct);
            this.pnlAddNewProduct.Controls.Add(this.cmbNewProductSuppliers);
            this.pnlAddNewProduct.Controls.Add(this.numProductAmount);
            this.pnlAddNewProduct.Controls.Add(this.lblProductName);
            this.pnlAddNewProduct.Controls.Add(this.lblProductAmount);
            this.pnlAddNewProduct.Controls.Add(this.txtProsuctName);
            this.pnlAddNewProduct.Controls.Add(this.numProductPrice);
            this.pnlAddNewProduct.Controls.Add(this.lblProductSupplier);
            this.pnlAddNewProduct.Controls.Add(this.lblProductPrice);
            this.pnlAddNewProduct.Location = new System.Drawing.Point(287, 3);
            this.pnlAddNewProduct.Name = "pnlAddNewProduct";
            this.pnlAddNewProduct.Size = new System.Drawing.Size(504, 418);
            this.pnlAddNewProduct.TabIndex = 10;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(17, 157);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(112, 23);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "Addd Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbNewProductSuppliers
            // 
            this.cmbNewProductSuppliers.FormattingEnabled = true;
            this.cmbNewProductSuppliers.Location = new System.Drawing.Point(111, 35);
            this.cmbNewProductSuppliers.Name = "cmbNewProductSuppliers";
            this.cmbNewProductSuppliers.Size = new System.Drawing.Size(175, 21);
            this.cmbNewProductSuppliers.TabIndex = 1;
            // 
            // numProductAmount
            // 
            this.numProductAmount.Location = new System.Drawing.Point(145, 105);
            this.numProductAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numProductAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProductAmount.Name = "numProductAmount";
            this.numProductAmount.Size = new System.Drawing.Size(64, 20);
            this.numProductAmount.TabIndex = 8;
            this.numProductAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(11, 12);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProductAmount
            // 
            this.lblProductAmount.AutoSize = true;
            this.lblProductAmount.Location = new System.Drawing.Point(11, 112);
            this.lblProductAmount.Name = "lblProductAmount";
            this.lblProductAmount.Size = new System.Drawing.Size(118, 13);
            this.lblProductAmount.TabIndex = 7;
            this.lblProductAmount.Text = "Amount of the product: ";
            // 
            // txtProsuctName
            // 
            this.txtProsuctName.Location = new System.Drawing.Point(111, 9);
            this.txtProsuctName.Name = "txtProsuctName";
            this.txtProsuctName.Size = new System.Drawing.Size(175, 20);
            this.txtProsuctName.TabIndex = 3;
            // 
            // numProductPrice
            // 
            this.numProductPrice.Location = new System.Drawing.Point(111, 74);
            this.numProductPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numProductPrice.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numProductPrice.Name = "numProductPrice";
            this.numProductPrice.Size = new System.Drawing.Size(76, 20);
            this.numProductPrice.TabIndex = 6;
            this.numProductPrice.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblProductSupplier
            // 
            this.lblProductSupplier.AutoSize = true;
            this.lblProductSupplier.Location = new System.Drawing.Point(11, 43);
            this.lblProductSupplier.Name = "lblProductSupplier";
            this.lblProductSupplier.Size = new System.Drawing.Size(88, 13);
            this.lblProductSupplier.TabIndex = 4;
            this.lblProductSupplier.Text = "Product Supplier:";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(14, 81);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(74, 13);
            this.lblProductPrice.TabIndex = 5;
            this.lblProductPrice.Text = "Product Price:";
            // 
            // tabTrackingTableWiew
            // 
            this.tabTrackingTableWiew.Controls.Add(this.dgvTrackingTable);
            this.tabTrackingTableWiew.Location = new System.Drawing.Point(4, 22);
            this.tabTrackingTableWiew.Name = "tabTrackingTableWiew";
            this.tabTrackingTableWiew.Size = new System.Drawing.Size(794, 424);
            this.tabTrackingTableWiew.TabIndex = 4;
            this.tabTrackingTableWiew.Text = "תצוגת טבלת מעקב";
            this.tabTrackingTableWiew.UseVisualStyleBackColor = true;
            // 
            // dgvTrackingTable
            // 
            this.dgvTrackingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrackingTable.Location = new System.Drawing.Point(17, 18);
            this.dgvTrackingTable.Name = "dgvTrackingTable";
            this.dgvTrackingTable.Size = new System.Drawing.Size(753, 378);
            this.dgvTrackingTable.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbnTabControl1);
            this.Name = "MainForm";
            this.Text = "מערכת ניהול הזמנות";
            this.tbnTabControl1.ResumeLayout(false);
            this.tabExistingClient.ResumeLayout(false);
            this.pnlClientAlredySignedIn.ResumeLayout(false);
            this.pnlClientAlredySignedIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentClientOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountOfOrder)).EndInit();
            this.pnlClientSignIn.ResumeLayout(false);
            this.pnlClientSignIn.PerformLayout();
            this.tabNewClient.ResumeLayout(false);
            this.tabNewClient.PerformLayout();
            this.tabNewSupplier.ResumeLayout(false);
            this.tabNewSupplier.PerformLayout();
            this.tabNewProduct.ResumeLayout(false);
            this.pnlSuppierSigningIn.ResumeLayout(false);
            this.pnlSuppierSigningIn.PerformLayout();
            this.pnlAddNewProduct.ResumeLayout(false);
            this.pnlAddNewProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProductPrice)).EndInit();
            this.tabTrackingTableWiew.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrackingTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbnTabControl1;
        private System.Windows.Forms.TabPage tabExistingClient;
        private System.Windows.Forms.TabPage tabNewClient;
        private System.Windows.Forms.Label lblRealNewClientName;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtNewUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtClientFamily;
        private System.Windows.Forms.Label lblClientFamily;
        private System.Windows.Forms.TextBox txtRealUserName;
        private System.Windows.Forms.Label lblCreditCard;
        private pnlLongNumberCreatorPanel pnlLongNumberCreatorPanel1;
        private System.Windows.Forms.Button btnAddNewClient;
        private System.Windows.Forms.TabPage tabNewSupplier;
        private System.Windows.Forms.TextBox txtSupplierCompanyName;
        private System.Windows.Forms.Label lblSupplierCompanyname;
        private System.Windows.Forms.TextBox txtSupplierPassword;
        private System.Windows.Forms.Label lblSupplierPass;
        private System.Windows.Forms.TextBox txtSupplieruserName;
        private System.Windows.Forms.Label lblSupplierUserName;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.TabPage tabNewProduct;
        private System.Windows.Forms.ComboBox cmbNewProductSuppliers;
        private System.Windows.Forms.TextBox txtProsuctName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductSupplier;
        private System.Windows.Forms.NumericUpDown numProductPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.NumericUpDown numProductAmount;
        private System.Windows.Forms.Label lblProductAmount;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Panel pnlClientSignIn;
        private System.Windows.Forms.Label lblSignInOrUp;
        private System.Windows.Forms.Button btnSignInClient;
        private System.Windows.Forms.Label lblLogInUserName;
        private System.Windows.Forms.TextBox txtSignInPass;
        private System.Windows.Forms.TextBox txtSingInUserName;
        private System.Windows.Forms.Label lblSignInPass;
        private System.Windows.Forms.Panel pnlClientAlredySignedIn;
        private System.Windows.Forms.ComboBox cmbAllTheProducts;
        private System.Windows.Forms.Label lblAllTheProducts;
        private System.Windows.Forms.Label lblProductInfo;
        private System.Windows.Forms.Button btnOrderTheproduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAmountOfOrder;
        private System.Windows.Forms.DataGridView dgvCurrentClientOrders;
        private System.Windows.Forms.Panel pnlSuppierSigningIn;
        private System.Windows.Forms.Button btnSupplierSignIN;
        private System.Windows.Forms.TextBox txtPasswordSupplier;
        private System.Windows.Forms.TextBox txtUserNameSupplier;
        private System.Windows.Forms.Label lblPasswordSupplier;
        private System.Windows.Forms.Label UserNameSupplier;
        private System.Windows.Forms.Panel pnlAddNewProduct;
        private System.Windows.Forms.TabPage tabTrackingTableWiew;
        private System.Windows.Forms.DataGridView dgvTrackingTable;
    }
}

