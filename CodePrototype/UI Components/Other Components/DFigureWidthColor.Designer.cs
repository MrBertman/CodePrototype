namespace CodePrototype.UI_Components
{
    partial class DFigureWidthColor
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
            this.WidthColorGroupBox = new System.Windows.Forms.GroupBox();
            this.FigureWidthTrackBar = new System.Windows.Forms.TrackBar();
            this.FigureColorButton = new System.Windows.Forms.Button();
            this.WidthColorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FigureWidthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // WidthColorGroupBox
            // 
            this.WidthColorGroupBox.Controls.Add(this.FigureWidthTrackBar);
            this.WidthColorGroupBox.Controls.Add(this.FigureColorButton);
            this.WidthColorGroupBox.Location = new System.Drawing.Point(3, 3);
            this.WidthColorGroupBox.Name = "WidthColorGroupBox";
            this.WidthColorGroupBox.Size = new System.Drawing.Size(124, 85);
            this.WidthColorGroupBox.TabIndex = 0;
            this.WidthColorGroupBox.TabStop = false;
            this.WidthColorGroupBox.Text = "Width ang Color";
            // 
            // FigureWidthTrackBar
            // 
            this.FigureWidthTrackBar.AutoSize = false;
            this.FigureWidthTrackBar.Location = new System.Drawing.Point(6, 48);
            this.FigureWidthTrackBar.Maximum = 50;
            this.FigureWidthTrackBar.Minimum = 10;
            this.FigureWidthTrackBar.Name = "FigureWidthTrackBar";
            this.FigureWidthTrackBar.Size = new System.Drawing.Size(104, 25);
            this.FigureWidthTrackBar.TabIndex = 1;
            this.FigureWidthTrackBar.TickFrequency = 2;
            this.FigureWidthTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.FigureWidthTrackBar.Value = 10;
            this.FigureWidthTrackBar.Scroll += new System.EventHandler(this.FigureWidthTrackBar_Scroll);
            // 
            // FigureColorButton
            // 
            this.FigureColorButton.Location = new System.Drawing.Point(6, 19);
            this.FigureColorButton.Name = "FigureColorButton";
            this.FigureColorButton.Size = new System.Drawing.Size(104, 23);
            this.FigureColorButton.TabIndex = 0;
            this.FigureColorButton.Text = "Color";
            this.FigureColorButton.UseVisualStyleBackColor = true;
            this.FigureColorButton.Click += new System.EventHandler(this.FigureColorButton_Click);
            // 
            // DFigureWidthColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WidthColorGroupBox);
            this.Name = "DFigureWidthColor";
            this.Size = new System.Drawing.Size(130, 92);
            this.WidthColorGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FigureWidthTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WidthColorGroupBox;
        private System.Windows.Forms.Button FigureColorButton;
        private System.Windows.Forms.TrackBar FigureWidthTrackBar;
    }
}
