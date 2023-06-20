namespace UC12_CONTROLES_DE_SERVIÇO_TI
{
    partial class FormHISTORICO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHISTORICO));
            this.dataGridViewHISTORICO = new System.Windows.Forms.DataGridView();
            this.labelATUALIZAR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHISTORICO)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHISTORICO
            // 
            this.dataGridViewHISTORICO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHISTORICO.Location = new System.Drawing.Point(49, 33);
            this.dataGridViewHISTORICO.Name = "dataGridViewHISTORICO";
            this.dataGridViewHISTORICO.Size = new System.Drawing.Size(701, 385);
            this.dataGridViewHISTORICO.TabIndex = 0;
            // 
            // labelATUALIZAR
            // 
            this.labelATUALIZAR.AutoSize = true;
            this.labelATUALIZAR.BackColor = System.Drawing.Color.Transparent;
            this.labelATUALIZAR.ForeColor = System.Drawing.Color.Black;
            this.labelATUALIZAR.Location = new System.Drawing.Point(704, 17);
            this.labelATUALIZAR.Name = "labelATUALIZAR";
            this.labelATUALIZAR.Size = new System.Drawing.Size(46, 13);
            this.labelATUALIZAR.TabIndex = 1;
            this.labelATUALIZAR.Text = "atualizar";
            this.labelATUALIZAR.Click += new System.EventHandler(this.labelATUALIZAR_Click);
            // 
            // FormHISTORICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC12_CONTROLES_DE_SERVIÇO_TI.Properties.Resources.vecteezy_blue_space_with_stars_with_neon_border_background__27;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelATUALIZAR);
            this.Controls.Add(this.dataGridViewHISTORICO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHISTORICO";
            this.Text = "FormHISTORICO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHISTORICO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHISTORICO;
        private System.Windows.Forms.Label labelATUALIZAR;
    }
}