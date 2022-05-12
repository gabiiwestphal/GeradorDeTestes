using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorDeTestes.ModuloMateria
{
    public partial class ListagemMateriaControl : UserControl
    {
        public ListagemMateriaControl()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Listagem Matérias";
            // 
            // ListagemMateriaControl
            // 
            this.Controls.Add(this.label3);
            this.Name = "ListagemMateriaControl";
            this.Size = new System.Drawing.Size(341, 288);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
