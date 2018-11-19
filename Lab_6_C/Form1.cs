using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6_C
{
    public partial class Form1 : Form
    {
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private RichTextBox rtbText;
        private MainMenu mainMenu1;
        private MenuItem mnuFile;
        private MenuItem mnuOpen;
        private MenuItem mnuSave;
        private MenuItem menuItem1;
        private MenuItem mnuPageSetup;
        private MenuItem mnuPrintPreview;
        private MenuItem mnuPrint;
        private PageSetupDialog pageSetupDialog1;
        private PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        //Переменная для хранения текста для печати. В нее будем помещать текст из RichTextBox
        string stringPrintText;
        //Переменная, определяющая номер страницы, с которой нужно начать печать
        int StartPage;
        //Переменная страниц для печати:
        int NumPages;
        //Переменная номер текущей страницы:
        int PageNumber;

        public Form1()
        {

            InitializeComponent();
            //Определяем номер страницы, с которой следует начать печать
            printDialog1.PrinterSettings.FromPage = 1;
            //Определяем максимальный номер печатаемой страницы.
            printDialog1.PrinterSettings.ToPage = printDialog1.PrinterSettings.MaximumPage;

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            //Показываем диалог выбора файла
            openFileDialog1.ShowDialog();
            // Переменной fileName присваиваем имя открываемого файла
            string fileName = openFileDialog1.FileName;
            //Создаем поток fs и открываем файл для чтения.
            FileStream filestream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //Проверяем,  открыт ли поток,  и если открыт, выполняем условие
            if (filestream != null)
            {
                //Создаем объект streamreader и связываем его с потоком filestream
                StreamReader streamreader = new StreamReader(filestream);
                //Считываем весь файл и записываем его в TextBox
                rtbText.Text = streamreader.ReadToEnd();
                filestream.Close();
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            //Показываем диалог выбора файла
            saveFileDialog1.ShowDialog();
            // В качестве имени сохраняемого файла устанавливаем переменную fileName
            string fileName = saveFileDialog1.FileName;
            FileStream filestream = File.Open(fileName, FileMode.Create, FileAccess.Write);
            if (filestream != null)
            {
                //Создаем объект streamwriter и связываем его с потоком filestream
                StreamWriter streamwriter = new StreamWriter(filestream);
                //Записываем данные из TextBox в файл
                streamwriter.Write(rtbText.Text);
                //Переносим данные из потока в файл
                streamwriter.Flush();
                filestream.Close();
            }
        }

        private void mnuPageSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void mnuPrintPreview_Click(object sender, EventArgs e)
        {
            printDocument1.DocumentName = Text;
            stringPrintText = rtbText.Text;
            StartPage = 1;
            NumPages = printDialog1.PrinterSettings.MaximumPage;
            PageNumber = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            printDialog1.AllowSelection = rtbText.SelectionLength > 0;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DocumentName = Text;
                //Определяем диапазон страниц для печати
                switch (printDialog1.PrinterSettings.PrintRange)
                {
                    //Выбраны все страницы
                    case PrintRange.AllPages:
                        stringPrintText = rtbText.Text;
                        StartPage = 1;
                        NumPages = printDialog1.PrinterSettings.MaximumPage;
                        break;
                    //Выбрана выделенная область
                    case PrintRange.Selection:
                        stringPrintText = rtbText.SelectedText;
                        StartPage = 1;
                        NumPages = printDialog1.PrinterSettings.MaximumPage;
                        break;
                    //Выбран ряд страниц
                    case PrintRange.SomePages:
                        stringPrintText = rtbText.Text;
                        StartPage = printDialog1.PrinterSettings.FromPage;
                        NumPages = printDialog1.PrinterSettings.ToPage - StartPage + 1;
                        break;
                }
                PageNumber = 1;
                //Вызываем встроенный метод для начала печати
                printDocument1.Print();
            }

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Создаем экземпляр graph класса Graphics
            Graphics graph = e.Graphics;
            //Создаем объект font, которому устанавливаем шрифт элемента rtbText
            Font font = rtbText.Font;
            //Получаем значение межстрочного интервала - высоту шрифта Т1, 134
            float HeightFont = font.GetHeight(graph);
            //Создаем экземпляр stringformat класса StringFormat для определения дополнительных параметров форматирования текста.
            StringFormat stringformat = new StringFormat();
            //Создаем экземляры  rectanglefFull и rectanglefText класса RectangleF для определния областей печати и текста. Т1, 104
            RectangleF rectanglefFull, rectanglefText;
            //Создаем переменные для подсчета числа символов и строк.
            int NumberSymbols, NumberLines;
            //В качестве области печати устанавливаем объект rectanglefFull
            if (graph.VisibleClipBounds.X < 0) rectanglefFull = e.MarginBounds;
            else
                //Определяем   объект  rectanglefFull
                rectanglefFull = new RectangleF(
                    //Устанавливаем координату  X  
                    e.MarginBounds.Left - (e.PageBounds.Width - graph.VisibleClipBounds.Width) / 2,
                    //Устанавливаем координату  Y
                    e.MarginBounds.Top - (e.PageBounds.Height - graph.VisibleClipBounds.Height) / 2,
                    //Устанавливаем ширину области
                    e.MarginBounds.Width,
                    //Устанавливаем высоту области
                    e.MarginBounds.Height);
            rectanglefText = RectangleF.Inflate(rectanglefFull, 0, -2 * HeightFont);
            //Определяем число строк
            int NumDisplayLines = (int)Math.Floor(rectanglefText.Height / HeightFont);
            //Устанавливаем высоту области
            rectanglefText.Height = NumDisplayLines * HeightFont;

            if (rtbText.WordWrap)
            {
                stringformat.Trimming = StringTrimming.Word;
            }
            else
            {
                stringformat.Trimming = StringTrimming.EllipsisCharacter;
                stringformat.FormatFlags |= StringFormatFlags.NoWrap;
            }
            //При печати выбранных страниц переходим к первой стартовой странице
            while ((PageNumber < StartPage) && (stringPrintText.Length > 0))
            {
                if (rtbText.WordWrap)
                    //Измеряем текстовые переменные, формирующие печать,  и возвращаем число символов NumberSymbols и число строк NumberLines
                    graph.MeasureString(stringPrintText, font, rectanglefText.Size, stringformat, out NumberSymbols, out NumberLines);
                else
                    NumberSymbols = SymbolsInLines(stringPrintText, NumDisplayLines);
                stringPrintText = stringPrintText.Substring(NumberSymbols);
                //Увеличиваем число страниц 
                PageNumber++;
            }
            //Если длина строки stringPrintText равняется нулю (нет текста для печати) - Останавливаем печать
            if (stringPrintText.Length == 0)
            {
                e.Cancel = true;
                return;
            }
            //Выводим (рисуем) текст для печати - stringPrintText, используем для этого шрифт font, кисть черного цвета - Brushes.Black, область печати - rectanglefText,
            //передаем строку  дополнительного форматирования stringformat
            graph.DrawString(stringPrintText, font, Brushes.Black, rectanglefText, stringformat);
            //Получаем текст для следующей страницы
            if (rtbText.WordWrap)
                graph.MeasureString(stringPrintText, font, rectanglefText.Size, stringformat, out NumberSymbols, out NumberLines);
            else
                NumberSymbols = SymbolsInLines(stringPrintText, NumDisplayLines);
            stringPrintText = stringPrintText.Substring(NumberSymbols);
            //Очищаем объект stringformat, использованный для формирования полей.
            stringformat = new StringFormat();
            //Добавляем  вывод на каждую страницу ее номер
            stringformat.Alignment = StringAlignment.Far;
            graph.DrawString("Страница " + PageNumber, font, Brushes.Black, rectanglefFull, stringformat);
            PageNumber++;
            //Cнова проверяем, имеется ли текст для печати и номер страницы, заданной для печати
            e.HasMorePages = (stringPrintText.Length > 0) && (PageNumber < StartPage + NumPages);
            //Для печати из окна предварительного просмотра  снова инициализируем переменные
            if (!e.HasMorePages)
            {
                stringPrintText = rtbText.Text;
                StartPage = 1;
                NumPages = printDialog1.PrinterSettings.MaximumPage;
                PageNumber = 1;
            }


        }

        int SymbolsInLines(string stringPrintText, int NumLines)
        {
            int index = 0;
            for (int i = 0; i < NumLines; i++)
            {
                index = 1 + stringPrintText.IndexOf('\n', index);
                if (index == 0)
                    return stringPrintText.Length;
            }
            return index;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            PictureForm form2 = new PictureForm();
            form2.ShowDialog();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            PaintForm form3 = new PaintForm();
            form3.ShowDialog();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Procrutka form4 = new Procrutka();
            form4.ShowDialog();
        }
    }
}
