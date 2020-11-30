using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VectorEditor
{
    public partial class Form1 : Form
    {
        Bitmap mainBm;
        Pen pen;
        Graphics graphics;
        Point prevPoint;

        List<Figure> fig;


        public Form1()
        {
            InitializeComponent();
        }

        public void Paint()
        {

            graphics.Clear(Color.White);
            for (int i = 0; i < fig.Count; ++i)
            {
                List<Point> p = fig[i].GetPoints();
                graphics.DrawPolygon(pen, p.ToArray());
                pictureBox1.Image = mainBm;
            }
        }

        public void AddPoint(Point mouseLocation)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                if (mouseLocation.X - prevPoint.X > mouseLocation.Y - prevPoint.Y)
                {
                    mouseLocation.X = prevPoint.X + (mouseLocation.Y - prevPoint.Y);
                }
                else
                {
                    mouseLocation.Y = prevPoint.Y + (mouseLocation.X - prevPoint.X);
                }
            }

            fig[fig.Count - 1].SetPoints(prevPoint, mouseLocation);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
            if (Tools1.Checked)
            {
                fig.Add(new Line(prevPoint, prevPoint));
            } 
            if (Tools2.Checked)
            {
                fig.Add(new Rectangle(prevPoint, prevPoint));
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            AddPoint(e.Location);
            Paint();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                AddPoint(e.Location);
                Paint();
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainBm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pen = new Pen(Color.Black, 1);
            graphics = Graphics.FromImage(mainBm);
            prevPoint = new Point(0, 0);
            fig = new List<Figure>();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control)
            {
                fig.RemoveAt(fig.Count - 1);
                Paint();
            }

            SettingsTools.Text = e.KeyCode.ToString();
        }
    }   
}
