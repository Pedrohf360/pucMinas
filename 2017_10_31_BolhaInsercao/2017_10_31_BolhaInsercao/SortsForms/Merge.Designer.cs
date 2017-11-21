namespace _2017_10_31_BolhaInsercao
{
    partial class Merge
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.tempoMinimoColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tempoMedioColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tempoMaxColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantCompColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tamanhoVetorLbl = new System.Windows.Forms.Label();
            this.vetorOrdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tempoMinimoColumn,
            this.tempoMedioColumn,
            this.tempoMaxColumn,
            this.quantCompColumn});
            this.listView1.Location = new System.Drawing.Point(17, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(517, 68);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tempoMinimoColumn
            // 
            this.tempoMinimoColumn.Text = "Tempo mínimo";
            this.tempoMinimoColumn.Width = 104;
            // 
            // tempoMedioColumn
            // 
            this.tempoMedioColumn.Text = "Tempo Médio";
            this.tempoMedioColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tempoMedioColumn.Width = 105;
            // 
            // tempoMaxColumn
            // 
            this.tempoMaxColumn.Text = "Tempo Máximo";
            this.tempoMaxColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tempoMaxColumn.Width = 110;
            // 
            // quantCompColumn
            // 
            this.quantCompColumn.Text = "Quantidade de Comparações";
            this.quantCompColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantCompColumn.Width = 194;
            // 
            // tamanhoVetorLbl
            // 
            this.tamanhoVetorLbl.AutoSize = true;
            this.tamanhoVetorLbl.Location = new System.Drawing.Point(14, 20);
            this.tamanhoVetorLbl.Name = "tamanhoVetorLbl";
            this.tamanhoVetorLbl.Size = new System.Drawing.Size(0, 17);
            this.tamanhoVetorLbl.TabIndex = 4;
            // 
            // vetorOrdLbl
            // 
            this.vetorOrdLbl.AutoSize = true;
            this.vetorOrdLbl.Location = new System.Drawing.Point(229, 20);
            this.vetorOrdLbl.Name = "vetorOrdLbl";
            this.vetorOrdLbl.Size = new System.Drawing.Size(0, 17);
            this.vetorOrdLbl.TabIndex = 7;
            // 
            // Merge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 147);
            this.Controls.Add(this.vetorOrdLbl);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tamanhoVetorLbl);
            this.Name = "Merge";
            this.Text = "Merge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader tempoMinimoColumn;
        private System.Windows.Forms.ColumnHeader tempoMedioColumn;
        private System.Windows.Forms.ColumnHeader tempoMaxColumn;
        private System.Windows.Forms.ColumnHeader quantCompColumn;
        private System.Windows.Forms.Label tamanhoVetorLbl;
        private System.Windows.Forms.Label vetorOrdLbl;
    }
}