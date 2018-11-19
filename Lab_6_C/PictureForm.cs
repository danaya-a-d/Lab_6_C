using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6_C
{
    public partial class PictureForm : Form
    {
        private MainMenu mainMenu1;
        private MenuItem mnuFile;
        private MenuItem mnuOpen;
        private MenuItem mnuSave;
        private MenuItem menuItem1;
        private MenuItem mnuPageSetup;
        private MenuItem mnuPreview;
        private MenuItem mnuPrint;
        private MenuItem menuItem5;
        private MenuItem mnuExit;
        private MenuItem mnuView;
        private MenuItem mnuResize;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ContextMenu contextMenu1;
        private PictureBox pictureBox1;
        private MenuItem mnuActual;
        private MenuItem mnuCenterImage;
        private MenuItem mnuAutoSize;
        private MenuItem cmnuResize;
        private MenuItem cmnuActual;
        private MenuItem cmnuCenterImage;
        private MenuItem cmnuAutoSize;
        private StatusBar statusBar1;
        private StatusBarPanel sbFile;
        private StatusBarPanel sbSize;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private PageSetupDialog pageSetupDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;


        public PictureForm()
        {
            PictureForm p = new PictureForm();
            InitializeComponent();
        }

        private PictureBoxSizeMode[] ArrayMenu =
        {
            PictureBoxSizeMode.StretchImage,
            PictureBoxSizeMode.Normal,
            PictureBoxSizeMode.CenterImage,
            PictureBoxSizeMode.AutoSize
        };
        private int selectedMode = 0;

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog diag = new OpenFileDialog();
            diag.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(diag.OpenFile());
            }

            //Строка, для вывода   во время загрузки изображения
            sbFile.Text = "Загрузка " + diag.FileName;
            //Строка, для вывода после загрузки изображения
            sbFile.Text = "Изображение " + diag.FileName;
            //Вывод ширины (Width) и высоты (Height) изображения
            sbSize.Text = String.Format("{0:#} x {1:#}", pictureBox1.Image.Width, pictureBox1.Image.Height);


        }
        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();
            diag.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (diag.ShowDialog() != DialogResult.OK)
                return;
            // Получаем адрес файла.
            string filename = diag.FileName;
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite);
            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
            fs.Close();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuResize_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;
                pictureBox1.SizeMode = ArrayMenu[0];
                pictureBox1.Invalidate();

            }

        }

        private void mnuActual_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;

                pictureBox1.SizeMode = ArrayMenu[1];
                pictureBox1.Invalidate();

            }
        }

        private void mnuView_Popup(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                bool ImLoad = (pictureBox1.Image != null);
                foreach (MenuItem menuitem in ((MenuItem)sender).MenuItems)
                {
                    menuitem.Enabled = ImLoad;
                    menuitem.Checked = (this.selectedMode == menuitem.Index);
                }
            }

        }

        private void mnuCenterImage_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;

                pictureBox1.SizeMode = ArrayMenu[2];
                pictureBox1.Invalidate();

            }
        }
        private void mnuAutoSize_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;

                pictureBox1.SizeMode = ArrayMenu[3];
                pictureBox1.Invalidate();

            }

        }

        private void cmnuResize_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;
                pictureBox1.SizeMode = ArrayMenu[0];
                pictureBox1.Invalidate();

            }


        }

        private void cmnuActual_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;
                pictureBox1.SizeMode = ArrayMenu[1];
                pictureBox1.Invalidate();

            }

        }

        private void cmnuCenterImage_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;
                pictureBox1.SizeMode = ArrayMenu[2];
                pictureBox1.Invalidate();

            }

        }

        private void cmnuAutoSize_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;
                pictureBox1.SizeMode = ArrayMenu[3];
                pictureBox1.Invalidate();

            }

        }

        private void mnuPageSetup_Click(object sender, EventArgs e)
        {
            PageSetupDialog diag
                = new PageSetupDialog();
            diag.Document = printDocument1;
            diag.ShowDialog();
        }

        private void mnuPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog diag
                = new PrintPreviewDialog();
            diag.Document = printDocument1;
            diag.ShowDialog();
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            PrintDialog diag = new PrintDialog();
            diag.Document = printDocument1;
            if (diag.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Если в pictureBox1 не загружена изображение, возвращаемся назад
            if (pictureBox1.Image == null)
            {
                e.Cancel = true;
                return;
            }
            //Определяем печатную область страницы
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float topMargin = e.MarginBounds.Top;
            float bottomMargin = e.MarginBounds.Bottom;
            float printableWidth = e.MarginBounds.Width;
            float printableHeight = e.MarginBounds.Height;
            //Cоздаем экземпляр graph класса Graphics
            Graphics graph = e.Graphics;
            //Создаем экземпляр font  класса Font
            Font font = new Font("Comic Sans MS", 16);
            //Определяем высоту шрифта
            float fontHeight = font.GetHeight(graph);
            //Определяем размер пробелов 
            float spaceWidth = graph.MeasureString(" ", font).Width;
            //Определяем область, в которую будет вписываться изображение, 
            //размер наибольшей стороны 	изображения составялет 90% 
            //от кратчайшей стороны листа
            float imageLength;
            float Xposition = leftMargin;
            float Yposition = topMargin + fontHeight;
            if (printableWidth < printableHeight)
            {
                imageLength = printableWidth * 90 / 100;
                Yposition += imageLength;
            }
            else
            {
                imageLength = printableHeight * 90 / 100;
                Xposition += imageLength + spaceWidth;
            }
            // Выводим изображение в области rectImage
            Rectangle rectImage = new Rectangle((int)leftMargin + 1, (int)topMargin + 1, (int)imageLength, (int)imageLength);
            graph.DrawImage(pictureBox1.Image, (int)leftMargin + 1, (int)topMargin + 1, (int)imageLength, (int)imageLength);
            // Определяем область rectText и выводим в нее строку с размером файла
            RectangleF rectText = new RectangleF(Xposition, Yposition, rightMargin - Xposition, bottomMargin - Yposition);
            PrintText(graph, font, "Размер изображения: ", Convert.ToString(pictureBox1.Image.Size), ref rectText);
        }
        protected void PrintText(Graphics graph, Font font, string name, string text, ref RectangleF rectText)
        {
            // Определяем размеры печатной области для текста:
            float leftMargin = rectText.Left;
            float rightMargin = rectText.Right;
            float topMargin = rectText.Top;
            float bottomMargin = rectText.Bottom;
            //Определяем высоту текста и координаты, где он будет выводиться:
            float fontHeight = font.GetHeight(graph);
            float Xposition = rectText.Left;
            float Yposition = topMargin + fontHeight;
            //Определяем ширину текста и размер пробелов
            float spaceWidth = graph.MeasureString(" ", font).Width;
            float nameWidth = graph.MeasureString(name, font).Width;
            graph.DrawString(name, font,
            Brushes.Black, new PointF(Xposition, Yposition));
            leftMargin += nameWidth + spaceWidth;
            Xposition = leftMargin;
            // Формируем несколько строк для текста  в случае,
            // если он не будет умещаться на одной строке
            string[] words
                = text.Split(" \r\t\n\0".ToCharArray());
            foreach (string word in words)
            {
                float wordWidth = graph.MeasureString(
                    word, font).Width;
                if (wordWidth == 0.0)
                    continue;
                if (Xposition + wordWidth > rightMargin)
                {
                    // Начало с новой строки
                    Xposition = leftMargin;
                    Yposition += fontHeight;
                    if (Yposition > bottomMargin)
                    {
                        break;
                    }
                }
                graph.DrawString(word, font, Brushes.Black, new PointF(Xposition, Yposition));
                Xposition += wordWidth;
            }
            // Исключаем область, на которую был выведен текст из области печати 
            //для избежания наложения текста и рисунка
            rectText.Y = Yposition;
            rectText.Height = bottomMargin - Yposition;

        }

        

    }
}
