namespace DB_tulusa
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
            this.Toode_txt = new System.Windows.Forms.TextBox();
            this.Toode_lbl = new System.Windows.Forms.Label();
            this.Kogus_lbl = new System.Windows.Forms.Label();
            this.Hind_lbl = new System.Windows.Forms.Label();
            this.kategootia_lbl = new System.Windows.Forms.Label();
            this.Kat_cbox = new System.Windows.Forms.ComboBox();
            this.toode_pbox = new System.Windows.Forms.PictureBox();
            this.Otsi_btn = new System.Windows.Forms.Button();
            this.lisa_btn = new System.Windows.Forms.Button();
            this.uuenda_btn = new System.Windows.Forms.Button();
            this.kustuta_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lisaKat_btn = new System.Windows.Forms.Button();
            this.kogus_num = new System.Windows.Forms.NumericUpDown();
            this.hind_num = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.toode_pbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kogus_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hind_num)).BeginInit();
            this.SuspendLayout();
            // 
            // Toode_txt
            // 
            this.Toode_txt.Location = new System.Drawing.Point(140, 35);
            this.Toode_txt.Name = "Toode_txt";
            this.Toode_txt.Size = new System.Drawing.Size(155, 20);
            this.Toode_txt.TabIndex = 0;
            // 
            // Toode_lbl
            // 
            this.Toode_lbl.AutoSize = true;
            this.Toode_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Toode_lbl.Location = new System.Drawing.Point(5, 33);
            this.Toode_lbl.Name = "Toode_lbl";
            this.Toode_lbl.Size = new System.Drawing.Size(129, 22);
            this.Toode_lbl.TabIndex = 3;
            this.Toode_lbl.Text = "Toode nimetus";
            // 
            // Kogus_lbl
            // 
            this.Kogus_lbl.AutoSize = true;
            this.Kogus_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Kogus_lbl.Location = new System.Drawing.Point(71, 77);
            this.Kogus_lbl.Name = "Kogus_lbl";
            this.Kogus_lbl.Size = new System.Drawing.Size(61, 22);
            this.Kogus_lbl.TabIndex = 4;
            this.Kogus_lbl.Text = "Kogus";
            // 
            // Hind_lbl
            // 
            this.Hind_lbl.AutoSize = true;
            this.Hind_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Hind_lbl.Location = new System.Drawing.Point(85, 119);
            this.Hind_lbl.Name = "Hind_lbl";
            this.Hind_lbl.Size = new System.Drawing.Size(47, 22);
            this.Hind_lbl.TabIndex = 5;
            this.Hind_lbl.Text = "Hind";
            // 
            // kategootia_lbl
            // 
            this.kategootia_lbl.AutoSize = true;
            this.kategootia_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.kategootia_lbl.Location = new System.Drawing.Point(37, 161);
            this.kategootia_lbl.Name = "kategootia_lbl";
            this.kategootia_lbl.Size = new System.Drawing.Size(97, 22);
            this.kategootia_lbl.TabIndex = 6;
            this.kategootia_lbl.Text = "Kategooria";
            // 
            // Kat_cbox
            // 
            this.Kat_cbox.FormattingEnabled = true;
            this.Kat_cbox.Location = new System.Drawing.Point(140, 161);
            this.Kat_cbox.Name = "Kat_cbox";
            this.Kat_cbox.Size = new System.Drawing.Size(154, 21);
            this.Kat_cbox.TabIndex = 7;
            // 
            // toode_pbox
            // 
            this.toode_pbox.BackColor = System.Drawing.SystemColors.Control;
            this.toode_pbox.Location = new System.Drawing.Point(303, 35);
            this.toode_pbox.Name = "toode_pbox";
            this.toode_pbox.Size = new System.Drawing.Size(232, 208);
            this.toode_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toode_pbox.TabIndex = 8;
            this.toode_pbox.TabStop = false;
            // 
            // Otsi_btn
            // 
            this.Otsi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Otsi_btn.Location = new System.Drawing.Point(183, 200);
            this.Otsi_btn.Name = "Otsi_btn";
            this.Otsi_btn.Size = new System.Drawing.Size(111, 31);
            this.Otsi_btn.TabIndex = 9;
            this.Otsi_btn.Text = "Otsi fail";
            this.Otsi_btn.UseVisualStyleBackColor = true;
            this.Otsi_btn.Click += new System.EventHandler(this.Otsi_btn_Click);
            // 
            // lisa_btn
            // 
            this.lisa_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lisa_btn.Location = new System.Drawing.Point(541, 140);
            this.lisa_btn.Name = "lisa_btn";
            this.lisa_btn.Size = new System.Drawing.Size(115, 30);
            this.lisa_btn.TabIndex = 10;
            this.lisa_btn.Text = "Lisa";
            this.lisa_btn.UseVisualStyleBackColor = true;
            this.lisa_btn.Click += new System.EventHandler(this.lisa_btn_Click);
            // 
            // uuenda_btn
            // 
            this.uuenda_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.uuenda_btn.Location = new System.Drawing.Point(541, 88);
            this.uuenda_btn.Name = "uuenda_btn";
            this.uuenda_btn.Size = new System.Drawing.Size(115, 30);
            this.uuenda_btn.TabIndex = 11;
            this.uuenda_btn.Text = "Uuenda";
            this.uuenda_btn.UseVisualStyleBackColor = true;
            this.uuenda_btn.Click += new System.EventHandler(this.uuenda_btn_Click);
            // 
            // kustuta_btn
            // 
            this.kustuta_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kustuta_btn.Location = new System.Drawing.Point(541, 35);
            this.kustuta_btn.Name = "kustuta_btn";
            this.kustuta_btn.Size = new System.Drawing.Size(115, 30);
            this.kustuta_btn.TabIndex = 12;
            this.kustuta_btn.Text = "Kustuta";
            this.kustuta_btn.UseVisualStyleBackColor = true;
            this.kustuta_btn.Click += new System.EventHandler(this.kustuta_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 260);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(692, 178);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // lisaKat_btn
            // 
            this.lisaKat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lisaKat_btn.Location = new System.Drawing.Point(12, 188);
            this.lisaKat_btn.Name = "lisaKat_btn";
            this.lisaKat_btn.Size = new System.Drawing.Size(131, 27);
            this.lisaKat_btn.TabIndex = 14;
            this.lisaKat_btn.Text = "Lisa kategooria";
            this.lisaKat_btn.UseVisualStyleBackColor = true;
            this.lisaKat_btn.Click += new System.EventHandler(this.lisaKat_btn_Click);
            // 
            // kogus_num
            // 
            this.kogus_num.Location = new System.Drawing.Point(139, 80);
            this.kogus_num.Name = "kogus_num";
            this.kogus_num.Size = new System.Drawing.Size(155, 20);
            this.kogus_num.TabIndex = 15;
            // 
            // hind_num
            // 
            this.hind_num.Location = new System.Drawing.Point(139, 119);
            this.hind_num.Name = "hind_num";
            this.hind_num.Size = new System.Drawing.Size(155, 20);
            this.hind_num.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.hind_num);
            this.Controls.Add(this.kogus_num);
            this.Controls.Add(this.lisaKat_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kustuta_btn);
            this.Controls.Add(this.uuenda_btn);
            this.Controls.Add(this.lisa_btn);
            this.Controls.Add(this.Otsi_btn);
            this.Controls.Add(this.toode_pbox);
            this.Controls.Add(this.Kat_cbox);
            this.Controls.Add(this.kategootia_lbl);
            this.Controls.Add(this.Hind_lbl);
            this.Controls.Add(this.Kogus_lbl);
            this.Controls.Add(this.Toode_lbl);
            this.Controls.Add(this.Toode_txt);
            this.Name = "Form1";
            this.Text = "Tooded";
            ((System.ComponentModel.ISupportInitialize)(this.toode_pbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kogus_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hind_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Toode_txt;
        private System.Windows.Forms.Label Toode_lbl;
        private System.Windows.Forms.Label Kogus_lbl;
        private System.Windows.Forms.Label Hind_lbl;
        private System.Windows.Forms.Label kategootia_lbl;
        private System.Windows.Forms.ComboBox Kat_cbox;
        private System.Windows.Forms.PictureBox toode_pbox;
        private System.Windows.Forms.Button Otsi_btn;
        private System.Windows.Forms.Button lisa_btn;
        private System.Windows.Forms.Button uuenda_btn;
        private System.Windows.Forms.Button kustuta_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button lisaKat_btn;
        private System.Windows.Forms.NumericUpDown kogus_num;
        private System.Windows.Forms.NumericUpDown hind_num;
    }
}

