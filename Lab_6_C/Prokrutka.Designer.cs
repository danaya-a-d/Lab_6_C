namespace Lab_6_C
{
    partial class Procrutka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        //private System.ComponentModel.IContainer components = null;

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
            this.cmnuResize = new System.Windows.Forms.MenuItem();
            this.cmnuActual = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuOpen = new System.Windows.Forms.MenuItem();
            this.mnuView = new System.Windows.Forms.MenuItem();
            this.mnuResize = new System.Windows.Forms.MenuItem();
            this.mnuActual = new System.Windows.Forms.MenuItem();
            this.cmnuOpen = new System.Windows.Forms.MenuItem();
            this.namePictureElement1 = new PictureElement.NamePictureElement();
            this.SuspendLayout();
            // 
            // cmnuResize
            // 
            this.cmnuResize.Index = -1;
            this.cmnuResize.Text = "&Подогнать размер";
            // 
            // cmnuActual
            // 
            this.cmnuActual.Index = -1;
            this.cmnuActual.Text = "&Истинный размер";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Выбор изображения";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                      this.mnuFile,
                                                                                      this.mnuView});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                    this.mnuOpen});
            this.mnuFile.Text = "&Файл";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Index = 0;
            this.mnuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.mnuOpen.Text = "&Открыть";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuView
            // 
            this.mnuView.Index = 1;
            this.mnuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                                    this.mnuResize,
                                                                                    this.mnuActual});
            this.mnuView.Text = "&Вид";
            // 
            // mnuResize
            // 
            this.mnuResize.Index = 0;
            this.mnuResize.Text = "&Подогнать размер";
            this.mnuResize.Click += new System.EventHandler(this.mnuResize_Click);
            // 
            // mnuActual
            // 
            this.mnuActual.Index = 1;
            this.mnuActual.Text = "&Истинный размер";
            this.mnuActual.Click += new System.EventHandler(this.mnuActual_Click);
            // 
            // cmnuOpen
            // 
            this.cmnuOpen.Index = -1;
            this.cmnuOpen.Text = "&Открыть";
            // 
            // namePictureElement1
            // 
            this.namePictureElement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namePictureElement1.Izobrajenie = null;
            this.namePictureElement1.Location = new System.Drawing.Point(0, 0);
            this.namePictureElement1.Name = "namePictureElement1";
            this.namePictureElement1.Size = new System.Drawing.Size(292, 245);
            this.namePictureElement1.TabIndex = 0;
            this.namePictureElement1.UserPropRejimProsmotra = PictureElement.RejimProsmotra.PodgonRazmera;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 245);
            this.Controls.Add(this.namePictureElement1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Сохранение пропорций и прокрутка";
            this.ResumeLayout(false);

        }
        #endregion
    }
}