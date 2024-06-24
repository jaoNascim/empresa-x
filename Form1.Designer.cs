namespace empresa_x
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            tabControl2 = new System.Windows.Forms.TabControl();
            tabPage3 = new System.Windows.Forms.TabPage();
            CreateCustomerButton = new System.Windows.Forms.Button();
            CreateCustomerEmail = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            CreateCustomerPhone = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            CreateCustomerAddress = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            CreateCustomerName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tabPage4 = new System.Windows.Forms.TabPage();
            UpdateCustomerEmail = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            UpdateCustomerButton = new System.Windows.Forms.Button();
            UpdateCustomerPhone = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            UpdateCustomerAddress = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            UpdateCustomerName = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            UpdateCustomerId = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            tabPage5 = new System.Windows.Forms.TabPage();
            DeleteCustomerIdCB = new System.Windows.Forms.ComboBox();
            DeleteCustomerButton = new System.Windows.Forms.Button();
            label11 = new System.Windows.Forms.Label();
            CustomerListView = new System.Windows.Forms.ListView();
            Id = new System.Windows.Forms.ColumnHeader();
            CustomerName = new System.Windows.Forms.ColumnHeader();
            Address = new System.Windows.Forms.ColumnHeader();
            Phone = new System.Windows.Forms.ColumnHeader();
            Email = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            tabPage2 = new System.Windows.Forms.TabPage();
            ProductListView = new System.Windows.Forms.ListView();
            ProductId = new System.Windows.Forms.ColumnHeader();
            ProductName = new System.Windows.Forms.ColumnHeader();
            ProductDesc = new System.Windows.Forms.ColumnHeader();
            ProductPrice = new System.Windows.Forms.ColumnHeader();
            ProductQty = new System.Windows.Forms.ColumnHeader();
            tabControl3 = new System.Windows.Forms.TabControl();
            tabPage6 = new System.Windows.Forms.TabPage();
            CreateProductButton = new System.Windows.Forms.Button();
            CreateProductQuantity = new System.Windows.Forms.TextBox();
            label12 = new System.Windows.Forms.Label();
            CreateProductPrice = new System.Windows.Forms.TextBox();
            label13 = new System.Windows.Forms.Label();
            CreateProductDescription = new System.Windows.Forms.TextBox();
            label14 = new System.Windows.Forms.Label();
            CreateProductName = new System.Windows.Forms.TextBox();
            label15 = new System.Windows.Forms.Label();
            tabPage7 = new System.Windows.Forms.TabPage();
            UpdateProductQuantity = new System.Windows.Forms.TextBox();
            label16 = new System.Windows.Forms.Label();
            UpdateProductButton = new System.Windows.Forms.Button();
            UpdateProductPrice = new System.Windows.Forms.TextBox();
            label17 = new System.Windows.Forms.Label();
            UpdateProductDescription = new System.Windows.Forms.TextBox();
            label18 = new System.Windows.Forms.Label();
            UpdateProductName = new System.Windows.Forms.TextBox();
            label19 = new System.Windows.Forms.Label();
            UpdateProductId = new System.Windows.Forms.TextBox();
            label20 = new System.Windows.Forms.Label();
            tabPage8 = new System.Windows.Forms.TabPage();
            DeleteProductIdCB = new System.Windows.Forms.ComboBox();
            DeleteProductButton = new System.Windows.Forms.Button();
            DeleteProductId = new System.Windows.Forms.TextBox();
            label21 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl3.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage8.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1173, 673);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabControl2);
            tabPage1.Controls.Add(CustomerListView);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(1165, 645);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customer Actions";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Location = new System.Drawing.Point(3, 281);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new System.Drawing.Size(544, 361);
            tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(CreateCustomerButton);
            tabPage3.Controls.Add(CreateCustomerEmail);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(CreateCustomerPhone);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(CreateCustomerAddress);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(CreateCustomerName);
            tabPage3.Controls.Add(label2);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(3);
            tabPage3.Size = new System.Drawing.Size(536, 333);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Create";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // CreateCustomerButton
            // 
            CreateCustomerButton.Location = new System.Drawing.Point(376, 284);
            CreateCustomerButton.Name = "CreateCustomerButton";
            CreateCustomerButton.Size = new System.Drawing.Size(154, 42);
            CreateCustomerButton.TabIndex = 8;
            CreateCustomerButton.Text = "CREATE";
            CreateCustomerButton.UseVisualStyleBackColor = true;
            CreateCustomerButton.Click += CreateCustomerButton_Click;
            // 
            // CreateCustomerEmail
            // 
            CreateCustomerEmail.Location = new System.Drawing.Point(5, 183);
            CreateCustomerEmail.Name = "CreateCustomerEmail";
            CreateCustomerEmail.Size = new System.Drawing.Size(524, 23);
            CreateCustomerEmail.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 165);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(39, 15);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // CreateCustomerPhone
            // 
            CreateCustomerPhone.Location = new System.Drawing.Point(5, 129);
            CreateCustomerPhone.Name = "CreateCustomerPhone";
            CreateCustomerPhone.Size = new System.Drawing.Size(524, 23);
            CreateCustomerPhone.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 111);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 15);
            label4.TabIndex = 4;
            label4.Text = "Phone:";
            // 
            // CreateCustomerAddress
            // 
            CreateCustomerAddress.Location = new System.Drawing.Point(5, 75);
            CreateCustomerAddress.Name = "CreateCustomerAddress";
            CreateCustomerAddress.Size = new System.Drawing.Size(524, 23);
            CreateCustomerAddress.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 57);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Address:";
            // 
            // CreateCustomerName
            // 
            CreateCustomerName.Location = new System.Drawing.Point(5, 21);
            CreateCustomerName.Name = "CreateCustomerName";
            CreateCustomerName.Size = new System.Drawing.Size(524, 23);
            CreateCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 3);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(42, 15);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(UpdateCustomerEmail);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(UpdateCustomerButton);
            tabPage4.Controls.Add(UpdateCustomerPhone);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(UpdateCustomerAddress);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(UpdateCustomerName);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(UpdateCustomerId);
            tabPage4.Controls.Add(label9);
            tabPage4.Location = new System.Drawing.Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(3);
            tabPage4.Size = new System.Drawing.Size(536, 333);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Update";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // UpdateCustomerEmail
            // 
            UpdateCustomerEmail.Location = new System.Drawing.Point(6, 239);
            UpdateCustomerEmail.Name = "UpdateCustomerEmail";
            UpdateCustomerEmail.Size = new System.Drawing.Size(524, 23);
            UpdateCustomerEmail.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(4, 221);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(39, 15);
            label10.TabIndex = 18;
            label10.Text = "Email:";
            // 
            // UpdateCustomerButton
            // 
            UpdateCustomerButton.Location = new System.Drawing.Point(378, 286);
            UpdateCustomerButton.Name = "UpdateCustomerButton";
            UpdateCustomerButton.Size = new System.Drawing.Size(154, 42);
            UpdateCustomerButton.TabIndex = 17;
            UpdateCustomerButton.Text = "UPDATE";
            UpdateCustomerButton.UseVisualStyleBackColor = true;
            UpdateCustomerButton.Click += UpdateCustomerButton_Click;
            // 
            // UpdateCustomerPhone
            // 
            UpdateCustomerPhone.Location = new System.Drawing.Point(6, 185);
            UpdateCustomerPhone.Name = "UpdateCustomerPhone";
            UpdateCustomerPhone.Size = new System.Drawing.Size(524, 23);
            UpdateCustomerPhone.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(4, 167);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(44, 15);
            label6.TabIndex = 15;
            label6.Text = "Phone:";
            // 
            // UpdateCustomerAddress
            // 
            UpdateCustomerAddress.Location = new System.Drawing.Point(6, 131);
            UpdateCustomerAddress.Name = "UpdateCustomerAddress";
            UpdateCustomerAddress.Size = new System.Drawing.Size(524, 23);
            UpdateCustomerAddress.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(4, 113);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(52, 15);
            label7.TabIndex = 13;
            label7.Text = "Address:";
            // 
            // UpdateCustomerName
            // 
            UpdateCustomerName.Location = new System.Drawing.Point(6, 77);
            UpdateCustomerName.Name = "UpdateCustomerName";
            UpdateCustomerName.Size = new System.Drawing.Size(524, 23);
            UpdateCustomerName.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(4, 59);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(42, 15);
            label8.TabIndex = 11;
            label8.Text = "Name:";
            // 
            // UpdateCustomerId
            // 
            UpdateCustomerId.Location = new System.Drawing.Point(6, 23);
            UpdateCustomerId.Name = "UpdateCustomerId";
            UpdateCustomerId.Size = new System.Drawing.Size(524, 23);
            UpdateCustomerId.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(4, 5);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(20, 15);
            label9.TabIndex = 9;
            label9.Text = "Id:";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(DeleteCustomerIdCB);
            tabPage5.Controls.Add(DeleteCustomerButton);
            tabPage5.Controls.Add(label11);
            tabPage5.Location = new System.Drawing.Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new System.Windows.Forms.Padding(3);
            tabPage5.Size = new System.Drawing.Size(536, 333);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Delete";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // DeleteCustomerIdCB
            // 
            DeleteCustomerIdCB.FormattingEnabled = true;
            DeleteCustomerIdCB.Location = new System.Drawing.Point(6, 23);
            DeleteCustomerIdCB.Name = "DeleteCustomerIdCB";
            DeleteCustomerIdCB.Size = new System.Drawing.Size(524, 23);
            DeleteCustomerIdCB.TabIndex = 21;
            // 
            // DeleteCustomerButton
            // 
            DeleteCustomerButton.Location = new System.Drawing.Point(378, 286);
            DeleteCustomerButton.Name = "DeleteCustomerButton";
            DeleteCustomerButton.Size = new System.Drawing.Size(154, 42);
            DeleteCustomerButton.TabIndex = 20;
            DeleteCustomerButton.Text = "DELETE";
            DeleteCustomerButton.UseVisualStyleBackColor = true;
            DeleteCustomerButton.Click += DeleteCustomerButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(4, 5);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(20, 15);
            label11.TabIndex = 18;
            label11.Text = "Id:";
            // 
            // CustomerListView
            // 
            CustomerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { Id, CustomerName, Address, Phone, Email });
            CustomerListView.Location = new System.Drawing.Point(553, 6);
            CustomerListView.Name = "CustomerListView";
            CustomerListView.Size = new System.Drawing.Size(606, 633);
            CustomerListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            CustomerListView.TabIndex = 1;
            CustomerListView.UseCompatibleStateImageBehavior = false;
            CustomerListView.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // CustomerName
            // 
            CustomerName.DisplayIndex = 4;
            CustomerName.Text = "Name";
            // 
            // Address
            // 
            Address.DisplayIndex = 1;
            Address.Text = "Address";
            Address.Width = 250;
            // 
            // Phone
            // 
            Phone.DisplayIndex = 2;
            Phone.Text = "Phone";
            Phone.Width = 80;
            // 
            // Email
            // 
            Email.DisplayIndex = 3;
            Email.Text = "Email";
            Email.Width = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(23, 109);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(505, 65);
            label1.TabIndex = 0;
            label1.Text = "CUSTOMER ACTIONS";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(ProductListView);
            tabPage2.Controls.Add(tabControl3);
            tabPage2.Controls.Add(label22);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(1165, 645);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Product Actions";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // ProductListView
            // 
            ProductListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { ProductId, ProductName, ProductDesc, ProductPrice, ProductQty });
            ProductListView.Location = new System.Drawing.Point(550, 6);
            ProductListView.Name = "ProductListView";
            ProductListView.Size = new System.Drawing.Size(609, 630);
            ProductListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            ProductListView.TabIndex = 6;
            ProductListView.UseCompatibleStateImageBehavior = false;
            ProductListView.View = System.Windows.Forms.View.Details;
            // 
            // ProductId
            // 
            ProductId.Text = "Id";
            // 
            // ProductName
            // 
            ProductName.Text = "Name";
            ProductName.Width = 100;
            // 
            // ProductDesc
            // 
            ProductDesc.Text = "Description";
            ProductDesc.Width = 250;
            // 
            // ProductPrice
            // 
            ProductPrice.Text = "Price";
            // 
            // ProductQty
            // 
            ProductQty.Text = "Quantity";
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(tabPage6);
            tabControl3.Controls.Add(tabPage7);
            tabControl3.Controls.Add(tabPage8);
            tabControl3.Location = new System.Drawing.Point(4, 279);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new System.Drawing.Size(544, 361);
            tabControl3.TabIndex = 5;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(CreateProductButton);
            tabPage6.Controls.Add(CreateProductQuantity);
            tabPage6.Controls.Add(label12);
            tabPage6.Controls.Add(CreateProductPrice);
            tabPage6.Controls.Add(label13);
            tabPage6.Controls.Add(CreateProductDescription);
            tabPage6.Controls.Add(label14);
            tabPage6.Controls.Add(CreateProductName);
            tabPage6.Controls.Add(label15);
            tabPage6.Location = new System.Drawing.Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new System.Windows.Forms.Padding(3);
            tabPage6.Size = new System.Drawing.Size(536, 333);
            tabPage6.TabIndex = 0;
            tabPage6.Text = "Create";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // CreateProductButton
            // 
            CreateProductButton.Location = new System.Drawing.Point(376, 284);
            CreateProductButton.Name = "CreateProductButton";
            CreateProductButton.Size = new System.Drawing.Size(154, 42);
            CreateProductButton.TabIndex = 8;
            CreateProductButton.Text = "CREATE";
            CreateProductButton.UseVisualStyleBackColor = true;
            CreateProductButton.Click += CreateProductButton_Click;
            // 
            // CreateProductQuantity
            // 
            CreateProductQuantity.Location = new System.Drawing.Point(5, 183);
            CreateProductQuantity.Name = "CreateProductQuantity";
            CreateProductQuantity.Size = new System.Drawing.Size(524, 23);
            CreateProductQuantity.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(6, 168);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(56, 15);
            label12.TabIndex = 6;
            label12.Text = "Quantity:";
            // 
            // CreateProductPrice
            // 
            CreateProductPrice.Location = new System.Drawing.Point(5, 129);
            CreateProductPrice.Name = "CreateProductPrice";
            CreateProductPrice.Size = new System.Drawing.Size(524, 23);
            CreateProductPrice.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(6, 114);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(36, 15);
            label13.TabIndex = 4;
            label13.Text = "Price:";
            // 
            // CreateProductDescription
            // 
            CreateProductDescription.Location = new System.Drawing.Point(5, 75);
            CreateProductDescription.Name = "CreateProductDescription";
            CreateProductDescription.Size = new System.Drawing.Size(524, 23);
            CreateProductDescription.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(6, 60);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(70, 15);
            label14.TabIndex = 2;
            label14.Text = "Description:";
            // 
            // CreateProductName
            // 
            CreateProductName.Location = new System.Drawing.Point(5, 21);
            CreateProductName.Name = "CreateProductName";
            CreateProductName.Size = new System.Drawing.Size(524, 23);
            CreateProductName.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(6, 6);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(42, 15);
            label15.TabIndex = 0;
            label15.Text = "Name:";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(UpdateProductQuantity);
            tabPage7.Controls.Add(label16);
            tabPage7.Controls.Add(UpdateProductButton);
            tabPage7.Controls.Add(UpdateProductPrice);
            tabPage7.Controls.Add(label17);
            tabPage7.Controls.Add(UpdateProductDescription);
            tabPage7.Controls.Add(label18);
            tabPage7.Controls.Add(UpdateProductName);
            tabPage7.Controls.Add(label19);
            tabPage7.Controls.Add(UpdateProductId);
            tabPage7.Controls.Add(label20);
            tabPage7.Location = new System.Drawing.Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new System.Windows.Forms.Padding(3);
            tabPage7.Size = new System.Drawing.Size(536, 333);
            tabPage7.TabIndex = 1;
            tabPage7.Text = "Update";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // UpdateProductQuantity
            // 
            UpdateProductQuantity.Location = new System.Drawing.Point(6, 239);
            UpdateProductQuantity.Name = "UpdateProductQuantity";
            UpdateProductQuantity.Size = new System.Drawing.Size(524, 23);
            UpdateProductQuantity.TabIndex = 19;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(7, 224);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(56, 15);
            label16.TabIndex = 18;
            label16.Text = "Quantity:";
            // 
            // UpdateProductButton
            // 
            UpdateProductButton.Location = new System.Drawing.Point(378, 286);
            UpdateProductButton.Name = "UpdateProductButton";
            UpdateProductButton.Size = new System.Drawing.Size(154, 42);
            UpdateProductButton.TabIndex = 17;
            UpdateProductButton.Text = "UPDATE";
            UpdateProductButton.UseVisualStyleBackColor = true;
            UpdateProductButton.Click += UpdateProductButton_Click;
            // 
            // UpdateProductPrice
            // 
            UpdateProductPrice.Location = new System.Drawing.Point(6, 185);
            UpdateProductPrice.Name = "UpdateProductPrice";
            UpdateProductPrice.Size = new System.Drawing.Size(524, 23);
            UpdateProductPrice.TabIndex = 16;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(7, 170);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(36, 15);
            label17.TabIndex = 15;
            label17.Text = "Price:";
            // 
            // UpdateProductDescription
            // 
            UpdateProductDescription.Location = new System.Drawing.Point(6, 131);
            UpdateProductDescription.Name = "UpdateProductDescription";
            UpdateProductDescription.Size = new System.Drawing.Size(524, 23);
            UpdateProductDescription.TabIndex = 14;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(7, 116);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(70, 15);
            label18.TabIndex = 13;
            label18.Text = "Description:";
            // 
            // UpdateProductName
            // 
            UpdateProductName.Location = new System.Drawing.Point(6, 77);
            UpdateProductName.Name = "UpdateProductName";
            UpdateProductName.Size = new System.Drawing.Size(524, 23);
            UpdateProductName.TabIndex = 12;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(7, 62);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(42, 15);
            label19.TabIndex = 11;
            label19.Text = "Name:";
            // 
            // UpdateProductId
            // 
            UpdateProductId.Location = new System.Drawing.Point(6, 23);
            UpdateProductId.Name = "UpdateProductId";
            UpdateProductId.Size = new System.Drawing.Size(524, 23);
            UpdateProductId.TabIndex = 10;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(7, 8);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(20, 15);
            label20.TabIndex = 9;
            label20.Text = "Id:";
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(DeleteProductIdCB);
            tabPage8.Controls.Add(DeleteProductButton);
            tabPage8.Controls.Add(DeleteProductId);
            tabPage8.Controls.Add(label21);
            tabPage8.Location = new System.Drawing.Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new System.Windows.Forms.Padding(3);
            tabPage8.Size = new System.Drawing.Size(536, 333);
            tabPage8.TabIndex = 2;
            tabPage8.Text = "Delete";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // DeleteProductIdCB
            // 
            DeleteProductIdCB.FormattingEnabled = true;
            DeleteProductIdCB.Location = new System.Drawing.Point(7, 52);
            DeleteProductIdCB.Name = "DeleteProductIdCB";
            DeleteProductIdCB.Size = new System.Drawing.Size(523, 23);
            DeleteProductIdCB.TabIndex = 21;
            // 
            // DeleteProductButton
            // 
            DeleteProductButton.Location = new System.Drawing.Point(378, 286);
            DeleteProductButton.Name = "DeleteProductButton";
            DeleteProductButton.Size = new System.Drawing.Size(154, 42);
            DeleteProductButton.TabIndex = 20;
            DeleteProductButton.Text = "DELETE";
            DeleteProductButton.UseVisualStyleBackColor = true;
            DeleteProductButton.Click += DeleteProductButton_Click;
            // 
            // DeleteProductId
            // 
            DeleteProductId.Location = new System.Drawing.Point(6, 23);
            DeleteProductId.Name = "DeleteProductId";
            DeleteProductId.Size = new System.Drawing.Size(524, 23);
            DeleteProductId.TabIndex = 19;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(7, 8);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(20, 15);
            label21.TabIndex = 18;
            label21.Text = "Id:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label22.Location = new System.Drawing.Point(38, 103);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(472, 65);
            label22.TabIndex = 3;
            label22.Text = "PRODUCT ACTIONS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1185, 685);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl3.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage8.ResumeLayout(false);
            tabPage8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button CreateCustomerButton;
        private System.Windows.Forms.TextBox CreateCustomerEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CreateCustomerPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CreateCustomerAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CreateCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView CustomerListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.TextBox UpdateCustomerEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button UpdateCustomerButton;
        private System.Windows.Forms.TextBox UpdateCustomerPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UpdateCustomerAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UpdateCustomerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox UpdateCustomerId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button DeleteCustomerButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button CreateProductButton;
        private System.Windows.Forms.TextBox CreateProductQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox CreateProductPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CreateProductDescription;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox CreateProductName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox UpdateProductQuantity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.TextBox UpdateProductPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox UpdateProductDescription;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox UpdateProductName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox UpdateProductId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.TextBox DeleteProductId;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ListView ProductListView;
        private System.Windows.Forms.ColumnHeader ProductId;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProductDesc;
        private System.Windows.Forms.ColumnHeader ProductPrice;
        private System.Windows.Forms.ColumnHeader ProductQty;
        private System.Windows.Forms.ComboBox DeleteProductIdCB;
        private System.Windows.Forms.ComboBox DeleteCustomerIdCB;
    }
}

