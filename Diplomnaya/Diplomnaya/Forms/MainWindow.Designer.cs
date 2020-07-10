namespace Diplomnaya
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.createApps = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductList = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.editProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.notsucc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.newOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SortBtn = new System.Windows.Forms.Button();
            this.ChooseBtn = new System.Windows.Forms.Button();
            this.SearchTxtBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 75);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(894, 390);
            this.dgv.TabIndex = 0;
            this.dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_RowHeaderMouseClick);
            // 
            // createApps
            // 
            this.createApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.createApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.createApps.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createApps.FlatAppearance.BorderSize = 0;
            this.createApps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createApps.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createApps.ForeColor = System.Drawing.Color.White;
            this.createApps.Location = new System.Drawing.Point(12, 500);
            this.createApps.Name = "createApps";
            this.createApps.Size = new System.Drawing.Size(150, 31);
            this.createApps.TabIndex = 3;
            this.createApps.Text = "Создать заявку";
            this.createApps.UseVisualStyleBackColor = false;
            this.createApps.Click += new System.EventHandler(this.createApp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ProductList);
            this.panel1.Controls.Add(this.addUser);
            this.panel1.Controls.Add(this.editProduct);
            this.panel1.Controls.Add(this.addProduct);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 37);
            this.panel1.TabIndex = 4;
            // 
            // ProductList
            // 
            this.ProductList.AutoSize = true;
            this.ProductList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.ProductList.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProductList.FlatAppearance.BorderSize = 0;
            this.ProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductList.ForeColor = System.Drawing.Color.White;
            this.ProductList.Location = new System.Drawing.Point(469, 0);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(127, 37);
            this.ProductList.TabIndex = 5;
            this.ProductList.Text = "Список товаров";
            this.ProductList.UseVisualStyleBackColor = false;
            this.ProductList.Click += new System.EventHandler(this.ProductList_Click);
            // 
            // addUser
            // 
            this.addUser.AutoSize = true;
            this.addUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.addUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.addUser.FlatAppearance.BorderSize = 0;
            this.addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUser.ForeColor = System.Drawing.Color.White;
            this.addUser.Location = new System.Drawing.Point(289, 0);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(180, 37);
            this.addUser.TabIndex = 4;
            this.addUser.Text = "Добавить пользователя";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // editProduct
            // 
            this.editProduct.AutoSize = true;
            this.editProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.editProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.editProduct.FlatAppearance.BorderSize = 0;
            this.editProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProduct.ForeColor = System.Drawing.Color.White;
            this.editProduct.Location = new System.Drawing.Point(126, 0);
            this.editProduct.Name = "editProduct";
            this.editProduct.Size = new System.Drawing.Size(163, 37);
            this.editProduct.TabIndex = 3;
            this.editProduct.Text = "Редактировать товар";
            this.editProduct.UseVisualStyleBackColor = false;
            this.editProduct.Click += new System.EventHandler(this.editProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.AutoSize = true;
            this.addProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.addProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.addProduct.FlatAppearance.BorderSize = 0;
            this.addProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProduct.ForeColor = System.Drawing.Color.White;
            this.addProduct.Location = new System.Drawing.Point(0, 0);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(126, 37);
            this.addProduct.TabIndex = 2;
            this.addProduct.Text = "Добавить товар";
            this.addProduct.UseVisualStyleBackColor = false;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(724, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 37);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 37);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(119, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 37);
            this.exit.TabIndex = 1;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // lblID
            // 
            this.lblID.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblID.Location = new System.Drawing.Point(98, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(68, 89);
            this.lblID.TabIndex = 5;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.notsucc);
            this.panel3.Controls.Add(this.lblID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.newOrder);
            this.panel3.Location = new System.Drawing.Point(532, 471);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 89);
            this.panel3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(224, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "* Произведётся печать";
            // 
            // notsucc
            // 
            this.notsucc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.notsucc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.notsucc.FlatAppearance.BorderSize = 0;
            this.notsucc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notsucc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notsucc.ForeColor = System.Drawing.Color.White;
            this.notsucc.Location = new System.Drawing.Point(221, 55);
            this.notsucc.Name = "notsucc";
            this.notsucc.Size = new System.Drawing.Size(150, 31);
            this.notsucc.TabIndex = 7;
            this.notsucc.Text = "Отменить";
            this.notsucc.UseVisualStyleBackColor = false;
            this.notsucc.Click += new System.EventHandler(this.notsucc_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 89);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID клиента:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newOrder
            // 
            this.newOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.newOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newOrder.FlatAppearance.BorderSize = 0;
            this.newOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrder.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newOrder.ForeColor = System.Drawing.Color.White;
            this.newOrder.Location = new System.Drawing.Point(221, 3);
            this.newOrder.Name = "newOrder";
            this.newOrder.Size = new System.Drawing.Size(150, 31);
            this.newOrder.TabIndex = 3;
            this.newOrder.Text = "Составить заказ";
            this.newOrder.UseVisualStyleBackColor = false;
            this.newOrder.Click += new System.EventHandler(this.newOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Поиск заявки по имени:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(-281, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 384);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // SortBtn
            // 
            this.SortBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortBtn.AutoSize = true;
            this.SortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.SortBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SortBtn.FlatAppearance.BorderSize = 0;
            this.SortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SortBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortBtn.ForeColor = System.Drawing.Color.White;
            this.SortBtn.Location = new System.Drawing.Point(802, 46);
            this.SortBtn.Name = "SortBtn";
            this.SortBtn.Size = new System.Drawing.Size(104, 26);
            this.SortBtn.TabIndex = 9;
            this.SortBtn.Text = "Сортировать";
            this.SortBtn.UseVisualStyleBackColor = false;
            this.SortBtn.Click += new System.EventHandler(this.SortBtn_Click);
            // 
            // ChooseBtn
            // 
            this.ChooseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseBtn.AutoSize = true;
            this.ChooseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(178)))), ((int)(((byte)(221)))));
            this.ChooseBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ChooseBtn.FlatAppearance.BorderSize = 0;
            this.ChooseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseBtn.ForeColor = System.Drawing.Color.White;
            this.ChooseBtn.Location = new System.Drawing.Point(714, 46);
            this.ChooseBtn.Name = "ChooseBtn";
            this.ChooseBtn.Size = new System.Drawing.Size(82, 26);
            this.ChooseBtn.TabIndex = 10;
            this.ChooseBtn.Text = "Обновить";
            this.ChooseBtn.UseVisualStyleBackColor = false;
            this.ChooseBtn.Click += new System.EventHandler(this.ChooseBtn_Click);
            // 
            // SearchTxtBox
            // 
            this.SearchTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTxtBox.Location = new System.Drawing.Point(192, 48);
            this.SearchTxtBox.Name = "SearchTxtBox";
            this.SearchTxtBox.Size = new System.Drawing.Size(516, 23);
            this.SearchTxtBox.TabIndex = 11;
            this.SearchTxtBox.TextChanged += new System.EventHandler(this.SearchTxtBox_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 572);
            this.Controls.Add(this.SearchTxtBox);
            this.Controls.Add(this.ChooseBtn);
            this.Controls.Add(this.SortBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createApps);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(934, 611);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ковровая Фабрика Орнамент";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button createApps;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Button editProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button notsucc;
        private System.Windows.Forms.Button ProductList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newOrder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SortBtn;
        private System.Windows.Forms.Button ChooseBtn;
        private System.Windows.Forms.TextBox SearchTxtBox;
    }
}