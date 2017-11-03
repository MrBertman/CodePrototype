namespace CodePrototype
{
    partial class FigurePainter
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
            this.dElements1 = new CodePrototype.UI_Components.DElements();
            this.defaultProperties1 = new CodePrototype.UI_Components.PropertiesWindows.EmptyProperties();
            this.dToolBar1 = new CodePrototype.UI_Components.DToolBar();
            this.dMenuBar1 = new CodePrototype.DMenuBar();
            this.dToolBarFigure1 = new CodePrototype.UI_Components.ToolBars.DToolBarFigure();
            this.dDraw1 = new CodePrototype.UI_Components.DDraw();
            ((System.ComponentModel.ISupportInitialize)(this.dDraw1)).BeginInit();
            this.SuspendLayout();
            // 
            // dElements1
            // 
            this.dElements1.Location = new System.Drawing.Point(0, 52);
            this.dElements1.Name = "dElements1";
            this.dElements1.Size = new System.Drawing.Size(158, 548);
            this.dElements1.TabIndex = 8;
            // 
            // defaultProperties1
            // 
            this.defaultProperties1.Location = new System.Drawing.Point(692, 52);
            this.defaultProperties1.Name = "defaultProperties1";
            this.defaultProperties1.Size = new System.Drawing.Size(150, 548);
            this.defaultProperties1.TabIndex = 7;
            // 
            // dToolBar1
            // 
            this.dToolBar1.Dock = System.Windows.Forms.DockStyle.None;
            this.dToolBar1.Location = new System.Drawing.Point(0, 24);
            this.dToolBar1.Name = "dToolBar1";
            this.dToolBar1.Size = new System.Drawing.Size(58, 25);
            this.dToolBar1.TabIndex = 0;
            this.dToolBar1.Text = "dToolBar1";
            // 
            // dMenuBar1
            // 
            this.dMenuBar1.Location = new System.Drawing.Point(0, 0);
            this.dMenuBar1.Name = "dMenuBar1";
            this.dMenuBar1.Size = new System.Drawing.Size(842, 24);
            this.dMenuBar1.TabIndex = 0;
            this.dMenuBar1.Text = "dMenuBar1";
            // 
            // dToolBarFigure1
            // 
            this.dToolBarFigure1.AutoSize = false;
            this.dToolBarFigure1.Dock = System.Windows.Forms.DockStyle.None;
            this.dToolBarFigure1.DropDownArrows = true;
            this.dToolBarFigure1.Location = new System.Drawing.Point(57, 24);
            this.dToolBarFigure1.Name = "dToolBarFigure1";
            this.dToolBarFigure1.ShowToolTips = true;
            this.dToolBarFigure1.Size = new System.Drawing.Size(101, 26);
            this.dToolBarFigure1.TabIndex = 9;
            this.dToolBarFigure1.Visible = false;
            // 
            // dDraw1
            // 
            this.dDraw1.BackColor = System.Drawing.Color.Tomato;
            this.dDraw1.Location = new System.Drawing.Point(154, 56);
            this.dDraw1.Name = "dDraw1";
            this.dDraw1.Size = new System.Drawing.Size(532, 467);
            this.dDraw1.TabIndex = 10;
            this.dDraw1.TabStop = false;
            // 
            // FigurePainter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 604);
            this.Controls.Add(this.dDraw1);
            this.Controls.Add(this.dToolBarFigure1);
            this.Controls.Add(this.dElements1);
            this.Controls.Add(this.defaultProperties1);
            this.Controls.Add(this.dToolBar1);
            this.Controls.Add(this.dMenuBar1);
            this.Name = "FigurePainter";
            this.Text = "FigurePainter";
            ((System.ComponentModel.ISupportInitialize)(this.dDraw1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DMenuBar dMenuBar1;
        private UI_Components.DToolBar dToolBar1;
        private UI_Components.PropertiesWindows.EmptyProperties defaultProperties1;
        private UI_Components.DElements dElements1;
        private UI_Components.ToolBars.DToolBarFigure dToolBarFigure1;
        private UI_Components.DDraw dDraw1;
    }
}

