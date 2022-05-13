namespace GeradorDeTestes
{
    partial class TelaPrincipalForm
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
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMateria = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuestao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTestes = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnVisualizar = new System.Windows.Forms.ToolStripButton();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelRodape = new System.Windows.Forms.Panel();
            this.txtRodape = new System.Windows.Forms.Label();
            this.labelTipoCadastro = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.panelRodape.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(879, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMateria,
            this.menuQuestao,
            this.menuTestes});
            this.ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(79, 21);
            this.ToolStripMenuItem.Text = "Cadastros";
            // 
            // menuMateria
            // 
            this.menuMateria.Name = "menuMateria";
            this.menuMateria.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuMateria.Size = new System.Drawing.Size(152, 22);
            this.menuMateria.Text = "Materias";
            this.menuMateria.Click += new System.EventHandler(this.menuMateria_Click);
            // 
            // menuQuestao
            // 
            this.menuQuestao.Name = "menuQuestao";
            this.menuQuestao.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuQuestao.Size = new System.Drawing.Size(152, 22);
            this.menuQuestao.Text = "Questões";
            this.menuQuestao.Click += new System.EventHandler(this.menuQuestao_Click);
            // 
            // menuTestes
            // 
            this.menuTestes.Name = "menuTestes";
            this.menuTestes.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuTestes.Size = new System.Drawing.Size(152, 22);
            this.menuTestes.Text = "Testes";
            this.menuTestes.Click += new System.EventHandler(this.menuTestes_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // questõesToolStripMenuItem
            // 
            this.questõesToolStripMenuItem.Name = "questõesToolStripMenuItem";
            this.questõesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.questõesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.questõesToolStripMenuItem.Text = "Questões";
            // 
            // testesToolStripMenuItem
            // 
            this.testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            this.testesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.testesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testesToolStripMenuItem.Text = "Testes";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.Enabled = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir,
            this.btnVisualizar});
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 6, 1, 6);
            this.toolStrip.Size = new System.Drawing.Size(879, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(23, 10);
            this.btnInserir.Text = "toolStripButton3";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 10);
            this.btnEditar.Text = "toolStripButton4";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 10);
            this.btnExcluir.Text = "toolStripButton5";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVisualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnVisualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVisualizar.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(23, 10);
            this.btnVisualizar.Text = "toolStripButton6";
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(0, 50);
            this.panelConteudo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(879, 210);
            this.panelConteudo.TabIndex = 2;
            this.panelConteudo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConteudo_Paint);
            // 
            // panelRodape
            // 
            this.panelRodape.Controls.Add(this.txtRodape);
            this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRodape.Location = new System.Drawing.Point(0, 233);
            this.panelRodape.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(879, 27);
            this.panelRodape.TabIndex = 3;
            // 
            // txtRodape
            // 
            this.txtRodape.AutoSize = true;
            this.txtRodape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRodape.Location = new System.Drawing.Point(5, 3);
            this.txtRodape.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRodape.Name = "txtRodape";
            this.txtRodape.Size = new System.Drawing.Size(46, 16);
            this.txtRodape.TabIndex = 0;
            this.txtRodape.Text = "Aviso";
            // 
            // labelTipoCadastro
            // 
            this.labelTipoCadastro.AutoSize = true;
            this.labelTipoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTipoCadastro.Location = new System.Drawing.Point(397, 43);
            this.labelTipoCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoCadastro.Name = "labelTipoCadastro";
            this.labelTipoCadastro.Size = new System.Drawing.Size(106, 16);
            this.labelTipoCadastro.TabIndex = 4;
            this.labelTipoCadastro.Text = "Tipo Cadastro";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // TelaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 260);
            this.Controls.Add(this.labelTipoCadastro);
            this.Controls.Add(this.panelRodape);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TelaPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de testes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panelRodape.ResumeLayout(false);
            this.panelRodape.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testesToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMateria;
        private System.Windows.Forms.ToolStripMenuItem menuQuestao;
        private System.Windows.Forms.ToolStripMenuItem menutestes;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnVisualizar;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Panel panelRodape;
        private System.Windows.Forms.Label txtRodape;
        private System.Windows.Forms.Label labelTipoCadastro;
    }
}
    
