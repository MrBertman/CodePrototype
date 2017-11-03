namespace CodePrototype.UI_Components
{
    partial class RightClickSimpleFigure
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
            this.HelloButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SuspendLayout();
            // 
            // HelloButton
            // 
            this.HelloButton.Name = "HelloButton";
            this.HelloButton.Size = new System.Drawing.Size(102, 22);
            this.HelloButton.Text = "Hello";
            // 
            // RightClickSimpleFigure
            // 
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelloButton});
            this.Size = new System.Drawing.Size(103, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem HelloButton;
    }
}
