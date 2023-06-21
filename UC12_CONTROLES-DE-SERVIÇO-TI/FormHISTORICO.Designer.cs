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
            this.textBoxPESQUISA = new System.Windows.Forms.TextBox();
            this.buttonPESQUISAR = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHISTORICO)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHISTORICO
            // 
            this.dataGridViewHISTORICO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHISTORICO.Location = new System.Drawing.Point(49, 152);
            this.dataGridViewHISTORICO.Name = "dataGridViewHISTORICO";
            this.dataGridViewHISTORICO.Size = new System.Drawing.Size(701, 385);
            this.dataGridViewHISTORICO.TabIndex = 0;
            // 
            // labelATUALIZAR
            // 
            this.labelATUALIZAR.AutoSize = true;
            this.labelATUALIZAR.BackColor = System.Drawing.Color.Transparent;
            this.labelATUALIZAR.ForeColor = System.Drawing.Color.Black;
            this.labelATUALIZAR.Location = new System.Drawing.Point(704, 540);
            this.labelATUALIZAR.Name = "labelATUALIZAR";
            this.labelATUALIZAR.Size = new System.Drawing.Size(46, 13);
            this.labelATUALIZAR.TabIndex = 1;
            this.labelATUALIZAR.Text = "atualizar";
            this.labelATUALIZAR.Click += new System.EventHandler(this.labelATUALIZAR_Click);
            // 
            // textBoxPESQUISA
            // 
            this.textBoxPESQUISA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPESQUISA.Location = new System.Drawing.Point(49, 123);
            this.textBoxPESQUISA.Name = "textBoxPESQUISA";
            this.textBoxPESQUISA.Size = new System.Drawing.Size(620, 23);
            this.textBoxPESQUISA.TabIndex = 2;
            // 
            // buttonPESQUISAR
            // 
            this.buttonPESQUISAR.Location = new System.Drawing.Point(675, 123);
            this.buttonPESQUISAR.Name = "buttonPESQUISAR";
            this.buttonPESQUISAR.Size = new System.Drawing.Size(75, 23);
            this.buttonPESQUISAR.TabIndex = 3;
            this.buttonPESQUISAR.Text = "Pesquisar";
            this.buttonPESQUISAR.UseVisualStyleBackColor = true;
            this.buttonPESQUISAR.Click += new System.EventHandler(this.buttonPESQUISAR_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(441, 84);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(228, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pesquisar entre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(409, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "e";
            // 
            // FormHISTORICO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UC12_CONTROLES_DE_SERVIÇO_TI.Properties.Resources.vecteezy_blue_space_with_stars_with_neon_border_background__27;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonPESQUISAR);
            this.Controls.Add(this.textBoxPESQUISA);
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
        private System.Windows.Forms.TextBox textBoxPESQUISA;
        private System.Windows.Forms.Button buttonPESQUISAR;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}