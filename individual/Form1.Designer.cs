namespace individual
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Importbutton = new System.Windows.Forms.Button();
            this.TextBoxIn = new System.Windows.Forms.RichTextBox();
            this.TextBoxOut = new System.Windows.Forms.RichTextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.TextBoxParamN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Processbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Importbutton
            // 
            this.Importbutton.Location = new System.Drawing.Point(106, 32);
            this.Importbutton.Name = "Importbutton";
            this.Importbutton.Size = new System.Drawing.Size(137, 45);
            this.Importbutton.TabIndex = 0;
            this.Importbutton.Text = "Import";
            this.Importbutton.UseVisualStyleBackColor = true;
            this.Importbutton.Click += new System.EventHandler(this.Importbutton_Click);
            // 
            // TextBoxIn
            // 
            this.TextBoxIn.Location = new System.Drawing.Point(12, 109);
            this.TextBoxIn.Name = "TextBoxIn";
            this.TextBoxIn.Size = new System.Drawing.Size(353, 329);
            this.TextBoxIn.TabIndex = 1;
            this.TextBoxIn.Text = "";
            // 
            // TextBoxOut
            // 
            this.TextBoxOut.Location = new System.Drawing.Point(423, 109);
            this.TextBoxOut.Name = "TextBoxOut";
            this.TextBoxOut.Size = new System.Drawing.Size(365, 329);
            this.TextBoxOut.TabIndex = 2;
            this.TextBoxOut.Text = "";
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(549, 32);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(136, 45);
            this.Savebutton.TabIndex = 3;
            this.Savebutton.Text = "save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // TextBoxParamN
            // 
            this.TextBoxParamN.Location = new System.Drawing.Point(371, 60);
            this.TextBoxParamN.Name = "TextBoxParamN";
            this.TextBoxParamN.Size = new System.Drawing.Size(46, 20);
            this.TextBoxParamN.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "N:";
            // 
            // Processbutton
            // 
            this.Processbutton.Location = new System.Drawing.Point(371, 243);
            this.Processbutton.Name = "Processbutton";
            this.Processbutton.Size = new System.Drawing.Size(46, 45);
            this.Processbutton.TabIndex = 6;
            this.Processbutton.Text = "-->";
            this.Processbutton.UseVisualStyleBackColor = true;
            this.Processbutton.Click += new System.EventHandler(this.Processbutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(12, 84);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(52, 19);
            this.Clearbutton.TabIndex = 7;
            this.Clearbutton.Text = "clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Processbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxParamN);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.TextBoxOut);
            this.Controls.Add(this.TextBoxIn);
            this.Controls.Add(this.Importbutton);
            this.Name = "Form1";
            this.Text = "Количество путей длинны N";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Importbutton;
        private System.Windows.Forms.RichTextBox TextBoxIn;
        private System.Windows.Forms.RichTextBox TextBoxOut;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox TextBoxParamN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Processbutton;
        private System.Windows.Forms.Button Clearbutton;
    }
}

