﻿namespace CodePrototype.UI_Components.Figures
{
    partial class DEmptyFigure
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
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DBaseFigure
            // 
            this.BackColor = System.Drawing.Color.Red;
            this.Click += new System.EventHandler(this.DBaseFigure_Click);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DBaseFigure_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DBaseFigure_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
