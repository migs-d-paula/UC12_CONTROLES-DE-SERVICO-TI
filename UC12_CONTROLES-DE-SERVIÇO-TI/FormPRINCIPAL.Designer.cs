namespace UC12_CONTROLES_DE_SERVIÇO_TI
{
    partial class FormPRINCIPAL
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPRINCIPAL));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orçamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DimGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orçamentoToolStripMenuItem,
            this.históricoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orçamentoToolStripMenuItem
            // 
            this.orçamentoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.orçamentoToolStripMenuItem.Name = "orçamentoToolStripMenuItem";
            this.orçamentoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.orçamentoToolStripMenuItem.Text = "orçamento";
            this.orçamentoToolStripMenuItem.Click += new System.EventHandler(this.orçamentoToolStripMenuItem_Click);
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.históricoToolStripMenuItem.Text = "histórico";
            // 
            // FortmPRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FortmPRINCIPAL";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orçamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
    }
}

