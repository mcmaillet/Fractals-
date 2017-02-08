using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winforms01
{
    public partial class Form1 : Form
    {
        private float CartRes = 50;
        private float PolarRes = 50;
        private bool GridCart = true;
        private float PlotRes = 1;
        private bool ShowSets = false;
        private List<RectangleF> points;
        private Complex z;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cboAngle.SelectedIndex = 0;
        }
        private void btnToPolar_Click(object sender, EventArgs e)
        {
            Complex c;
            try
            {
                if (txtX.Text == "0" && txtY.Text == "0")
                {
                    c = new Complex { X = 0, Y = 0, R = 0, T = 0 };
                }
                else
                {
                    c = new Complex(Convert.ToDouble(txtX.Text),Convert.ToDouble(txtY.Text));
                }

                if (rdoPretty.Checked)
                {
                    txtR.Text = FormatNumber(c.R);
                    if (cboAngle.SelectedIndex == 0) { txtT.Text = FormatNumber((c.T)); }
                    else { txtT.Text = (c.T * (180 / Math.PI)).ToString("F4"); }
                }
                else
                {
                    txtR.Text = c.R.ToString();
                    if (cboAngle.SelectedIndex == 0) { txtT.Text = c.T.ToString(); }
                    else { txtT.Text = (c.T * (180 / Math.PI)).ToString("F4"); }
                }
                z = c;
                plot.Refresh();
            }
            catch
            {
                MessageBox.Show("Input must be numeric");
                txtR.Text = "";
                txtT.Text = "";
                txtX.Focus();
                txtX.SelectAll();
            }
        }
        private void btnToCart_Click(object sender, EventArgs e)
        {
            Complex c;
            try
            {
                double r, t;

                if (txtR.Text == "0" && txtT.Text == "0")
                {
                    c = new Complex { X = 0, Y = 0, R = 0, T = 0 };
                }
                else
                {
                    if (txtR.Text.Contains("/"))
                    {
                        double num = Convert.ToDouble(txtR.Text.Substring(0, txtR.Text.IndexOf("/")));
                        double den = Convert.ToDouble(txtR.Text.Substring(txtR.Text.IndexOf("/") + 1));
                        r = num / den;
                    }
                    else { r = Convert.ToDouble(txtR.Text); }

                    if (cboAngle.SelectedIndex == 0)
                    {
                        if (txtT.Text.Contains("/"))
                        {
                            double num = Convert.ToDouble(txtT.Text.Substring(0, txtT.Text.IndexOf("/")));
                            double den = Convert.ToDouble(txtT.Text.Substring(txtT.Text.IndexOf("/") + 1));
                            t = num / den;
                        }
                        else { t = Convert.ToDouble(txtT.Text); }
                    }
                    else
                    {
                        t = Convert.ToDouble(txtT.Text) * (Math.PI / 180);
                    }
                    c = new Complex(r, t, "P");
                }

                if (rdoPretty.Checked)
                {
                    txtX.Text = FormatNumber(c.X);
                    txtY.Text = FormatNumber(c.Y);
                }
                else
                {
                    txtX.Text = c.X.ToString();
                    txtY.Text = c.Y.ToString();
                }
                z = c;
                plot.Refresh();
            }
            catch
            {
                MessageBox.Show("Input must be numeric");
                txtX.Text = "";
                txtY.Text = "";
                txtR.Focus();
                txtR.SelectAll();
            }
        }
        private void plot_Paint(object s, PaintEventArgs e)
        {
            if (ShowSets)
            {
                using (Graphics g = e.Graphics)
                {
                    Panel p = (Panel)s;
                    g.TranslateTransform(p.Width / 2, p.Height / 2);
                    g.ScaleTransform(1, -1);
                    RectangleF[] rects = points.ToArray();
                    g.DrawRectangles(Pens.Black, rects);
                }
            }
            else
            {
                using (Graphics g = e.Graphics)
                {
                    Panel p = (Panel)s;
                    g.TranslateTransform(p.Width / 2, p.Height / 2);
                    g.ScaleTransform(1, -1);
                    if (z != null)
                    {
                        g.DrawRectangle(Pens.Black, (float)z.X, (float)z.Y, 1, 1);
                    }
                }
            }
        }
        //
        // Note: repainting grid will cause plot_Paint to fire
        //
        private void grid_Paint(object s, PaintEventArgs e)
        {
            if (GridCart)
            {
                using (Graphics g = e.Graphics)
                {
                    int i = 0;
                    while (i * CartRes <= grid.Width)
                    {
                        g.DrawLine(Pens.LightGray, i * CartRes, 0, i * CartRes, Height);
                        i++;
                    }
                    i = 0;
                    while (i * CartRes <= grid.Height)
                    {
                        g.DrawLine(Pens.LightGray, 0, i * CartRes, Width, i * CartRes);
                        i++;
                    }
                }
            }
            else
            {
                using (Graphics g = e.Graphics)
                {
                    Panel p = (Panel)s;
                    g.TranslateTransform(p.Width / 2, p.Height / 2);
                    g.ScaleTransform(1, -1);
                    int i = 0;
                    double radius;
                    while (i * PolarRes < Math.Sqrt(p.Height * p.Height + p.Width * p.Width)/2)
                    {
                        radius = i * PolarRes;
                        g.DrawEllipse(Pens.LightGray, -(float)radius, -(float)radius, (float)radius*2, (float)radius*2);// -(float)radius, -(float)radius, (p.Width) - i * PolarRes, (p.Height) - i * PolarRes);
                        i++;
                    }
                    float angle = 0;
                    while (angle < 360)
                    {
                        g.RotateTransform(angle);
                        g.DrawLine(Pens.LightGray,-p.Width,0,p.Width,0);
                        angle += 45;
                    }
                }
            }
        }
        //
        // Helpers
        //
        private string FormatNumber(double d)
        {
            string n = "";
            decimal a = Math.Abs((decimal)d);
            if (a <= 9999999 && a >= 1) { n = d.ToString("F"); }
            else if (a > 9999999) { n = d.ToString("E"); }
            else if (a < 1 && a > 0.01m) { n = d.ToString("F"); }
            else { n = d.ToString("E"); }
            return n;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdoPolar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPolar.Checked)
            {
                GridCart = false;
                grid.Refresh();
            }
        }

        private void rdoCart_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCart.Checked)
            {
                GridCart = true;
                grid.Refresh();
            }
        }
        private void cboAngle_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (z != null)
            {
                if (cboAngle.SelectedIndex == 0) { txtT.Text = z.T.ToString(); }
                else { txtT.Text = (z.T * (180 / Math.PI)).ToString("F4"); }
            }
        }
        //
        // Button clicks
        //
        private void button1_Click(object sender, EventArgs e)
        {
            z = new Complex();
            ShowSets = true;
            points = new List<RectangleF>();
            //{(x,y) in R2 || x=25n, y=25m, for n,m in I}
            double i = -Math.Floor((double)plot.Width / 2);
            double j = -Math.Floor((double)plot.Height / 2);
            while (i < plot.Width / 2)
            {
                while (j < plot.Height / 2)
                {
                    if (i % 25 == 0 && j % 25 == 0)
                    {
                        points.Add(new RectangleF((float)i, (float)j, 1, 1));
                    }
                    j += PlotRes;
                }
                j = -Math.Floor((double)plot.Height / 2);
                i += PlotRes;
            }
            plot.Refresh();
            ShowSets = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            z = new Complex();
            ShowSets = true;
            points = new List<RectangleF>();

            double i = -Math.Floor((double)plot.Width / 2);
            double j = -Math.Floor((double)plot.Height / 2);
            // Circle draw
            while (i < plot.Width / 2)
            {
                while (j < plot.Height / 2)
                {
                    if(i*i + j*j<10000)
                    {
                        points.Add(new RectangleF((float)i, (float)j, 1, 1));
                    }
                    j += PlotRes;
                }
                j = -Math.Floor((double)plot.Height / 2);
                i += PlotRes;
            }
            plot.Refresh();
            ShowSets = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            z = new Complex();
            ShowSets = true;
            points = new List<RectangleF>();

            double i = -Math.Floor((double)plot.Width / 2);
            double j = -Math.Floor((double)plot.Height / 2);
            // Weirdness
            while (i < plot.Width / 2)
            {
                while (j < plot.Height / 2)
                {
                    if ((i%25) * (i%25) + (j%25) * (j%25) < 100)
                    {
                        points.Add(new RectangleF((float)i, (float)j, 1, 1));
                    }
                    j += PlotRes;
                }
                j = -Math.Floor((double)plot.Height / 2);
                i += PlotRes;
            }
            plot.Refresh();
            ShowSets = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            z = new Complex();
            ShowSets = true;
            points = new List<RectangleF>();

            double i = -Math.Floor((double)plot.Width / 2);
            double j = -Math.Floor((double)plot.Height / 2);
            // Trippy
            while (i < plot.Width / 2)
            {
                while (j < plot.Height / 2)
                {
                    if (((i-50)%200 * (i-50)%200 + (j-50)%200 * (j-50)%200) < 64)
                    {
                        points.Add(new RectangleF((float)i, (float)j, 1, 1));
                    }
                    j += PlotRes;
                }
                j = -Math.Floor((double)plot.Height / 2);
                i += PlotRes;
            }
            plot.Refresh();
            ShowSets = false;
        }
        //
        // Mandelbrot plot
        //
        private void button5_Click(object sender, EventArgs e)
        {
            z = new Complex();
            ShowSets = true;
            points = new List<RectangleF>();

            double i = -Math.Floor((double)plot.Width / 2);
            double j = -Math.Floor((double)plot.Height / 2);
            // Polka
            while (i < plot.Width / 2)
            {
                while (j < plot.Height / 2)
                {
                    Complex c = new Complex(i/180, j/180);
                    if (Bounded(c)) { points.Add(new RectangleF((float)i, (float)j, 1, 1)); }
                    j += PlotRes;
                }
                j = -Math.Floor((double)plot.Height / 2);
                i += PlotRes;
            }
            plot.Refresh();
            ShowSets = false;
        }
        private bool Bounded(Complex c)
        {
            //
            // Mapping Z_n+1=Z_n^2 + C, Z_0=0
            //
            int stepLimit = 40;
            Complex z_old = new Complex(0, 0);
            Complex z_new = z_old;
            int i = 0;
            while (i<stepLimit)
            {
                z_new = stepMand(z_old, c);
                if (z_new.ToString().Contains("NaN")) { return false; }
                z_old = z_new;
                i++;
            }
            return true;
        }
        private Complex stepMand(Complex z_old,Complex c)
        {
            Complex output = Complex.Add(Complex.Multiply(z_old, z_old),c);
            return output;
        }
    }
}
