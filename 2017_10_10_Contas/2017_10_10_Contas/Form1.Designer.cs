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
            this.cadCPFtxtB = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileD
            // 
            this.openFileD.FileName = "openFileDialog1";
            // 
            // cadIDtxtB
            // 
            this.cadIDtxtB.Location = new System.Drawing.Point(80, 16);
            this.cadIDtxtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cadIDtxtB.Name = "cadIDtxtB";
            this.cadIDtxtB.Size = new System.Drawing.Size(134, 20);
            this.cadIDtxtB.TabIndex = 0;
            // 
            // cadIDbtn
            // 
            this.cadIDbtn.Location = new System.Drawing.Point(225, 16);
            this.cadIDbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cadIDbtn.Name = "cadIDbtn";
            this.cadIDbtn.Size = new System.Drawing.Size(68, 19);
            this.cadIDbtn.TabIndex = 1;
            this.cadIDbtn.Text = "Cadastrar";
            this.cadIDbtn.UseVisualStyleBackColor = true;
            this.cadIDbtn.Click += new System.EventHandler(this.cadIDbtn_Click);
            // 
            // cadCPFbtn
            // 
            this.cadCPFbtn.Location = new System.Drawing.Point(225, 52);
            this.cadCPFbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cadCPFbtn.Name = "cadCPFbtn";
            this.cadCPFbtn.Size = new System.Drawing.Size(68, 19);
            this.cadCPFbtn.TabIndex = 3;
            this.cadCPFbtn.Text = "Cadastrar";
            this.cadCPFbtn.UseVisualStyleBackColor = true;
            // 
            // cadCPFtxtB
            // 
            this.cadCPFtxtB.Location = new System.Drawing.Point(80, 52);
            this.cadCPFtxtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cadCPFtxtB.Name = "cadCPFtxtB";
            this.cadCPFtxtB.Size = new System.Drawing.Size(134, 20);
            this.cadCPFtxtB.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 89);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(315, 238);
            this.listBox1.TabIndex = 4;
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
            // ContaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 334);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cadCPFbtn);
            this.Controls.Add(this.cadCPFtxtB);
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
        private System.Windows.Forms.TextBox cadCPFtxtB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

