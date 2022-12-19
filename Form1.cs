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

namespace lab6_g
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox.BackColor = Color.Green;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox.CreateGraphics();

            DrawRoad(g);

            DrawCars(g);
        }

        private void DrawRoad(Graphics g)
        {
            var pbWidth = pictureBox.Size.Width;
            var pbHeight = pictureBox.Size.Height;

            var pen = new Pen(Color.Black, 2);

            g.DrawLine(pen, new Point(200, pbHeight), new Point(400, 0));
            g.DrawLine(pen, new Point(pbWidth - 200, pbHeight), new Point(pbWidth - 400, 0));

            g.FillPolygon(Brushes.Gray, new Point[] { new Point(200, pbHeight), new Point(400, 0), new Point(pbWidth - 400, 0), new Point(pbWidth - 200, pbHeight) });

            var whitePen = new Pen(Color.White, 8);
            whitePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawLine(whitePen, new Point(pbWidth / 2, 0), new Point(pbWidth / 2, pbHeight));
        }


        private void DrawCars(Graphics g)
        {
            var car1 = Image.FromFile("car1.png");
            var car2 = Image.FromFile("car2.png");

            g.DrawImage(car1, 650, 130, 270, 270);
           g.DrawImage(car2, 450, 350, 270, 195);
        }
    }
}
