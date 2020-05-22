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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Processbutton2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Processbutton3 = new System.Windows.Forms.Button();
            this.Processbutton4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Importbutton
            // 
            this.Importbutton.Location = new System.Drawing.Point(106, 50);
            this.Importbutton.Name = "Importbutton";
            this.Importbutton.Size = new System.Drawing.Size(137, 45);
            this.Importbutton.TabIndex = 0;
            this.Importbutton.Text = "Import";
            this.Importbutton.UseVisualStyleBackColor = true;
            this.Importbutton.Click += new System.EventHandler(this.Importbutton_Click);
            // 
            // TextBoxIn
            // 
            this.TextBoxIn.Location = new System.Drawing.Point(12, 101);
            this.TextBoxIn.Name = "TextBoxIn";
            this.TextBoxIn.Size = new System.Drawing.Size(353, 329);
            this.TextBoxIn.TabIndex = 1;
            this.TextBoxIn.Text = "";
            // 
            // TextBoxOut
            // 
            this.TextBoxOut.Location = new System.Drawing.Point(423, 101);
            this.TextBoxOut.Name = "TextBoxOut";
            this.TextBoxOut.Size = new System.Drawing.Size(365, 329);
            this.TextBoxOut.TabIndex = 2;
            this.TextBoxOut.Text = "";
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(549, 50);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(136, 45);
            this.Savebutton.TabIndex = 3;
            this.Savebutton.Text = "save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // TextBoxParamN
            // 
            this.TextBoxParamN.Location = new System.Drawing.Point(366, 9);
            this.TextBoxParamN.Name = "TextBoxParamN";
            this.TextBoxParamN.Size = new System.Drawing.Size(46, 20);
            this.TextBoxParamN.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "N:";
            // 
            // Processbutton
            // 
            this.Processbutton.Location = new System.Drawing.Point(366, 210);
            this.Processbutton.Name = "Processbutton";
            this.Processbutton.Size = new System.Drawing.Size(46, 45);
            this.Processbutton.TabIndex = 6;
            this.Processbutton.Text = "-->";
            this.Processbutton.UseVisualStyleBackColor = true;
            this.Processbutton.Click += new System.EventHandler(this.Processbutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(12, 76);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(52, 19);
            this.Clearbutton.TabIndex = 7;
            this.Clearbutton.Text = "clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 448);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Processbutton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TextBoxParamN);
            this.tabPage1.Location = new System.Drawing.Point(4, 40);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Найти количество путей длины N";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Processbutton2);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Построить произвольное максимальное независимое множество вершин графа";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Processbutton2
            // 
            this.Processbutton2.Location = new System.Drawing.Point(366, 210);
            this.Processbutton2.Name = "Processbutton2";
            this.Processbutton2.Size = new System.Drawing.Size(46, 45);
            this.Processbutton2.TabIndex = 7;
            this.Processbutton2.Text = "-->";
            this.Processbutton2.UseVisualStyleBackColor = true;
            this.Processbutton2.Click += new System.EventHandler(this.Processbutton2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Processbutton3);
            this.tabPage3.Location = new System.Drawing.Point(4, 40);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(790, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Построить топологическую сортировку вершин графа";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Processbutton4);
            this.tabPage4.Location = new System.Drawing.Point(4, 40);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(790, 404);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Проверка на дерево";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 40);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(790, 404);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Алгоритм Беллмана – Форда нахождения кратчайшего пути";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Processbutton3
            // 
            this.Processbutton3.Location = new System.Drawing.Point(366, 210);
            this.Processbutton3.Name = "Processbutton3";
            this.Processbutton3.Size = new System.Drawing.Size(46, 45);
            this.Processbutton3.TabIndex = 7;
            this.Processbutton3.Text = "-->";
            this.Processbutton3.UseVisualStyleBackColor = true;
            this.Processbutton3.Click += new System.EventHandler(this.Processbutton3_Click);
            // 
            // Processbutton4
            // 
            this.Processbutton4.Location = new System.Drawing.Point(366, 210);
            this.Processbutton4.Name = "Processbutton4";
            this.Processbutton4.Size = new System.Drawing.Size(46, 45);
            this.Processbutton4.TabIndex = 8;
            this.Processbutton4.Text = "-->";
            this.Processbutton4.UseVisualStyleBackColor = true;
            this.Processbutton4.Click += new System.EventHandler(this.Processbutton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.TextBoxOut);
            this.Controls.Add(this.TextBoxIn);
            this.Controls.Add(this.Importbutton);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Количество путей длинны N";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Processbutton2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button Processbutton3;
        private System.Windows.Forms.Button Processbutton4;
    }
}

