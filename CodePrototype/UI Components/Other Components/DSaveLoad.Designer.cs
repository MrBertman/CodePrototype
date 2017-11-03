namespace CodePrototype.UI_Components
{
    partial class DSaveLoad
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
            this.SaveLoadGroupBox = new System.Windows.Forms.GroupBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveLoadGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveLoadGroupBox
            // 
            this.SaveLoadGroupBox.Controls.Add(this.LoadButton);
            this.SaveLoadGroupBox.Controls.Add(this.SaveButton);
            this.SaveLoadGroupBox.Location = new System.Drawing.Point(4, 4);
            this.SaveLoadGroupBox.Name = "SaveLoadGroupBox";
            this.SaveLoadGroupBox.Size = new System.Drawing.Size(123, 82);
            this.SaveLoadGroupBox.TabIndex = 0;
            this.SaveLoadGroupBox.TabStop = false;
            this.SaveLoadGroupBox.Text = "Save/Load";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(6, 19);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(111, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(6, 48);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(111, 23);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // DSaveLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveLoadGroupBox);
            this.Name = "DSaveLoad";
            this.Size = new System.Drawing.Size(130, 90);
            this.SaveLoadGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SaveLoadGroupBox;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
    }
}
