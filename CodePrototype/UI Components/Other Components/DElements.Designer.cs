namespace CodePrototype.UI_Components
{
    partial class DElements
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ElementsGroupBox = new System.Windows.Forms.GroupBox();
            this.FigureWithImageButton = new System.Windows.Forms.Button();
            this.FigureWithTextButton = new System.Windows.Forms.Button();
            this.SimpleFigureButtton = new System.Windows.Forms.Button();
            this.ElementsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElementsGroupBox
            // 
            this.ElementsGroupBox.Controls.Add(this.FigureWithImageButton);
            this.ElementsGroupBox.Controls.Add(this.FigureWithTextButton);
            this.ElementsGroupBox.Controls.Add(this.SimpleFigureButtton);
            this.ElementsGroupBox.Location = new System.Drawing.Point(3, 6);
            this.ElementsGroupBox.Name = "ElementsGroupBox";
            this.ElementsGroupBox.Size = new System.Drawing.Size(150, 539);
            this.ElementsGroupBox.TabIndex = 0;
            this.ElementsGroupBox.TabStop = false;
            this.ElementsGroupBox.Text = "Elements";
            // 
            // FigureWithImageButton
            // 
            this.FigureWithImageButton.Image = global::CodePrototype.Properties.Resources.FigureWithImage;
            this.FigureWithImageButton.Location = new System.Drawing.Point(3, 306);
            this.FigureWithImageButton.Name = "FigureWithImageButton";
            this.FigureWithImageButton.Size = new System.Drawing.Size(141, 128);
            this.FigureWithImageButton.TabIndex = 2;
            this.FigureWithImageButton.UseVisualStyleBackColor = true;
            // 
            // FigureWithTextButton
            // 
            this.FigureWithTextButton.BackColor = System.Drawing.Color.Ivory;
            this.FigureWithTextButton.Image = global::CodePrototype.Properties.Resources.FigureWithText;
            this.FigureWithTextButton.Location = new System.Drawing.Point(3, 151);
            this.FigureWithTextButton.Name = "FigureWithTextButton";
            this.FigureWithTextButton.Size = new System.Drawing.Size(141, 149);
            this.FigureWithTextButton.TabIndex = 1;
            this.FigureWithTextButton.UseVisualStyleBackColor = false;
            // 
            // SimpleFigureButtton
            // 
            this.SimpleFigureButtton.Image = global::CodePrototype.Properties.Resources.SimpleFigure;
            this.SimpleFigureButtton.Location = new System.Drawing.Point(3, 16);
            this.SimpleFigureButtton.Name = "SimpleFigureButtton";
            this.SimpleFigureButtton.Size = new System.Drawing.Size(141, 129);
            this.SimpleFigureButtton.TabIndex = 0;
            this.SimpleFigureButtton.UseVisualStyleBackColor = true;
            // 
            // DElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ElementsGroupBox);
            this.Name = "DElements";
            this.Size = new System.Drawing.Size(158, 548);
            this.ElementsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ElementsGroupBox;
        private System.Windows.Forms.Button SimpleFigureButtton;
        private System.Windows.Forms.Button FigureWithImageButton;
        private System.Windows.Forms.Button FigureWithTextButton;
    }
}
