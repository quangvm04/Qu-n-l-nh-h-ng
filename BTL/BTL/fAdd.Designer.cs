namespace BTL
{
    partial class fAdd
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
            this.lbTenNL = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbCP = new System.Windows.Forms.Label();
            this.tbTenNL = new System.Windows.Forms.TextBox();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.tbCP = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbTenNL
            // 
            this.lbTenNL.AutoSize = true;
            this.lbTenNL.Location = new System.Drawing.Point(26, 34);
            this.lbTenNL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTenNL.Name = "lbTenNL";
            this.lbTenNL.Size = new System.Drawing.Size(152, 25);
            this.lbTenNL.TabIndex = 0;
            this.lbTenNL.Text = "Tên nguyên liệu";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Location = new System.Drawing.Point(26, 98);
            this.lbSL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(90, 25);
            this.lbSL.TabIndex = 1;
            this.lbSL.Text = "Số lượng";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Location = new System.Drawing.Point(26, 173);
            this.lbNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(58, 25);
            this.lbNgay.TabIndex = 2;
            this.lbNgay.Text = "Ngày";
            // 
            // lbCP
            // 
            this.lbCP.AutoSize = true;
            this.lbCP.Location = new System.Drawing.Point(26, 239);
            this.lbCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCP.Name = "lbCP";
            this.lbCP.Size = new System.Drawing.Size(73, 25);
            this.lbCP.TabIndex = 3;
            this.lbCP.Text = "Chi phí";
            // 
            // tbTenNL
            // 
            this.tbTenNL.Location = new System.Drawing.Point(217, 31);
            this.tbTenNL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTenNL.Name = "tbTenNL";
            this.tbTenNL.Size = new System.Drawing.Size(255, 30);
            this.tbTenNL.TabIndex = 4;
            // 
            // tbSL
            // 
            this.tbSL.Location = new System.Drawing.Point(217, 98);
            this.tbSL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSL.Name = "tbSL";
            this.tbSL.Size = new System.Drawing.Size(255, 30);
            this.tbSL.TabIndex = 5;
            // 
            // tbCP
            // 
            this.tbCP.Location = new System.Drawing.Point(217, 234);
            this.tbCP.Name = "tbCP";
            this.tbCP.Size = new System.Drawing.Size(255, 30);
            this.tbCP.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(277, 294);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 38);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(379, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 38);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(217, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 30);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // fAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 356);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCP);
            this.Controls.Add(this.tbSL);
            this.Controls.Add(this.tbTenNL);
            this.Controls.Add(this.lbCP);
            this.Controls.Add(this.lbNgay);
            this.Controls.Add(this.lbSL);
            this.Controls.Add(this.lbTenNL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nguyên liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTenNL;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbCP;
        private System.Windows.Forms.TextBox tbTenNL;
        private System.Windows.Forms.TextBox tbSL;
        private System.Windows.Forms.TextBox tbCP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}