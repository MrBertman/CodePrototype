namespace CodePrototype.UI_Components
{
    partial class DText
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
            this.TextGroupBox = new System.Windows.Forms.GroupBox();
            this.FontSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.FontButton = new System.Windows.Forms.Button();
            this.TextColorButton = new System.Windows.Forms.Button();
            this.TextInput = new System.Windows.Forms.TextBox();
            this.TextGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // TextGroupBox
            // 
            this.TextGroupBox.Controls.Add(this.FontSizeTrackBar);
            this.TextGroupBox.Controls.Add(this.FontButton);
            this.TextGroupBox.Controls.Add(this.TextColorButton);
            this.TextGroupBox.Controls.Add(this.TextInput);
            this.TextGroupBox.Location = new System.Drawing.Point(3, 3);
            this.TextGroupBox.Name = "TextGroupBox";
            this.TextGroupBox.Size = new System.Drawing.Size(124, 137);
            this.TextGroupBox.TabIndex = 0;
            this.TextGroupBox.TabStop = false;
            this.TextGroupBox.Text = "Text";
            // 
            // FontSizeTrackBar
            // 
            this.FontSizeTrackBar.AutoSize = false;
            this.FontSizeTrackBar.Location = new System.Drawing.Point(7, 105);
            this.FontSizeTrackBar.Maximum = 50;
            this.FontSizeTrackBar.Minimum = 10;
            this.FontSizeTrackBar.Name = "FontSizeTrackBar";
            this.FontSizeTrackBar.Size = new System.Drawing.Size(111, 25);
            this.FontSizeTrackBar.TabIndex = 3;
            this.FontSizeTrackBar.TickFrequency = 2;
            this.FontSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.FontSizeTrackBar.Value = 10;
            this.FontSizeTrackBar.Scroll += new System.EventHandler(this.FontSizeTrackBar_Scroll);
            // 
            // FontButton
            // 
            this.FontButton.Location = new System.Drawing.Point(7, 76);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(111, 23);
            this.FontButton.TabIndex = 2;
            this.FontButton.Text = "Font";
            this.FontButton.UseVisualStyleBackColor = true;
            this.FontButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // TextColorButton
            // 
            this.TextColorButton.Location = new System.Drawing.Point(7, 47);
            this.TextColorButton.Name = "TextColorButton";
            this.TextColorButton.Size = new System.Drawing.Size(111, 23);
            this.TextColorButton.TabIndex = 1;
            this.TextColorButton.Text = "Text Color";
            this.TextColorButton.UseVisualStyleBackColor = true;
            this.TextColorButton.Click += new System.EventHandler(this.TextColorButton_Click);
            // 
            // TextInput
            // 
            this.TextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextInput.Location = new System.Drawing.Point(7, 20);
            this.TextInput.Name = "TextInput";
            this.TextInput.Size = new System.Drawing.Size(111, 20);
            this.TextInput.TabIndex = 0;
            this.TextInput.Text = "Enter To text";
            this.TextInput.Enter += new System.EventHandler(this.TextInput_Enter);
            this.TextInput.Leave += new System.EventHandler(this.TextInput_Leave);
            // 
            // DText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextGroupBox);
            this.Name = "DText";
            this.Size = new System.Drawing.Size(130, 142);
            this.TextGroupBox.ResumeLayout(false);
            this.TextGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FontSizeTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TextGroupBox;
        private System.Windows.Forms.Button FontButton;
        private System.Windows.Forms.Button TextColorButton;
        private System.Windows.Forms.TextBox TextInput;
        private System.Windows.Forms.TrackBar FontSizeTrackBar;
    }
}
