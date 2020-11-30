namespace VectorEditor
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
            this.Tools = new System.Windows.Forms.GroupBox();
            this.Tools5 = new System.Windows.Forms.RadioButton();
            this.Tools4 = new System.Windows.Forms.RadioButton();
            this.Tools3 = new System.Windows.Forms.RadioButton();
            this.Tools2 = new System.Windows.Forms.RadioButton();
            this.Tools1 = new System.Windows.Forms.RadioButton();
            this.SettingsTools = new System.Windows.Forms.GroupBox();
            this.Layout = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tools
            // 
            this.Tools.BackColor = System.Drawing.Color.Crimson;
            this.Tools.Controls.Add(this.Tools5);
            this.Tools.Controls.Add(this.Tools4);
            this.Tools.Controls.Add(this.Tools3);
            this.Tools.Controls.Add(this.Tools2);
            this.Tools.Controls.Add(this.Tools1);
            this.Tools.Location = new System.Drawing.Point(12, 26);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(58, 412);
            this.Tools.TabIndex = 0;
            this.Tools.TabStop = false;
            // 
            // Tools5
            // 
            this.Tools5.AutoSize = true;
            this.Tools5.Location = new System.Drawing.Point(22, 95);
            this.Tools5.Name = "Tools5";
            this.Tools5.Size = new System.Drawing.Size(14, 13);
            this.Tools5.TabIndex = 5;
            this.Tools5.TabStop = true;
            this.Tools5.UseVisualStyleBackColor = true;
            // 
            // Tools4
            // 
            this.Tools4.AutoSize = true;
            this.Tools4.Location = new System.Drawing.Point(22, 76);
            this.Tools4.Name = "Tools4";
            this.Tools4.Size = new System.Drawing.Size(14, 13);
            this.Tools4.TabIndex = 5;
            this.Tools4.TabStop = true;
            this.Tools4.UseVisualStyleBackColor = true;
            // 
            // Tools3
            // 
            this.Tools3.AutoSize = true;
            this.Tools3.Location = new System.Drawing.Point(22, 57);
            this.Tools3.Name = "Tools3";
            this.Tools3.Size = new System.Drawing.Size(14, 13);
            this.Tools3.TabIndex = 5;
            this.Tools3.TabStop = true;
            this.Tools3.UseVisualStyleBackColor = true;
            // 
            // Tools2
            // 
            this.Tools2.AutoSize = true;
            this.Tools2.Location = new System.Drawing.Point(22, 38);
            this.Tools2.Name = "Tools2";
            this.Tools2.Size = new System.Drawing.Size(14, 13);
            this.Tools2.TabIndex = 5;
            this.Tools2.TabStop = true;
            this.Tools2.UseVisualStyleBackColor = true;
            // 
            // Tools1
            // 
            this.Tools1.AutoSize = true;
            this.Tools1.Location = new System.Drawing.Point(22, 19);
            this.Tools1.Name = "Tools1";
            this.Tools1.Size = new System.Drawing.Size(14, 13);
            this.Tools1.TabIndex = 4;
            this.Tools1.TabStop = true;
            this.Tools1.UseVisualStyleBackColor = true;
            // 
            // SettingsTools
            // 
            this.SettingsTools.BackColor = System.Drawing.Color.Crimson;
            this.SettingsTools.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingsTools.Location = new System.Drawing.Point(882, 26);
            this.SettingsTools.Name = "SettingsTools";
            this.SettingsTools.Size = new System.Drawing.Size(200, 100);
            this.SettingsTools.TabIndex = 1;
            this.SettingsTools.TabStop = false;
            // 
            // Layout
            // 
            this.Layout.Location = new System.Drawing.Point(882, 286);
            this.Layout.Name = "Layout";
            this.Layout.Size = new System.Drawing.Size(200, 151);
            this.Layout.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(86, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 412);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Layout);
            this.Controls.Add(this.SettingsTools);
            this.Controls.Add(this.Tools);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Tools;
        private System.Windows.Forms.GroupBox SettingsTools;
        private System.Windows.Forms.TreeView Layout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton Tools5;
        private System.Windows.Forms.RadioButton Tools4;
        private System.Windows.Forms.RadioButton Tools3;
        private System.Windows.Forms.RadioButton Tools2;
        private System.Windows.Forms.RadioButton Tools1;
    }
}

