namespace DES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.tamanho = new System.Windows.Forms.Label();
            this.comprimido = new System.Windows.Forms.Label();
            this.Setid = new System.Windows.Forms.Label();
            this.SetLen = new System.Windows.Forms.Label();
            this.SetCompress = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "descrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(174, -1);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(561, 193);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(1, 191);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(405, 180);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(411, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 3;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(405, 191);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(330, 152);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Created@ By JALNewton";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(12, 12);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(24, 16);
            this.ID.TabIndex = 6;
            this.ID.Text = "ID:";
            // 
            // tamanho
            // 
            this.tamanho.AutoSize = true;
            this.tamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tamanho.Location = new System.Drawing.Point(9, 38);
            this.tamanho.Name = "tamanho";
            this.tamanho.Size = new System.Drawing.Size(69, 16);
            this.tamanho.TabIndex = 7;
            this.tamanho.Text = "Tamanho:";
            // 
            // comprimido
            // 
            this.comprimido.AutoSize = true;
            this.comprimido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprimido.Location = new System.Drawing.Point(11, 64);
            this.comprimido.Name = "comprimido";
            this.comprimido.Size = new System.Drawing.Size(84, 16);
            this.comprimido.TabIndex = 8;
            this.comprimido.Text = "Comprimido:";
            // 
            // Setid
            // 
            this.Setid.AutoSize = true;
            this.Setid.Location = new System.Drawing.Point(39, 15);
            this.Setid.Name = "Setid";
            this.Setid.Size = new System.Drawing.Size(0, 13);
            this.Setid.TabIndex = 9;
            // 
            // SetLen
            // 
            this.SetLen.AutoSize = true;
            this.SetLen.Location = new System.Drawing.Point(78, 41);
            this.SetLen.Name = "SetLen";
            this.SetLen.Size = new System.Drawing.Size(0, 13);
            this.SetLen.TabIndex = 10;
            // 
            // SetCompress
            // 
            this.SetCompress.AutoSize = true;
            this.SetCompress.Location = new System.Drawing.Point(94, 67);
            this.SetCompress.Name = "SetCompress";
            this.SetCompress.Size = new System.Drawing.Size(0, 13);
            this.SetCompress.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 134);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Vetor";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 374);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SetCompress);
            this.Controls.Add(this.SetLen);
            this.Controls.Add(this.Setid);
            this.Controls.Add(this.comprimido);
            this.Controls.Add(this.tamanho);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decrypt Tool - Created By JALNewton";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label tamanho;
        private System.Windows.Forms.Label comprimido;
        private System.Windows.Forms.Label Setid;
        private System.Windows.Forms.Label SetLen;
        private System.Windows.Forms.Label SetCompress;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

