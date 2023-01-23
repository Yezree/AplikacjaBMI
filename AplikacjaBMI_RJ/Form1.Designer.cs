namespace AplikacjaBMI_RJ
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.waga = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wiekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMIWiekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMIDataSet = new AplikacjaBMI_RJ.BMIDataSet();
            this.bMI_WiekTableAdapter = new AplikacjaBMI_RJ.BMIDataSetTableAdapters.BMI_WiekTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.znaczenieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bMIWynikiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bMIWynikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMI_WynikiTableAdapter = new AplikacjaBMI_RJ.BMIDataSetTableAdapters.BMI_WynikiTableAdapter();
            this.wzrost = new System.Windows.Forms.TextBox();
            this.BMILabel = new System.Windows.Forms.TextBox();
            this.BMIInfo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIWiekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIWynikiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIWynikiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(117, 448);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(2);
            this.button1.Size = new System.Drawing.Size(179, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sprawdź BMI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(351, 448);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Reset BMI";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(1196, 604);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 68);
            this.button3.TabIndex = 2;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(276, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 71);
            this.label1.TabIndex = 3;
            this.label1.Text = "Body Mass Indicator ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wprowadź Wagę (xxx):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(111, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wprowadź Wzrost (x,xx):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.Label.Location = new System.Drawing.Point(250, 354);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(145, 31);
            this.Label.TabIndex = 6;
            this.Label.Text = "Wynik BMI: ";
            this.Label.Click += new System.EventHandler(this.BMILabel_Click);
            // 
            // waga
            // 
            this.waga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.waga.Font = new System.Drawing.Font("Elephant", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waga.Location = new System.Drawing.Point(429, 152);
            this.waga.Multiline = true;
            this.waga.Name = "waga";
            this.waga.Size = new System.Drawing.Size(386, 66);
            this.waga.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wiekDataGridViewTextBoxColumn,
            this.bMIDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bMIWiekBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(903, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(385, 218);
            this.dataGridView1.TabIndex = 10;
            // 
            // wiekDataGridViewTextBoxColumn
            // 
            this.wiekDataGridViewTextBoxColumn.DataPropertyName = "Wiek";
            this.wiekDataGridViewTextBoxColumn.HeaderText = "Wiek";
            this.wiekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.wiekDataGridViewTextBoxColumn.Name = "wiekDataGridViewTextBoxColumn";
            this.wiekDataGridViewTextBoxColumn.Width = 125;
            // 
            // bMIDataGridViewTextBoxColumn
            // 
            this.bMIDataGridViewTextBoxColumn.DataPropertyName = "BMI";
            this.bMIDataGridViewTextBoxColumn.HeaderText = "BMI";
            this.bMIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bMIDataGridViewTextBoxColumn.Name = "bMIDataGridViewTextBoxColumn";
            this.bMIDataGridViewTextBoxColumn.Width = 125;
            // 
            // bMIWiekBindingSource
            // 
            this.bMIWiekBindingSource.DataMember = "BMI-Wiek";
            this.bMIWiekBindingSource.DataSource = this.bMIDataSet;
            // 
            // bMIDataSet
            // 
            this.bMIDataSet.DataSetName = "BMIDataSet";
            this.bMIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bMI_WiekTableAdapter
            // 
            this.bMI_WiekTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.znaczenieDataGridViewTextBoxColumn,
            this.bMIDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.bMIWynikiBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(903, 108);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(385, 217);
            this.dataGridView2.TabIndex = 11;
            // 
            // znaczenieDataGridViewTextBoxColumn
            // 
            this.znaczenieDataGridViewTextBoxColumn.DataPropertyName = "Znaczenie";
            this.znaczenieDataGridViewTextBoxColumn.HeaderText = "Znaczenie";
            this.znaczenieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.znaczenieDataGridViewTextBoxColumn.Name = "znaczenieDataGridViewTextBoxColumn";
            this.znaczenieDataGridViewTextBoxColumn.Width = 125;
            // 
            // bMIDataGridViewTextBoxColumn1
            // 
            this.bMIDataGridViewTextBoxColumn1.DataPropertyName = "BMI";
            this.bMIDataGridViewTextBoxColumn1.HeaderText = "BMI";
            this.bMIDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.bMIDataGridViewTextBoxColumn1.Name = "bMIDataGridViewTextBoxColumn1";
            this.bMIDataGridViewTextBoxColumn1.Width = 125;
            // 
            // bMIWynikiBindingSource1
            // 
            this.bMIWynikiBindingSource1.DataMember = "BMI-Wyniki";
            this.bMIWynikiBindingSource1.DataSource = this.bMIDataSet;
            // 
            // bMIWynikiBindingSource
            // 
            this.bMIWynikiBindingSource.DataMember = "BMI-Wyniki";
            this.bMIWynikiBindingSource.DataSource = this.bMIDataSet;
            // 
            // bMI_WynikiTableAdapter
            // 
            this.bMI_WynikiTableAdapter.ClearBeforeFill = true;
            // 
            // wzrost
            // 
            this.wzrost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.wzrost.Font = new System.Drawing.Font("Elephant", 19.8F);
            this.wzrost.Location = new System.Drawing.Point(429, 244);
            this.wzrost.Multiline = true;
            this.wzrost.Name = "wzrost";
            this.wzrost.Size = new System.Drawing.Size(386, 66);
            this.wzrost.TabIndex = 13;
            this.wzrost.TextChanged += new System.EventHandler(this.wzrost_TextChanged);
            // 
            // BMILabel
            // 
            this.BMILabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BMILabel.Font = new System.Drawing.Font("Elephant", 19.8F);
            this.BMILabel.Location = new System.Drawing.Point(429, 341);
            this.BMILabel.Multiline = true;
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(386, 66);
            this.BMILabel.TabIndex = 14;
            this.BMILabel.TextChanged += new System.EventHandler(this.BMILabel_TextChanged);
            // 
            // BMIInfo
            // 
            this.BMIInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BMIInfo.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIInfo.Location = new System.Drawing.Point(964, 604);
            this.BMIInfo.Name = "BMIInfo";
            this.BMIInfo.Size = new System.Drawing.Size(189, 68);
            this.BMIInfo.TabIndex = 15;
            this.BMIInfo.Text = "Co to jest BMI? ";
            this.BMIInfo.UseVisualStyleBackColor = false;
            this.BMIInfo.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Wynik BMI";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(12, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 39);
            this.button4.TabIndex = 17;
            this.button4.Text = "Tryb dla osób starszych";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(12, 57);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(235, 41);
            this.button5.TabIndex = 18;
            this.button5.Text = "Tryb dla daltonistów";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1433, 684);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BMIInfo);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.wzrost);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.waga);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIWiekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIWynikiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMIWynikiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox waga;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BMIDataSet bMIDataSet;
        private System.Windows.Forms.BindingSource bMIWiekBindingSource;
        private BMIDataSetTableAdapters.BMI_WiekTableAdapter bMI_WiekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wiekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource bMIWynikiBindingSource;
        private BMIDataSetTableAdapters.BMI_WynikiTableAdapter bMI_WynikiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn znaczenieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bMIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bMIWynikiBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wzrost;
        private System.Windows.Forms.TextBox BMILabel;
        private System.Windows.Forms.Button BMIInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

