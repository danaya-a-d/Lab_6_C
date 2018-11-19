using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6_C
{
    public partial class PaintForm : Form
    {
        private MainMenu mainMenu1;
        private ColorDialog colorDialog1;
        //Переменная, отвечающая за включения режима рисования.
        //Значение true - режим включен
        bool DrawMode = false;
        //Создаем массив точек, из которых будут формироваться линии
        ArrayList points = new ArrayList();
        //Создаем экземпляр mainPen класса Pen
        Pen mainPen;
        private MenuItem mnuFormat;
        private MenuItem mnuColor;
        private MenuItem mnuWidth;


        public PaintForm()
        {
            InitializeComponent();
            mainPen = new Pen(this.ForeColor);
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //Если нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                //Включаем режим рисования
                DrawMode = true;
                //Удаляем все элементы из массива points
                points.Clear();

            }

        }

        //Событие возникает при перемещении мыши
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Если включен режим рисования
            if (DrawMode)
            {
                //Создаем экземпляр pt класса Point,
                //представляющий собой точку с координатами мыши в данный момент
                Point pt = new Point(e.X, e.Y);
                //Добавляем созданную точку в массив points
                points.Add(pt);
                if (points.Count <= 1) return;
                //Создаем новый массив pts, содержащий число  точек в массиве points
                Point[] pts = new Point[points.Count];
                //Преобразуем массив points в массив pts начиная с первого элемента
                points.CopyTo(pts, 0);
                //Создаем экземпляр graph класса Graphics для рисования
                Graphics graph = this.CreateGraphics();
                //Вызываем метод DrawCurve для рисования кривой, которому 
                //передаем перо mainPen и массив pts
                graph.DrawCurve(mainPen, pts);

            }

        }
        //Событие возникает при отпускании кнопки мыши
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //Отключаем режим рисования.
            DrawMode = false;
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                mainPen = new Pen(colorDialog1.Color);
            }
        }

        private void mnuWidth_Click(object sender, EventArgs e)
        {
            LineWidth diag = new LineWidth();
            if (diag.ShowDialog(this) == DialogResult.OK)
            {
                mainPen = new Pen(mainPen.Color, diag.PenWidth);
            }
        }
    }
}
