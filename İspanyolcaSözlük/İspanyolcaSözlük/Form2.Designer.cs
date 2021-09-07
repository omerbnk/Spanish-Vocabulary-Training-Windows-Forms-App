namespace İspanyolcaSözlük
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mskIspanyolca = new System.Windows.Forms.MaskedTextBox();
            this.mskTurkce = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dbSozlukDataSet = new İspanyolcaSözlük.DbSozlukDataSet();
            this.dbSozlukDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSozlukDataSet1 = new İspanyolcaSözlük.DbSozlukDataSet1();
            this.tBLKelimelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLKelimelerTableAdapter = new İspanyolcaSözlük.DbSozlukDataSet1TableAdapters.TBLKelimelerTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ispanyolcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.türkceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbSozlukDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSozlukDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSozlukDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKelimelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "İspanyolca :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe :";
            // 
            // mskIspanyolca
            // 
            this.mskIspanyolca.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskIspanyolca.Location = new System.Drawing.Point(148, 59);
            this.mskIspanyolca.Name = "mskIspanyolca";
            this.mskIspanyolca.Size = new System.Drawing.Size(176, 32);
            this.mskIspanyolca.TabIndex = 2;
            // 
            // mskTurkce
            // 
            this.mskTurkce.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTurkce.Location = new System.Drawing.Point(148, 116);
            this.mskTurkce.Name = "mskTurkce";
            this.mskTurkce.Size = new System.Drawing.Size(176, 32);
            this.mskTurkce.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(148, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbSozlukDataSet
            // 
            this.dbSozlukDataSet.DataSetName = "DbSozlukDataSet";
            this.dbSozlukDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSozlukDataSetBindingSource
            // 
            this.dbSozlukDataSetBindingSource.DataSource = this.dbSozlukDataSet;
            this.dbSozlukDataSetBindingSource.Position = 0;
            // 
            // dbSozlukDataSet1
            // 
            this.dbSozlukDataSet1.DataSetName = "DbSozlukDataSet1";
            this.dbSozlukDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLKelimelerBindingSource
            // 
            this.tBLKelimelerBindingSource.DataMember = "TBLKelimeler";
            this.tBLKelimelerBindingSource.DataSource = this.dbSozlukDataSet1;
            // 
            // tBLKelimelerTableAdapter
            // 
            this.tBLKelimelerTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.ispanyolcaDataGridViewTextBoxColumn,
            this.türkceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLKelimelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(343, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 358);
            this.dataGridView1.TabIndex = 5;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ispanyolcaDataGridViewTextBoxColumn
            // 
            this.ispanyolcaDataGridViewTextBoxColumn.DataPropertyName = "İspanyolca";
            this.ispanyolcaDataGridViewTextBoxColumn.HeaderText = "İspanyolca";
            this.ispanyolcaDataGridViewTextBoxColumn.Name = "ispanyolcaDataGridViewTextBoxColumn";
            // 
            // türkceDataGridViewTextBoxColumn
            // 
            this.türkceDataGridViewTextBoxColumn.DataPropertyName = "Türkce";
            this.türkceDataGridViewTextBoxColumn.HeaderText = "Türkce";
            this.türkceDataGridViewTextBoxColumn.Name = "türkceDataGridViewTextBoxColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(455, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kelimeler";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(21, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 106);
            this.button2.TabIndex = 7;
            this.button2.Text = "Oyuna Geri Dön";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(701, 448);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mskTurkce);
            this.Controls.Add(this.mskIspanyolca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Kelime Ekleme Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbSozlukDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSozlukDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSozlukDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKelimelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskIspanyolca;
        private System.Windows.Forms.MaskedTextBox mskTurkce;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dbSozlukDataSetBindingSource;
        private DbSozlukDataSet dbSozlukDataSet;
        private DbSozlukDataSet1 dbSozlukDataSet1;
        private System.Windows.Forms.BindingSource tBLKelimelerBindingSource;
        private DbSozlukDataSet1TableAdapters.TBLKelimelerTableAdapter tBLKelimelerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ispanyolcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn türkceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}