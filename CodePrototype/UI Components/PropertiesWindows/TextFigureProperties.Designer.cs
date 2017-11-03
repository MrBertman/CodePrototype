namespace CodePrototype.UI_Components.PropertiesWindows
{
    partial class TextFigureProperties
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
            this.dFigureType1 = new CodePrototype.UI_Components.DFigureType();
            this.dFigureWidthColor1 = new CodePrototype.UI_Components.DFigureWidthColor();
            this.dText1 = new CodePrototype.UI_Components.DText();
            this.PropertiesContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // PropertiesContainer
            // 
            this.PropertiesContainer.Controls.Add(this.dText1);
            this.PropertiesContainer.Controls.Add(this.dFigureType1);
            this.PropertiesContainer.Controls.Add(this.dFigureWidthColor1);
            this.PropertiesContainer.Location = new System.Drawing.Point(5, 4);
            this.PropertiesContainer.Name = "PropertiesContainer";
            this.PropertiesContainer.Size = new System.Drawing.Size(141, 533);
            this.PropertiesContainer.TabIndex = 2;
            this.PropertiesContainer.TabStop = false;
            this.PropertiesContainer.Text = "Properties";
            // 
            // dFigureType1
            // 
            this.dFigureType1.Location = new System.Drawing.Point(5, 117);
            this.dFigureType1.Name = "dFigureType1";
            this.dFigureType1.Size = new System.Drawing.Size(130, 170);
            this.dFigureType1.TabIndex = 1;
            // 
            // dFigureWidthColor1
            // 
            this.dFigureWidthColor1.Location = new System.Drawing.Point(5, 19);
            this.dFigureWidthColor1.Name = "dFigureWidthColor1";
            this.dFigureWidthColor1.Size = new System.Drawing.Size(130, 92);
            this.dFigureWidthColor1.TabIndex = 0;
            // 
            // dText1
            // 
            this.dText1.Location = new System.Drawing.Point(5, 284);
            this.dText1.Name = "dText1";
            this.dText1.Size = new System.Drawing.Size(130, 142);
            this.dText1.TabIndex = 2;
            // 
            // TextFigureProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PropertiesContainer);
            this.Name = "TextFigureProperties";
            this.Size = new System.Drawing.Size(150, 540);
            this.PropertiesContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PropertiesContainer;
        private DFigureType dFigureType1;
        private DFigureWidthColor dFigureWidthColor1;
        private DText dText1;
    }
}
