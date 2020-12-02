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
            this.Brush = new System.Windows.Forms.RadioButton();
            this.Line = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.IsoscelesTriangle = new System.Windows.Forms.RadioButton();
            this.RightTriangle = new System.Windows.Forms.RadioButton();
            this.Ellipse = new System.Windows.Forms.RadioButton();
            this.RegularNSquare = new System.Windows.Forms.RadioButton();
            this.NSquare = new System.Windows.Forms.RadioButton();
            this.Rhombus = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.Edit = new System.Windows.Forms.RadioButton();
            this.BrokenLine = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.GroupBox();
            this.Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tools
            // 
            this.Tools.BackColor = System.Drawing.Color.Crimson;
            this.Tools.Controls.Add(this.radioButton9);
            this.Tools.Controls.Add(this.RegularNSquare);
            this.Tools.Controls.Add(this.Edit);
            this.Tools.Controls.Add(this.BrokenLine);
            this.Tools.Controls.Add(this.IsoscelesTriangle);
            this.Tools.Controls.Add(this.NSquare);
            this.Tools.Controls.Add(this.Rhombus);
            this.Tools.Controls.Add(this.RightTriangle);
            this.Tools.Controls.Add(this.Ellipse);
            this.Tools.Controls.Add(this.Rectangle);
            this.Tools.Controls.Add(this.Line);
            this.Tools.Controls.Add(this.Brush);
            this.Tools.Location = new System.Drawing.Point(12, 41);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(75, 384);
            this.Tools.TabIndex = 0;
            this.Tools.TabStop = false;
            this.Tools.UseCompatibleTextRendering = true;
            // 
            // Brush
            // 
            this.Brush.AutoSize = true;
            this.Brush.Location = new System.Drawing.Point(28, 19);
            this.Brush.Name = "Brush";
            this.Brush.Size = new System.Drawing.Size(14, 13);
            this.Brush.TabIndex = 1;
            this.Brush.TabStop = true;
            this.Brush.UseVisualStyleBackColor = true;
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(28, 38);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(14, 13);
            this.Line.TabIndex = 2;
            this.Line.TabStop = true;
            this.Line.UseVisualStyleBackColor = true;
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(28, 57);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(14, 13);
            this.Rectangle.TabIndex = 3;
            this.Rectangle.TabStop = true;
            this.Rectangle.UseVisualStyleBackColor = true;
            // 
            // IsoscelesTriangle
            // 
            this.IsoscelesTriangle.AutoSize = true;
            this.IsoscelesTriangle.Location = new System.Drawing.Point(28, 112);
            this.IsoscelesTriangle.Name = "IsoscelesTriangle";
            this.IsoscelesTriangle.Size = new System.Drawing.Size(14, 13);
            this.IsoscelesTriangle.TabIndex = 6;
            this.IsoscelesTriangle.TabStop = true;
            this.IsoscelesTriangle.UseVisualStyleBackColor = true;
            // 
            // RightTriangle
            // 
            this.RightTriangle.AutoSize = true;
            this.RightTriangle.Location = new System.Drawing.Point(28, 93);
            this.RightTriangle.Name = "RightTriangle";
            this.RightTriangle.Size = new System.Drawing.Size(14, 13);
            this.RightTriangle.TabIndex = 5;
            this.RightTriangle.TabStop = true;
            this.RightTriangle.UseVisualStyleBackColor = true;
            // 
            // Ellipse
            // 
            this.Ellipse.AutoSize = true;
            this.Ellipse.Location = new System.Drawing.Point(28, 74);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(14, 13);
            this.Ellipse.TabIndex = 4;
            this.Ellipse.TabStop = true;
            this.Ellipse.UseVisualStyleBackColor = true;
            // 
            // RegularNSquare
            // 
            this.RegularNSquare.AutoSize = true;
            this.RegularNSquare.Location = new System.Drawing.Point(28, 169);
            this.RegularNSquare.Name = "RegularNSquare";
            this.RegularNSquare.Size = new System.Drawing.Size(14, 13);
            this.RegularNSquare.TabIndex = 6;
            this.RegularNSquare.TabStop = true;
            this.RegularNSquare.UseVisualStyleBackColor = true;
            // 
            // NSquare
            // 
            this.NSquare.AutoSize = true;
            this.NSquare.Location = new System.Drawing.Point(28, 150);
            this.NSquare.Name = "NSquare";
            this.NSquare.Size = new System.Drawing.Size(14, 13);
            this.NSquare.TabIndex = 5;
            this.NSquare.TabStop = true;
            this.NSquare.UseVisualStyleBackColor = true;
            // 
            // Rhombus
            // 
            this.Rhombus.AutoSize = true;
            this.Rhombus.Location = new System.Drawing.Point(28, 131);
            this.Rhombus.Name = "Rhombus";
            this.Rhombus.Size = new System.Drawing.Size(14, 13);
            this.Rhombus.TabIndex = 4;
            this.Rhombus.TabStop = true;
            this.Rhombus.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(28, 225);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(14, 13);
            this.radioButton9.TabIndex = 6;
            this.radioButton9.TabStop = true;
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // Edit
            // 
            this.Edit.AutoSize = true;
            this.Edit.Location = new System.Drawing.Point(28, 206);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(14, 13);
            this.Edit.TabIndex = 5;
            this.Edit.TabStop = true;
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // BrokenLine
            // 
            this.BrokenLine.AutoSize = true;
            this.BrokenLine.Location = new System.Drawing.Point(28, 187);
            this.BrokenLine.Name = "BrokenLine";
            this.BrokenLine.Size = new System.Drawing.Size(14, 13);
            this.BrokenLine.TabIndex = 4;
            this.BrokenLine.TabStop = true;
            this.BrokenLine.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(104, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(653, 384);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Crimson;
            this.Settings.Location = new System.Drawing.Point(786, 41);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(149, 125);
            this.Settings.TabIndex = 7;
            this.Settings.TabStop = false;
            this.Settings.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 455);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Tools);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Tools;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton RegularNSquare;
        private System.Windows.Forms.RadioButton Edit;
        private System.Windows.Forms.RadioButton BrokenLine;
        private System.Windows.Forms.RadioButton IsoscelesTriangle;
        private System.Windows.Forms.RadioButton NSquare;
        private System.Windows.Forms.RadioButton Rhombus;
        private System.Windows.Forms.RadioButton RightTriangle;
        private System.Windows.Forms.RadioButton Ellipse;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Brush;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Settings;
    }
}

