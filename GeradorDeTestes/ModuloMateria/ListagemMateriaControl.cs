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
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Listagem Matérias";
            // 
            // ListagemMateriaControl
            // 
            this.Controls.Add(this.label2);
            this.Name = "ListagemMateriaControl";
            this.Size = new System.Drawing.Size(362, 307);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
