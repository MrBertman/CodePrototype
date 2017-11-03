namespace CodePrototype.UI_Components.PropertiesWindows
{
    partial class EmptyProperties
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
            this.PropertiesContainer = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // PropertiesContainer
            // 
            this.PropertiesContainer.Location = new System.Drawing.Point(3, 4);
            this.PropertiesContainer.Name = "PropertiesContainer";
            this.PropertiesContainer.Size = new System.Drawing.Size(141, 533);
            this.PropertiesContainer.TabIndex = 0;
            this.PropertiesContainer.TabStop = false;
            this.PropertiesContainer.Text = "Properties";
            // 
            // DefaultProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PropertiesContainer);
            this.Name = "DefaultProperties";
            this.Size = new System.Drawing.Size(150, 540);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PropertiesContainer;
    }
}
