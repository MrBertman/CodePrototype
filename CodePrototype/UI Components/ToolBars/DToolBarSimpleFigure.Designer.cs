namespace CodePrototype.UI_Components.ToolBars
{
    partial class DToolBarSimpleFigure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DToolBarSimpleFigure));
            this.LineButton = new System.Windows.Forms.ToolStripButton();
            this.RectangleButton = new System.Windows.Forms.ToolStripButton();
            this.RRectangleButton = new System.Windows.Forms.ToolStripButton();
            this.EllipseButton = new System.Windows.Forms.ToolStripButton();
            this.ColorButton = new System.Windows.Forms.ToolStripButton();
            this.WidthStrip = new System.Windows.Forms.ToolStripComboBox();
            this.SuspendLayout();
            // 
            // LineButton
            // 
            this.LineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineButton.Image = ((System.Drawing.Image)(resources.GetObject("LineButton.Image")));
            this.LineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(23, 22);
            this.LineButton.Text = "Line";
            // 
            // RectangleButton
            // 
            this.RectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("RectangleButton.Image")));
            this.RectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(23, 22);
            this.RectangleButton.Text = "Rectangle";
            // 
            // RRectangleButton
            // 
            this.RRectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("RRectangleButton.Image")));
            this.RRectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RRectangleButton.Name = "RRectangleButton";
            this.RRectangleButton.Size = new System.Drawing.Size(23, 22);
            this.RRectangleButton.Text = "RRectangle";
            // 
            // EllipseButton
            // 
            this.EllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EllipseButton.Image = ((System.Drawing.Image)(resources.GetObject("EllipseButton.Image")));
            this.EllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(23, 20);
            this.EllipseButton.Text = "Ellipse";
            // 
            // ColorButton
            // 
            this.ColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ColorButton.Image = ((System.Drawing.Image)(resources.GetObject("ColorButton.Image")));
            this.ColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(40, 19);
            this.ColorButton.Text = "Color";
            // 
            // WidthStrip
            // 
            this.WidthStrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WidthStrip.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10"});
            this.WidthStrip.Name = "WidthStrip";
            this.WidthStrip.Size = new System.Drawing.Size(121, 23);
            this.WidthStrip.Text = "Width";
            // 
            // DToolBarSimpleFigure
            // 
            this.Dock = System.Windows.Forms.DockStyle.None;
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineButton,
            this.RectangleButton,
            this.RRectangleButton,
            this.EllipseButton,
            this.WidthStrip,
            this.ColorButton});
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripButton LineButton;
        private System.Windows.Forms.ToolStripButton RectangleButton;
        private System.Windows.Forms.ToolStripButton RRectangleButton;
        private System.Windows.Forms.ToolStripButton EllipseButton;
        private System.Windows.Forms.ToolStripButton ColorButton;
        private System.Windows.Forms.ToolStripComboBox WidthStrip;
    }
}
