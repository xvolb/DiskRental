namespace Pujcovna
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
            this.dgvZakaznici = new System.Windows.Forms.DataGridView();
            this.dgvSklad = new System.Windows.Forms.DataGridView();
            this.dgvVypujcene = new System.Windows.Forms.DataGridView();
            this.btnVypujcit = new System.Windows.Forms.Button();
            this.btnVratit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPridatZakaznika = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaznici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSklad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVypujcene)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZakaznici
            // 
            this.dgvZakaznici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZakaznici.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvZakaznici.Location = new System.Drawing.Point(22, 61);
            this.dgvZakaznici.MultiSelect = false;
            this.dgvZakaznici.Name = "dgvZakaznici";
            this.dgvZakaznici.RowHeadersWidth = 51;
            this.dgvZakaznici.RowTemplate.Height = 24;
            this.dgvZakaznici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZakaznici.Size = new System.Drawing.Size(481, 150);
            this.dgvZakaznici.TabIndex = 0;
            this.dgvZakaznici.SelectionChanged += new System.EventHandler(this.dgvZakaznici_SelectionChanged);
            // 
            // dgvSklad
            // 
            this.dgvSklad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSklad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSklad.Location = new System.Drawing.Point(761, 61);
            this.dgvSklad.MultiSelect = false;
            this.dgvSklad.Name = "dgvSklad";
            this.dgvSklad.RowHeadersWidth = 51;
            this.dgvSklad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSklad.Size = new System.Drawing.Size(511, 150);
            this.dgvSklad.TabIndex = 1;
            // 
            // dgvVypujcene
            // 
            this.dgvVypujcene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVypujcene.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVypujcene.Location = new System.Drawing.Point(22, 288);
            this.dgvVypujcene.MultiSelect = false;
            this.dgvVypujcene.Name = "dgvVypujcene";
            this.dgvVypujcene.RowHeadersWidth = 51;
            this.dgvVypujcene.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVypujcene.Size = new System.Drawing.Size(614, 150);
            this.dgvVypujcene.TabIndex = 2;
            // 
            // btnVypujcit
            // 
            this.btnVypujcit.Location = new System.Drawing.Point(559, 61);
            this.btnVypujcit.Name = "btnVypujcit";
            this.btnVypujcit.Size = new System.Drawing.Size(141, 57);
            this.btnVypujcit.TabIndex = 3;
            this.btnVypujcit.Text = "Vypujcit";
            this.btnVypujcit.UseVisualStyleBackColor = true;
            this.btnVypujcit.Click += new System.EventHandler(this.btnVypujcit_Click);
            // 
            // btnVratit
            // 
            this.btnVratit.Location = new System.Drawing.Point(559, 154);
            this.btnVratit.Name = "btnVratit";
            this.btnVratit.Size = new System.Drawing.Size(141, 57);
            this.btnVratit.TabIndex = 4;
            this.btnVratit.Text = "Vratit";
            this.btnVratit.UseVisualStyleBackColor = true;
            this.btnVratit.Click += new System.EventHandler(this.btnVratit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zakaznici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(758, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sklad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vypujcene polozky zakaznika";
            // 
            // btnPridatZakaznika
            // 
            this.btnPridatZakaznika.Location = new System.Drawing.Point(128, 12);
            this.btnPridatZakaznika.Name = "btnPridatZakaznika";
            this.btnPridatZakaznika.Size = new System.Drawing.Size(129, 23);
            this.btnPridatZakaznika.TabIndex = 8;
            this.btnPridatZakaznika.Text = "Pridat zakaznika";
            this.btnPridatZakaznika.UseVisualStyleBackColor = true;
            this.btnPridatZakaznika.Click += new System.EventHandler(this.btnPridatZakaznika_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(882, 331);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPridatZakaznika);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVratit);
            this.Controls.Add(this.btnVypujcit);
            this.Controls.Add(this.dgvVypujcene);
            this.Controls.Add(this.dgvSklad);
            this.Controls.Add(this.dgvZakaznici);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvZakaznici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSklad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVypujcene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZakaznici;
        private System.Windows.Forms.DataGridView dgvSklad;
        private System.Windows.Forms.DataGridView dgvVypujcene;
        private System.Windows.Forms.Button btnVypujcit;
        private System.Windows.Forms.Button btnVratit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPridatZakaznika;
        private System.Windows.Forms.TextBox textBox1;
    }
}

