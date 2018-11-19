namespace Lab_6_C
{
    partial class PaintForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mnuFormat = new System.Windows.Forms.MenuItem();
            this.mnuColor = new System.Windows.Forms.MenuItem();
            this.mnuWidth = new System.Windows.Forms.MenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.mnuFormat});
            // 
            // mnuFormat
            // 
            this.mnuFormat.Index = 0;
            this.mnuFormat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.mnuColor,
                                                                                      this.mnuWidth});
            this.mnuFormat.Text = "&Формат";
            // 
            // mnuColor
            // 
            this.mnuColor.Index = 0;
            this.mnuColor.Text = "&Цвет";
            this.mnuColor.Click += new System.EventHandler(this.mnuColor_Click);
            // 
            // mnuWidth
            // 
            this.mnuWidth.Index = 1;
            this.mnuWidth.Text = "&Толщина линии";
            this.mnuWidth.Click += new System.EventHandler(this.mnuWidth_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(292, 245);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "EasyPaint";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);

        }

        #endregion
    }
}