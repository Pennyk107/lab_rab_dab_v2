using System;
using System.Drawing;
using System.Windows.Forms;

class GraphicsExample : Form
{
    public GraphicsExample()
    {
        this.Text = "Пример графики";
        this.Size = new Size(400, 300);
        this.Paint += new PaintEventHandler(OnPaint);
    }

    private void OnPaint(object sender, PaintEventArgs e)
    {
        // Получаем объект Graphics для рисования
        Graphics g = e.Graphics;

        // Рисуем прямоугольник
        g.FillRectangle(Brushes.LightBlue, 50, 50, 200, 100);

        // Рисуем текст
        g.DrawString("Пример графики в C#", new Font("Arial", 14), Brushes.Black, 60, 70);

        // Рисуем линию
        g.DrawLine(new Pen(Color.Red, 3), 50, 200, 250, 200);

        // Рисуем круг
        g.FillEllipse(Brushes.Yellow, 100, 150, 100, 100);
    }

    [STAThread]
    static void Main()
    {
        Application.Run(new GraphicsExample());
    }
}