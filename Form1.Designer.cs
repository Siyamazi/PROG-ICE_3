namespace PROG_ICE_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txbID = new TextBox();
            comboName = new ComboBox();
            comboType = new ComboBox();
            comboQuantity = new ComboBox();
            txbTotal = new TextBox();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CoffeName = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            btnOrder = new Button();
            btnClear = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 24);
            label1.Name = "label1";
            label1.Size = new Size(148, 41);
            label1.TabIndex = 0;
            label1.Text = "Cafe App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 139);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 208);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 2;
            label3.Text = "Coffee Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 271);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 3;
            label4.Text = "Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 335);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 396);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 5;
            label6.Text = "Total Amount";
            // 
            // txbID
            // 
            txbID.Location = new Point(216, 145);
            txbID.Name = "txbID";
            txbID.Size = new Size(151, 27);
            txbID.TabIndex = 6;
            txbID.KeyPress += txbID_KeyPress;
            // 
            // comboName
            // 
            comboName.FormattingEnabled = true;
            comboName.Items.AddRange(new object[] { "Latte", "Cappuccino", "Chocolate" });
            comboName.Location = new Point(216, 207);
            comboName.Name = "comboName";
            comboName.Size = new Size(151, 28);
            comboName.TabIndex = 7;
            // 
            // comboType
            // 
            comboType.FormattingEnabled = true;
            comboType.Items.AddRange(new object[] { "Frappe", "Ice", "Hot" });
            comboType.Location = new Point(216, 271);
            comboType.Name = "comboType";
            comboType.Size = new Size(151, 28);
            comboType.TabIndex = 8;
            // 
            // comboQuantity
            // 
            comboQuantity.FormattingEnabled = true;
            comboQuantity.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboQuantity.Location = new Point(216, 327);
            comboQuantity.Name = "comboQuantity";
            comboQuantity.Size = new Size(151, 28);
            comboQuantity.TabIndex = 9;
            // 
            // txbTotal
            // 
            txbTotal.Location = new Point(216, 396);
            txbTotal.Name = "txbTotal";
            txbTotal.Size = new Size(151, 27);
            txbTotal.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, CoffeName, Type, Quantity, total });
            dataGridView1.Location = new Point(458, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 221);
            dataGridView1.TabIndex = 11;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // CoffeName
            // 
            CoffeName.HeaderText = "Coffe Name";
            CoffeName.MinimumWidth = 6;
            CoffeName.Name = "CoffeName";
            CoffeName.Width = 125;
            // 
            // Type
            // 
            Type.HeaderText = "Type";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.Width = 125;
            // 
            // total
            // 
            total.HeaderText = "Total Amount";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.Width = 125;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(485, 433);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 12;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(697, 433);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(999, 497);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 569);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnOrder);
            Controls.Add(dataGridView1);
            Controls.Add(txbTotal);
            Controls.Add(comboQuantity);
            Controls.Add(comboType);
            Controls.Add(comboName);
            Controls.Add(txbID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Type";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txbID;
        private ComboBox comboName;
        private ComboBox comboType;
        private ComboBox comboQuantity;
        private TextBox txbTotal;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CoffeName;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn total;
        private Button btnOrder;
        private Button btnClear;
        private Button btnClose;
    }
}
