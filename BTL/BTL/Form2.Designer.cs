namespace BTL
{
    partial class Quanlymonan
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_themmon = new System.Windows.Forms.Button();
            this.bt_xoamon = new System.Windows.Forms.Button();
            this.bt_chinhsua = new System.Windows.Forms.Button();
            this.bt_lammoi = new System.Windows.Forms.Button();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_mamonan = new System.Windows.Forms.Label();
            this.lb_tenmonan = new System.Windows.Forms.Label();
            this.lb_giamonan = new System.Windows.Forms.Label();
            this.lb_nguyenlieu = new System.Windows.Forms.Label();
            this.lb_mota = new System.Windows.Forms.Label();
            this.tb_mamonan = new System.Windows.Forms.TextBox();
            this.tb_tenmon = new System.Windows.Forms.TextBox();
            this.tb_giamonan = new System.Windows.Forms.TextBox();
            this.tb_nguyenlieu = new System.Windows.Forms.TextBox();
            this.tb_mota = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mãMónĂnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênMónĂnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giáMónĂnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguyênLiệuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.môTảDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qlmonanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNHDataSet2 = new BTL.QLNHDataSet2();
            this.ql_monanTableAdapter = new BTL.QLNHDataSet2TableAdapters.ql_monanTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlmonanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.31F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.87041F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.30238F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.3F));
            this.tableLayoutPanel1.Controls.Add(this.bt_themmon, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_xoamon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_chinhsua, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_lammoi, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_timkiem, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_timkiem, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(103, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(670, 109);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bt_themmon
            // 
            this.bt_themmon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_themmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_themmon.Location = new System.Drawing.Point(3, 3);
            this.bt_themmon.Name = "bt_themmon";
            this.bt_themmon.Size = new System.Drawing.Size(116, 48);
            this.bt_themmon.TabIndex = 1;
            this.bt_themmon.Text = "Thêm món";
            this.bt_themmon.UseVisualStyleBackColor = true;
            this.bt_themmon.Click += new System.EventHandler(this.bt_themmon_Click);
            // 
            // bt_xoamon
            // 
            this.bt_xoamon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_xoamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoamon.Location = new System.Drawing.Point(125, 3);
            this.bt_xoamon.Name = "bt_xoamon";
            this.bt_xoamon.Size = new System.Drawing.Size(127, 48);
            this.bt_xoamon.TabIndex = 2;
            this.bt_xoamon.Text = "Xóa món";
            this.bt_xoamon.UseVisualStyleBackColor = true;
            this.bt_xoamon.Click += new System.EventHandler(this.bt_xoamon_Click);
            // 
            // bt_chinhsua
            // 
            this.bt_chinhsua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_chinhsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chinhsua.Location = new System.Drawing.Point(258, 3);
            this.bt_chinhsua.Name = "bt_chinhsua";
            this.bt_chinhsua.Size = new System.Drawing.Size(130, 48);
            this.bt_chinhsua.TabIndex = 3;
            this.bt_chinhsua.Text = "Chỉnh sửa";
            this.bt_chinhsua.UseVisualStyleBackColor = true;
            this.bt_chinhsua.Click += new System.EventHandler(this.bt_chinhsua_Click);
            // 
            // bt_lammoi
            // 
            this.bt_lammoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_lammoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_lammoi.Location = new System.Drawing.Point(3, 57);
            this.bt_lammoi.Name = "bt_lammoi";
            this.bt_lammoi.Size = new System.Drawing.Size(116, 49);
            this.bt_lammoi.TabIndex = 6;
            this.bt_lammoi.Text = "Làm mới";
            this.bt_lammoi.UseVisualStyleBackColor = true;
            this.bt_lammoi.Click += new System.EventHandler(this.bt_lammoi_Click);
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_timkiem.Location = new System.Drawing.Point(258, 57);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(130, 49);
            this.bt_timkiem.TabIndex = 4;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.bt_timkiem_Click);
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_timkiem.Location = new System.Drawing.Point(394, 57);
            this.tb_timkiem.Multiline = true;
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(273, 49);
            this.tb_timkiem.TabIndex = 5;
            this.tb_timkiem.Click += new System.EventHandler(this.tb_timkiem_click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.09F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.91F));
            this.tableLayoutPanel2.Controls.Add(this.lb_mamonan, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_tenmonan, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_giamonan, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_nguyenlieu, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_mota, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tb_mamonan, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_tenmon, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_giamonan, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tb_nguyenlieu, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tb_mota, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 144);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.86F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.59F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.17F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.07F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(324, 290);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lb_mamonan
            // 
            this.lb_mamonan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_mamonan.AutoSize = true;
            this.lb_mamonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mamonan.Location = new System.Drawing.Point(3, 0);
            this.lb_mamonan.Name = "lb_mamonan";
            this.lb_mamonan.Size = new System.Drawing.Size(72, 45);
            this.lb_mamonan.TabIndex = 9;
            this.lb_mamonan.Text = "Mã món ăn";
            // 
            // lb_tenmonan
            // 
            this.lb_tenmonan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_tenmonan.AutoSize = true;
            this.lb_tenmonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenmonan.Location = new System.Drawing.Point(3, 45);
            this.lb_tenmonan.Name = "lb_tenmonan";
            this.lb_tenmonan.Size = new System.Drawing.Size(72, 51);
            this.lb_tenmonan.TabIndex = 1;
            this.lb_tenmonan.Text = "Tên món ăn";
            // 
            // lb_giamonan
            // 
            this.lb_giamonan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_giamonan.AutoSize = true;
            this.lb_giamonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_giamonan.Location = new System.Drawing.Point(3, 96);
            this.lb_giamonan.Name = "lb_giamonan";
            this.lb_giamonan.Size = new System.Drawing.Size(72, 43);
            this.lb_giamonan.TabIndex = 2;
            this.lb_giamonan.Text = "Giá món ăn";
            // 
            // lb_nguyenlieu
            // 
            this.lb_nguyenlieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_nguyenlieu.AutoSize = true;
            this.lb_nguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nguyenlieu.Location = new System.Drawing.Point(3, 139);
            this.lb_nguyenlieu.Name = "lb_nguyenlieu";
            this.lb_nguyenlieu.Size = new System.Drawing.Size(72, 55);
            this.lb_nguyenlieu.TabIndex = 3;
            this.lb_nguyenlieu.Text = "Nguyên liệu";
            // 
            // lb_mota
            // 
            this.lb_mota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_mota.AutoSize = true;
            this.lb_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mota.Location = new System.Drawing.Point(3, 194);
            this.lb_mota.Name = "lb_mota";
            this.lb_mota.Size = new System.Drawing.Size(72, 96);
            this.lb_mota.TabIndex = 4;
            this.lb_mota.Text = "Mô tả";
            // 
            // tb_mamonan
            // 
            this.tb_mamonan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_mamonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mamonan.Location = new System.Drawing.Point(81, 3);
            this.tb_mamonan.Name = "tb_mamonan";
            this.tb_mamonan.Size = new System.Drawing.Size(240, 27);
            this.tb_mamonan.TabIndex = 5;
            // 
            // tb_tenmon
            // 
            this.tb_tenmon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_tenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tenmon.Location = new System.Drawing.Point(81, 48);
            this.tb_tenmon.Name = "tb_tenmon";
            this.tb_tenmon.Size = new System.Drawing.Size(240, 27);
            this.tb_tenmon.TabIndex = 6;
            // 
            // tb_giamonan
            // 
            this.tb_giamonan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_giamonan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_giamonan.Location = new System.Drawing.Point(81, 99);
            this.tb_giamonan.Name = "tb_giamonan";
            this.tb_giamonan.Size = new System.Drawing.Size(240, 27);
            this.tb_giamonan.TabIndex = 7;
            // 
            // tb_nguyenlieu
            // 
            this.tb_nguyenlieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_nguyenlieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nguyenlieu.Location = new System.Drawing.Point(81, 142);
            this.tb_nguyenlieu.Multiline = true;
            this.tb_nguyenlieu.Name = "tb_nguyenlieu";
            this.tb_nguyenlieu.Size = new System.Drawing.Size(240, 49);
            this.tb_nguyenlieu.TabIndex = 8;
            // 
            // tb_mota
            // 
            this.tb_mota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mota.Location = new System.Drawing.Point(81, 197);
            this.tb_mota.Multiline = true;
            this.tb_mota.Name = "tb_mota";
            this.tb_mota.Size = new System.Drawing.Size(240, 90);
            this.tb_mota.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãMónĂnDataGridViewTextBoxColumn,
            this.tênMónĂnDataGridViewTextBoxColumn,
            this.giáMónĂnDataGridViewTextBoxColumn,
            this.nguyênLiệuDataGridViewTextBoxColumn,
            this.môTảDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.qlmonanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(346, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(451, 333);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_cellclick);
            // 
            // mãMónĂnDataGridViewTextBoxColumn
            // 
            this.mãMónĂnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mãMónĂnDataGridViewTextBoxColumn.DataPropertyName = "Mã món ăn";
            this.mãMónĂnDataGridViewTextBoxColumn.HeaderText = "Mã món ăn";
            this.mãMónĂnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mãMónĂnDataGridViewTextBoxColumn.Name = "mãMónĂnDataGridViewTextBoxColumn";
            // 
            // tênMónĂnDataGridViewTextBoxColumn
            // 
            this.tênMónĂnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tênMónĂnDataGridViewTextBoxColumn.DataPropertyName = "Tên món ăn";
            this.tênMónĂnDataGridViewTextBoxColumn.HeaderText = "Tên món ăn";
            this.tênMónĂnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tênMónĂnDataGridViewTextBoxColumn.Name = "tênMónĂnDataGridViewTextBoxColumn";
            // 
            // giáMónĂnDataGridViewTextBoxColumn
            // 
            this.giáMónĂnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.giáMónĂnDataGridViewTextBoxColumn.DataPropertyName = "Giá món ăn";
            this.giáMónĂnDataGridViewTextBoxColumn.HeaderText = "Giá món ăn";
            this.giáMónĂnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giáMónĂnDataGridViewTextBoxColumn.Name = "giáMónĂnDataGridViewTextBoxColumn";
            // 
            // nguyênLiệuDataGridViewTextBoxColumn
            // 
            this.nguyênLiệuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nguyênLiệuDataGridViewTextBoxColumn.DataPropertyName = "Nguyên liệu";
            this.nguyênLiệuDataGridViewTextBoxColumn.HeaderText = "Nguyên liệu";
            this.nguyênLiệuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nguyênLiệuDataGridViewTextBoxColumn.Name = "nguyênLiệuDataGridViewTextBoxColumn";
            // 
            // môTảDataGridViewTextBoxColumn
            // 
            this.môTảDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.môTảDataGridViewTextBoxColumn.DataPropertyName = "Mô tả";
            this.môTảDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.môTảDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.môTảDataGridViewTextBoxColumn.Name = "môTảDataGridViewTextBoxColumn";
            // 
            // qlmonanBindingSource
            // 
            this.qlmonanBindingSource.DataMember = "ql_monan";
            this.qlmonanBindingSource.DataSource = this.qLNHDataSet2;
            // 
            // qLNHDataSet2
            // 
            this.qLNHDataSet2.DataSetName = "QLNHDataSet2";
            this.qLNHDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ql_monanTableAdapter
            // 
            this.ql_monanTableAdapter.ClearBeforeFill = true;
            // 
            // Quanlymonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 489);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Quanlymonan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý món ăn";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qlmonanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt_themmon;
        private System.Windows.Forms.Button bt_xoamon;
        private System.Windows.Forms.Button bt_chinhsua;
        private System.Windows.Forms.Button bt_lammoi;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lb_mamonan;
        private System.Windows.Forms.Label lb_tenmonan;
        private System.Windows.Forms.Label lb_giamonan;
        private System.Windows.Forms.Label lb_nguyenlieu;
        private System.Windows.Forms.Label lb_mota;
        private System.Windows.Forms.TextBox tb_mamonan;
        private System.Windows.Forms.TextBox tb_tenmon;
        private System.Windows.Forms.TextBox tb_giamonan;
        private System.Windows.Forms.TextBox tb_nguyenlieu;
        private System.Windows.Forms.TextBox tb_mota;
        private System.Windows.Forms.DataGridView dataGridView1;
        private QLNHDataSet2 qLNHDataSet2;
        private System.Windows.Forms.BindingSource qlmonanBindingSource;
        private QLNHDataSet2TableAdapters.ql_monanTableAdapter ql_monanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãMónĂnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênMónĂnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giáMónĂnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nguyênLiệuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn môTảDataGridViewTextBoxColumn;
    }
}