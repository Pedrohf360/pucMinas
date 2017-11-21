namespace _2017_10_10_Contas
{
    partial class ContaForm
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
            this.openFileD = new System.Windows.Forms.OpenFileDialog();
            this.cadIDtxtB = new System.Windows.Forms.TextBox();
            this.cadIDbtn = new System.Windows.Forms.Button();
            this.cadCPFbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cadCPFtxtB = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // openFileD
            // 
            this.openFileD.FileName = "openFileDialog1";
            // 
            // cadIDtxtB
            // 
            this.cadIDtxtB.Location = new System.Drawing.Point(85, 16);
            this.cadIDtxtB.Margin = new System.Windows.Forms.Padding(2);
            this.cadIDtxtB.Name = "cadIDtxtB";
            this.cadIDtxtB.Size = new System.Drawing.Size(85, 20);
            this.cadIDtxtB.TabIndex = 0;
            // 
            // cadIDbtn
            // 
            this.cadIDbtn.Location = new System.Drawing.Point(180, 16);
            this.cadIDbtn.Margin = new System.Windows.Forms.Padding(2);
            this.cadIDbtn.Name = "cadIDbtn";
            this.cadIDbtn.Size = new System.Drawing.Size(68, 19);
            this.cadIDbtn.TabIndex = 1;
            this.cadIDbtn.Text = "Buscar";
            this.cadIDbtn.UseVisualStyleBackColor = true;
            this.cadIDbtn.Click += new System.EventHandler(this.cadIDbtn_Click);
            // 
            // cadCPFbtn
            // 
            this.cadCPFbtn.Location = new System.Drawing.Point(180, 50);
            this.cadCPFbtn.Margin = new System.Windows.Forms.Padding(2);
            this.cadCPFbtn.Name = "cadCPFbtn";
            this.cadCPFbtn.Size = new System.Drawing.Size(68, 19);
            this.cadCPFbtn.TabIndex = 3;
            this.cadCPFbtn.Text = "Buscar";
            this.cadCPFbtn.UseVisualStyleBackColor = true;
            this.cadCPFbtn.Click += new System.EventHandler(this.cadCPFbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Conta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPF Titular";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CPF,
            this.ID});
            this.listView1.Location = new System.Drawing.Point(12, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(393, 258);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            this.CPF.Width = 127;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 165;
            // 
            // cadCPFtxtB
            // 
            this.cadCPFtxtB.Location = new System.Drawing.Point(85, 49);
            this.cadCPFtxtB.Mask = "000.000.000-00";
            this.cadCPFtxtB.Name = "cadCPFtxtB";
            this.cadCPFtxtB.Size = new System.Drawing.Size(85, 20);
            this.cadCPFtxtB.TabIndex = 8;
            // 
            // ContaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 356);
            this.Controls.Add(this.cadCPFtxtB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cadCPFbtn);
            this.Controls.Add(this.cadIDbtn);
            this.Controls.Add(this.cadIDtxtB);
            this.Name = "ContaForm";
            this.Text = "Contas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileD;
        private System.Windows.Forms.TextBox cadIDtxtB;
        private System.Windows.Forms.Button cadIDbtn;
        private System.Windows.Forms.Button cadCPFbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.MaskedTextBox cadCPFtxtB;
    }
}

