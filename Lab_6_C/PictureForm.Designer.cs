namespace Lab_6_C
{
    partial class PictureForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuOpen = new System.Windows.Forms.MenuItem();
            this.mnuSave = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuPageSetup = new System.Windows.Forms.MenuItem();
            this.mnuPreview = new System.Windows.Forms.MenuItem();
            this.mnuPrint = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuView = new System.Windows.Forms.MenuItem();
            this.mnuResize = new System.Windows.Forms.MenuItem();
            this.mnuActual = new System.Windows.Forms.MenuItem();
            this.mnuCenterImage = new System.Windows.Forms.MenuItem();
            this.mnuAutoSize = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.cmnuResize = new System.Windows.Forms.MenuItem();
            this.cmnuActual = new System.Windows.Forms.MenuItem();
            this.cmnuCenterImage = new System.Windows.Forms.MenuItem();
            this.cmnuAutoSize = new System.Windows.Forms.MenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.sbFile = new System.Windows.Forms.StatusBarPanel();
            this.sbSize = new System.Windows.Forms.StatusBarPanel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbSize)).BeginInit();
            this.SuspendLayout();
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
            this.mnuOpen,
            this.mnuSave,
            this.menuItem1,
            this.mnuPageSetup,
            this.mnuPreview,
            this.mnuPrint,
            this.menuItem5,
            this.mnuExit});
            this.mnuFile.Text = "&Файл";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Index = 0;
            this.mnuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.mnuOpen.Text = "&Открыть";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Index = 1;
            this.mnuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuSave.Text = "&Сохранить";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 2;
            this.menuItem1.Text = "-";
            // 
            // mnuPageSetup
            // 
            this.mnuPageSetup.Index = 3;
            this.mnuPageSetup.Text = "Page Se&tup";
            this.mnuPageSetup.Click += new System.EventHandler(this.mnuPageSetup_Click);
            // 
            // mnuPreview
            // 
            this.mnuPreview.Index = 4;
            this.mnuPreview.Text = "Print Pre&view";
            this.mnuPreview.Click += new System.EventHandler(this.mnuPreview_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Index = 5;
            this.mnuPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.mnuPrint.Text = "&Print";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 6;
            this.menuItem5.Text = "-";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 7;
            this.mnuExit.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.mnuExit.Text = "&Выход";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuView
            // 
            this.mnuView.Index = 1;
            this.mnuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuResize,
            this.mnuActual,
            this.mnuCenterImage,
            this.mnuAutoSize});
            this.mnuView.Text = "&Вид";
            this.mnuView.Popup += new System.EventHandler(this.mnuView_Popup);
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
            // mnuCenterImage
            // 
            this.mnuCenterImage.Index = 2;
            this.mnuCenterImage.Text = "&По центру";
            this.mnuCenterImage.Click += new System.EventHandler(this.mnuCenterImage_Click);
            // 
            // mnuAutoSize
            // 
            this.mnuAutoSize.Index = 3;
            this.mnuAutoSize.Text = "&Автоматический размер";
            this.mnuAutoSize.Click += new System.EventHandler(this.mnuAutoSize_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Выбор изображения";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "Сохранение изображения";
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cmnuResize,
            this.cmnuActual,
            this.cmnuCenterImage,
            this.cmnuAutoSize});
            // 
            // cmnuResize
            // 
            this.cmnuResize.Index = 0;
            this.cmnuResize.Text = "&Подогнать размер";
            this.cmnuResize.Click += new System.EventHandler(this.cmnuResize_Click);
            // 
            // cmnuActual
            // 
            this.cmnuActual.Index = 1;
            this.cmnuActual.Text = "&Истинный размер";
            this.cmnuActual.Click += new System.EventHandler(this.cmnuActual_Click);
            // 
            // cmnuCenterImage
            // 
            this.cmnuCenterImage.Index = 2;
            this.cmnuCenterImage.Text = "&По центру";
            this.cmnuCenterImage.Click += new System.EventHandler(this.cmnuCenterImage_Click);
            // 
            // cmnuAutoSize
            // 
            this.cmnuAutoSize.Index = 3;
            this.cmnuAutoSize.Text = "&Автоматический размер";
            this.cmnuAutoSize.Click += new System.EventHandler(this.cmnuAutoSize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenu = this.contextMenu1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 244);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.sbFile,
            this.sbSize});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(616, 22);
            this.statusBar1.TabIndex = 3;
            // 
            // sbFile
            // 
            this.sbFile.Name = "sbFile";
            this.sbFile.Width = 500;
            // 
            // sbSize
            // 
            this.sbSize.Name = "sbSize";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PictureForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(616, 266);
            this.ContextMenu = this.contextMenu1;
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.pictureBox1);
            this.Menu = this.mainMenu1;
            this.Name = "PictureForm";
            this.Text = "Picture Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbSize)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}