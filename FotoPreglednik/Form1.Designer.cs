namespace FotoPreglednik
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.preglednik = new System.Windows.Forms.PictureBox();
            this.potvrdniRastegni = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gumbPrikaži = new System.Windows.Forms.Button();
            this.gumbOčisti = new System.Windows.Forms.Button();
            this.gumbPostavi = new System.Windows.Forms.Button();
            this.gumbZatvori = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preglednik)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.preglednik, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.potvrdniRastegni, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 479);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // preglednik
            // 
            this.preglednik.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.preglednik, 2);
            this.preglednik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preglednik.Location = new System.Drawing.Point(3, 3);
            this.preglednik.Name = "preglednik";
            this.preglednik.Size = new System.Drawing.Size(874, 425);
            this.preglednik.TabIndex = 0;
            this.preglednik.TabStop = false;
            // 
            // potvrdniRastegni
            // 
            this.potvrdniRastegni.AutoSize = true;
            this.potvrdniRastegni.Location = new System.Drawing.Point(707, 434);
            this.potvrdniRastegni.Name = "potvrdniRastegni";
            this.potvrdniRastegni.Size = new System.Drawing.Size(83, 20);
            this.potvrdniRastegni.TabIndex = 1;
            this.potvrdniRastegni.Text = "Rastegni";
            this.potvrdniRastegni.UseVisualStyleBackColor = true;
            this.potvrdniRastegni.CheckedChanged += new System.EventHandler(this.potvrdniRastegni_Promjena);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gumbPrikaži);
            this.flowLayoutPanel1.Controls.Add(this.gumbOčisti);
            this.flowLayoutPanel1.Controls.Add(this.gumbPostavi);
            this.flowLayoutPanel1.Controls.Add(this.gumbZatvori);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 434);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(698, 42);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // gumbPrikaži
            // 
            this.gumbPrikaži.AutoSize = true;
            this.gumbPrikaži.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gumbPrikaži.Location = new System.Drawing.Point(3, 3);
            this.gumbPrikaži.Name = "gumbPrikaži";
            this.gumbPrikaži.Size = new System.Drawing.Size(109, 30);
            this.gumbPrikaži.TabIndex = 0;
            this.gumbPrikaži.Text = "Prikaži sliku";
            this.gumbPrikaži.UseVisualStyleBackColor = true;
            this.gumbPrikaži.Click += new System.EventHandler(this.gumbPrikaži_Klik);
            // 
            // gumbOčisti
            // 
            this.gumbOčisti.AutoSize = true;
            this.gumbOčisti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gumbOčisti.Location = new System.Drawing.Point(118, 3);
            this.gumbOčisti.Name = "gumbOčisti";
            this.gumbOčisti.Size = new System.Drawing.Size(102, 30);
            this.gumbOčisti.TabIndex = 1;
            this.gumbOčisti.Text = "Očisti sliku";
            this.gumbOčisti.UseVisualStyleBackColor = true;
            this.gumbOčisti.Click += new System.EventHandler(this.gumbOčisti_Klik);
            // 
            // gumbPostavi
            // 
            this.gumbPostavi.AutoSize = true;
            this.gumbPostavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gumbPostavi.Location = new System.Drawing.Point(226, 3);
            this.gumbPostavi.Name = "gumbPostavi";
            this.gumbPostavi.Size = new System.Drawing.Size(182, 30);
            this.gumbPostavi.TabIndex = 2;
            this.gumbPostavi.Text = "Postavi boju pozadine";
            this.gumbPostavi.UseVisualStyleBackColor = true;
            this.gumbPostavi.Click += new System.EventHandler(this.gumbPostavi_Klik);
            // 
            // gumbZatvori
            // 
            this.gumbZatvori.AutoSize = true;
            this.gumbZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gumbZatvori.Location = new System.Drawing.Point(414, 3);
            this.gumbZatvori.Name = "gumbZatvori";
            this.gumbZatvori.Size = new System.Drawing.Size(75, 30);
            this.gumbZatvori.TabIndex = 3;
            this.gumbZatvori.Text = "Zatvori";
            this.gumbZatvori.UseVisualStyleBackColor = true;
            this.gumbZatvori.Click += new System.EventHandler(this.gumbZatvori_Klik);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG datoteke (*.jpg)|*.jpg|PNG datoteke (*.png)|*.png";
            this.openFileDialog1.FilterIndex = 2;
            this.openFileDialog1.Title = "Odaberite sliku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 479);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Preglednik fotografija";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preglednik)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox preglednik;
        private System.Windows.Forms.CheckBox potvrdniRastegni;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button gumbPrikaži;
        private System.Windows.Forms.Button gumbOčisti;
        private System.Windows.Forms.Button gumbPostavi;
        private System.Windows.Forms.Button gumbZatvori;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

