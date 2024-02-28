
namespace Test_List_Ornek
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
            this.btnListele1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnListele2 = new System.Windows.Forms.Button();
            this.btnListele3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnListele1
            // 
            this.btnListele1.Location = new System.Drawing.Point(12, 434);
            this.btnListele1.Name = "btnListele1";
            this.btnListele1.Size = new System.Drawing.Size(371, 44);
            this.btnListele1.TabIndex = 0;
            this.btnListele1.Text = "Listele 1";
            this.btnListele1.UseVisualStyleBackColor = true;
            this.btnListele1.Click += new System.EventHandler(this.btnListele1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 378);
            this.listBox1.TabIndex = 3;
            // 
            // btnListele2
            // 
            this.btnListele2.Location = new System.Drawing.Point(459, 434);
            this.btnListele2.Name = "btnListele2";
            this.btnListele2.Size = new System.Drawing.Size(371, 44);
            this.btnListele2.TabIndex = 4;
            this.btnListele2.Text = "Listele 2";
            this.btnListele2.UseVisualStyleBackColor = true;
            this.btnListele2.Click += new System.EventHandler(this.btnListele2_Click);
            // 
            // btnListele3
            // 
            this.btnListele3.Location = new System.Drawing.Point(913, 434);
            this.btnListele3.Name = "btnListele3";
            this.btnListele3.Size = new System.Drawing.Size(371, 44);
            this.btnListele3.TabIndex = 6;
            this.btnListele3.Text = "Listele 3";
            this.btnListele3.UseVisualStyleBackColor = true;
            this.btnListele3.Click += new System.EventHandler(this.btnListele3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 22;
            this.listBox2.Location = new System.Drawing.Point(459, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(371, 378);
            this.listBox2.TabIndex = 7;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 22;
            this.listBox3.Location = new System.Drawing.Point(913, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(371, 378);
            this.listBox3.TabIndex = 8;
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(459, 399);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(371, 29);
            this.txtSayi.TabIndex = 9;
            this.txtSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayi_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 490);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnListele3);
            this.Controls.Add(this.btnListele2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnListele1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListele1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnListele2;
        private System.Windows.Forms.Button btnListele3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox txtSayi;
    }
}

