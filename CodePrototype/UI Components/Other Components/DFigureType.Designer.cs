namespace CodePrototype.UI_Components
{
    partial class DFigureType
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FigureTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.EllipseButton = new System.Windows.Forms.Button();
            this.RRectangleButton = new System.Windows.Forms.Button();
            this.RectangleButton = new System.Windows.Forms.Button();
            this.LineButton = new System.Windows.Forms.Button();
            this.CurveButton = new System.Windows.Forms.Button();
            this.FigureTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FigureTypeGroupBox
            // 
            this.FigureTypeGroupBox.Controls.Add(this.EllipseButton);
            this.FigureTypeGroupBox.Controls.Add(this.RRectangleButton);
            this.FigureTypeGroupBox.Controls.Add(this.RectangleButton);
            this.FigureTypeGroupBox.Controls.Add(this.LineButton);
            this.FigureTypeGroupBox.Controls.Add(this.CurveButton);
            this.FigureTypeGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FigureTypeGroupBox.Name = "FigureTypeGroupBox";
            this.FigureTypeGroupBox.Size = new System.Drawing.Size(125, 164);
            this.FigureTypeGroupBox.TabIndex = 0;
            this.FigureTypeGroupBox.TabStop = false;
            this.FigureTypeGroupBox.Text = "FigureType";
            // 
            // EllipseButton
            // 
            this.EllipseButton.Location = new System.Drawing.Point(6, 135);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(113, 23);
            this.EllipseButton.TabIndex = 4;
            this.EllipseButton.Text = "Ellipse";
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // RRectangleButton
            // 
            this.RRectangleButton.Location = new System.Drawing.Point(6, 106);
            this.RRectangleButton.Name = "RRectangleButton";
            this.RRectangleButton.Size = new System.Drawing.Size(113, 23);
            this.RRectangleButton.TabIndex = 3;
            this.RRectangleButton.Text = "RRectangle";
            this.RRectangleButton.UseVisualStyleBackColor = true;
            this.RRectangleButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // RectangleButton
            // 
            this.RectangleButton.Location = new System.Drawing.Point(6, 77);
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(113, 23);
            this.RectangleButton.TabIndex = 2;
            this.RectangleButton.Text = "Rectangle";
            this.RectangleButton.UseVisualStyleBackColor = true;
            this.RectangleButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.Location = new System.Drawing.Point(6, 48);
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(113, 23);
            this.LineButton.TabIndex = 1;
            this.LineButton.Text = "Line";
            this.LineButton.UseVisualStyleBackColor = true;
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // CurveButton
            // 
            this.CurveButton.Location = new System.Drawing.Point(6, 19);
            this.CurveButton.Name = "CurveButton";
            this.CurveButton.Size = new System.Drawing.Size(113, 23);
            this.CurveButton.TabIndex = 0;
            this.CurveButton.Text = "Curve";
            this.CurveButton.UseVisualStyleBackColor = true;
            // 
            // DFigureType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FigureTypeGroupBox);
            this.Name = "DFigureType";
            this.Size = new System.Drawing.Size(130, 170);
            this.FigureTypeGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FigureTypeGroupBox;
        private System.Windows.Forms.Button EllipseButton;
        private System.Windows.Forms.Button RRectangleButton;
        private System.Windows.Forms.Button RectangleButton;
        private System.Windows.Forms.Button LineButton;
        private System.Windows.Forms.Button CurveButton;
    }
}
