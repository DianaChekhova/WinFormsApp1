namespace WinFormsApp1
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
            ElementdataGridView = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            FindLabel = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            deleteRowButton = new Button();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            RefreshButton = new Button();
            addButton = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label1 = new Label();
            NameTextBox = new TextBox();
            flowLayoutPanel5 = new FlowLayoutPanel();
            label3 = new Label();
            LatinNameTextBox = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label4 = new Label();
            SybmolTextBox = new TextBox();
            flowLayoutPanel7 = new FlowLayoutPanel();
            label5 = new Label();
            AtomicMassTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ElementdataGridView).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // ElementdataGridView
            // 
            ElementdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ElementdataGridView.Location = new Point(12, 12);
            ElementdataGridView.Name = "ElementdataGridView";
            ElementdataGridView.Size = new Size(432, 644);
            ElementdataGridView.TabIndex = 0;
            ElementdataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Location = new Point(441, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 24.2236023F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 75.7764F));
            tableLayoutPanel2.Size = new Size(622, 644);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.Controls.Add(FindLabel);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(259, 113);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Имя", "Латинское имя", "Символ", "Атомная масса" });
            comboBox1.Location = new Point(3, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 23);
            comboBox1.TabIndex = 1;
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Font = new Font("Segoe UI", 14F);
            FindLabel.Location = new Point(3, 58);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(159, 25);
            FindLabel.TabIndex = 2;
            FindLabel.Text = "Поиск по ячейке";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(deleteRowButton);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Location = new Point(314, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(267, 113);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // deleteRowButton
            // 
            deleteRowButton.Font = new Font("Segoe UI", 14F);
            deleteRowButton.Location = new Point(3, 3);
            deleteRowButton.Name = "deleteRowButton";
            deleteRowButton.Size = new Size(264, 41);
            deleteRowButton.TabIndex = 0;
            deleteRowButton.Text = "Удаление";
            deleteRowButton.UseVisualStyleBackColor = true;
            deleteRowButton.Click += deleteRowButton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(3, 47);
            label2.Name = "label2";
            label2.Size = new Size(204, 50);
            label2.TabIndex = 3;
            label2.Text = "Удаление выбранной ячейки";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(RefreshButton, 0, 2);
            tableLayoutPanel1.Controls.Add(addButton, 1, 2);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel5, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel6, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel7, 1, 1);
            tableLayoutPanel1.Location = new Point(3, 159);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 270F));
            tableLayoutPanel1.Size = new Size(305, 482);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // RefreshButton
            // 
            RefreshButton.Font = new Font("Segoe UI", 14F);
            RefreshButton.Location = new Point(3, 215);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(146, 133);
            RefreshButton.TabIndex = 4;
            RefreshButton.Text = "Обновить";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += button1_Click_1;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addButton.Location = new Point(155, 215);
            addButton.Name = "addButton";
            addButton.Size = new Size(147, 133);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label1);
            flowLayoutPanel4.Controls.Add(NameTextBox);
            flowLayoutPanel4.Location = new Point(3, 3);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(146, 100);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 3;
            label1.Text = "Имя";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(3, 28);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(100, 23);
            NameTextBox.TabIndex = 4;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(label3);
            flowLayoutPanel5.Controls.Add(LatinNameTextBox);
            flowLayoutPanel5.Location = new Point(155, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(147, 100);
            flowLayoutPanel5.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(109, 50);
            label3.TabIndex = 3;
            label3.Text = "Латинское имя";
            // 
            // LatinNameTextBox
            // 
            LatinNameTextBox.Location = new Point(3, 53);
            LatinNameTextBox.Name = "LatinNameTextBox";
            LatinNameTextBox.Size = new Size(100, 23);
            LatinNameTextBox.TabIndex = 5;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(label4);
            flowLayoutPanel6.Controls.Add(SybmolTextBox);
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Location = new Point(3, 109);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(146, 100);
            flowLayoutPanel6.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 3;
            label4.Text = "Символ";
            // 
            // SybmolTextBox
            // 
            SybmolTextBox.Location = new Point(3, 28);
            SybmolTextBox.Name = "SybmolTextBox";
            SybmolTextBox.Size = new Size(100, 23);
            SybmolTextBox.TabIndex = 5;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Controls.Add(label5);
            flowLayoutPanel7.Controls.Add(AtomicMassTextBox);
            flowLayoutPanel7.Location = new Point(155, 109);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(147, 100);
            flowLayoutPanel7.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(92, 50);
            label5.TabIndex = 3;
            label5.Text = "Атомная масса";
            // 
            // AtomicMassTextBox
            // 
            AtomicMassTextBox.Location = new Point(3, 53);
            AtomicMassTextBox.Name = "AtomicMassTextBox";
            AtomicMassTextBox.Size = new Size(100, 23);
            AtomicMassTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 684);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(ElementdataGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ElementdataGridView).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel5.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ElementdataGridView;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label FindLabel;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button deleteRowButton;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button addButton;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label5;
        private TextBox NameTextBox;
        private TextBox LatinNameTextBox;
        private TextBox SybmolTextBox;
        private TextBox AtomicMassTextBox;
        private Label label7;
        private Button RefreshButton;
    }
}
