using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Figuras
{
    public partial class FigurasAleatorias : Form
    {
        public FigurasAleatorias()
        {
            InitializeComponent();
            this.MouseClick += new MouseEventHandler(MiFuncionClick);
        }
        void MiFuncionClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            /*GeneradorNA();
            label1.Text = GeneradorNA().ToString();*/
            //COLORES
            int A = r.Next(256);
            int R = r.Next(256);
            int G = r.Next(256);
            int B = r.Next(256);
            //COORDENADAS
            int X = r.Next(500);
            int Y = r.Next(500);
            //longitud
            int W = r.Next(500);
            int H = r.Next(500);


            //Creamos una variable tipo Bitmap
            Bitmap b;

            //Usamos el constructor para instanciar nuestro Bitmap y asignarle el tamaño
            //de nuestro PictureBox (EN ESTE CASO EL PICTUREBOX TIENE COMO NOMBRE pictureBox1)
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            //Asignamos nuestro objeto Bitmap como imagen de nuestro pictureBox
            pictureBox1.Image = (Image)b;

            //Creamos el objeto Graphics que nos servirá para dibujar en nuestro Bitmap
            Graphics g = Graphics.FromImage(b);

            if (int.Parse(Tipo.Text) < 3)
            {
                MessageBox.Show("Numero no permitido!!! Debes ingresar numeros del 3 al 7");
            }

            else if (int.Parse(Tipo.Text) == 3)
            {
                // Create points that define polygon.
                Point point1 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point point2 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point point3 = new Point(r.Next(0, 250), r.Next(0, 250));

                Point[] curvePoints =
                    {
                 point1,
                 point2,
                 point3,
             };
                System.Drawing.SolidBrush myBrush3 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(A, R, G, B));
                g.FillPolygon(myBrush3, curvePoints);
                System.Drawing.Graphics formGraphics3;
                formGraphics3 = this.CreateGraphics();
                formGraphics3.FillPolygon(myBrush3, curvePoints);
                formGraphics3.Dispose();
                myBrush3.Dispose();

            }

            else if (int.Parse(Tipo.Text) == 4)
            {
                // Create points that define polygon2.
                Point poin1 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poin2 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poin3 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poin4 = new Point(r.Next(0, 250), r.Next(0, 250));

                Point[] curvePoints2 =
                   {
                 poin1,
                 poin2,
                 poin3,
                 poin4,
             };
                System.Drawing.SolidBrush myBrush4 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(A, R, G, B));
                g.FillPolygon(myBrush4, curvePoints2);
                g.FillRectangle(myBrush4, new Rectangle((r.Next(0, 350)), (r.Next(0, 350)), (r.Next(0, 350)), (r.Next(0, 350))));
                System.Drawing.Graphics formGraphics4;
                formGraphics4 = this.CreateGraphics();
                formGraphics4.FillPolygon(myBrush4, curvePoints2);
                formGraphics4.FillRectangle(myBrush4, new Rectangle((r.Next(0, 350)), (r.Next(0, 350)), (r.Next(0, 350)), (r.Next(0, 350))));
                myBrush4.Dispose();
                formGraphics4.Dispose();

            }
            else if (int.Parse(Tipo.Text) == 5)
            {
                // Create points that define polygon3.
                Point poi1 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poi2 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poi3 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poi4 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poi5 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point[] curvePoints3 =
                     {
                 poi1,
                 poi2,
                 poi3,
                 poi4,
                 poi5,
             };
                System.Drawing.SolidBrush myBrush5 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(A, R, G, B));
                g.FillPolygon(myBrush5, curvePoints3);
                System.Drawing.Graphics formGraphics5;
                formGraphics5 = this.CreateGraphics();
                formGraphics5.FillPolygon(myBrush5, curvePoints3);
                myBrush5.Dispose();
                formGraphics5.Dispose();

            }
            else if (int.Parse(Tipo.Text) == 6)
            {
                // Create points that define polygon4.
                Point po1 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point po2 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point po3 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point po4 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point po5 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point po6 = new Point(r.Next(0, 250), r.Next(0, 250));

                Point[] curvePoints4 =
                     {
                 po1,
                 po2,
                 po3,
                 po4,
                 po5,
                 po6,
             };
                System.Drawing.SolidBrush myBrush6 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(A, R, G, B));
                System.Drawing.Graphics formGraphics6;
                formGraphics6 = this.CreateGraphics();
                g.FillPolygon(myBrush6, curvePoints4);
                formGraphics6.FillPolygon(myBrush6, curvePoints4);
                myBrush6.Dispose();
                formGraphics6.Dispose();

            }
            else if (int.Parse(Tipo.Text) == 7)
            {
                // Create points that define polygon5.
                Point p1 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point p2 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point p3 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point p4 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point p5 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point p6 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point p7 = new Point(r.Next(0, 250), r.Next(0, 250));

                Point[] curvePoints5 =
                     {
                 p1,
                 p2,
                 p3,
                 p4,
                 p5,
                 p6,
                 p7,
             };
                System.Drawing.SolidBrush myBrush7 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(A, R, G, B));
                g.FillPolygon(myBrush7, curvePoints5);
                System.Drawing.Graphics formGraphics7;
                formGraphics7 = this.CreateGraphics();
                formGraphics7.FillPolygon(myBrush7, curvePoints5);
                myBrush7.Dispose();
                formGraphics7.Dispose();
            }
            else if (int.Parse(Tipo.Text) > 7)
            {
                MessageBox.Show("Numero no permitido!!! Solo debes ingresar numeros del 3 al 7");
            }
        }

        void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            /*GeneradorNA();
            label1.Text = GeneradorNA().ToString();*/
            //COLORES
            int A = r.Next(256);
            int R = r.Next(256);
            int G = r.Next(256);
            int B = r.Next(256);
            //COORDENADAS
            int X = r.Next(500);
            int Y = r.Next(500);
            //longitud
            int W = r.Next(500);
            int H = r.Next(500);


            //Creamos una variable tipo Bitmap
            Bitmap b;

            //Usamos el constructor para instanciar nuestro Bitmap y asignarle el tamaño
            //de nuestro PictureBox (EN ESTE CASO EL PICTUREBOX TIENE COMO NOMBRE pictureBox1)
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            //Asignamos nuestro objeto Bitmap como imagen de nuestro pictureBox
            pictureBox1.Image = (Image)b;

            //Creamos el objeto Graphics que nos servirá para dibujar en nuestro Bitmap
            Graphics g = Graphics.FromImage(b);

            if (int.Parse(Tipo.Text) < 3)
            {
                MessageBox.Show("Numero no permitido!!! Debes ingresar numeros del 3 al 7");
            }

            else if (int.Parse(Tipo.Text) == 3)
            {
                // Create points that define polygon.
                Point point1 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point point2 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point point3 = new Point(r.Next(0, 250), r.Next(0, 250));

                Point[] curvePoints =
                    {
                 point1,
                 point2,
                 point3,
             };
                System.Drawing.SolidBrush myBrush3 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(A, R, G, B));
                    g.FillPolygon(myBrush3, curvePoints);
                System.Drawing.Graphics formGraphics3;
                formGraphics3 = this.CreateGraphics();
                formGraphics3.FillPolygon(myBrush3, curvePoints);
                formGraphics3.Dispose();
                myBrush3.Dispose();
                
            }

            else if (int.Parse(Tipo.Text) == 4)
            {
                // Create points that define polygon2.
                Point poin1 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poin2 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poin3 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poin4 = new Point(r.Next(0, 250), r.Next(0, 250));

                Point[] curvePoints2 =
                   {
                 poin1,
                 poin2,
                 poin3,
                 poin4,
             };
                System.Drawing.SolidBrush myBrush4 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(A, R, G, B));
                g.FillPolygon(myBrush4, curvePoints2);
                g.FillRectangle(myBrush4, new Rectangle((r.Next(0, 350)), (r.Next(0, 350)), (r.Next(0, 350)), (r.Next(0, 350))));
                System.Drawing.Graphics formGraphics4;
                formGraphics4 = this.CreateGraphics();
                formGraphics4.FillPolygon(myBrush4, curvePoints2);
                formGraphics4.FillRectangle(myBrush4, new Rectangle((r.Next(0, 350)), (r.Next(0, 350)), (r.Next(0, 350)), (r.Next(0, 350))));
                myBrush4.Dispose();
                formGraphics4.Dispose();

            }
            else if (int.Parse(Tipo.Text) == 5)
            {
                // Create points that define polygon3.
                Point poi1 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poi2 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poi3 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poi4 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point poi5 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point[] curvePoints3 =
                     {
                 poi1,
                 poi2,
                 poi3,
                 poi4,
                 poi5,
             };
                System.Drawing.SolidBrush myBrush5 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(A, R, G, B));
                g.FillPolygon(myBrush5, curvePoints3);
                System.Drawing.Graphics formGraphics5;
                formGraphics5 = this.CreateGraphics();
                formGraphics5.FillPolygon(myBrush5, curvePoints3);
                myBrush5.Dispose();
                formGraphics5.Dispose();
                
            }
            else if (int.Parse(Tipo.Text) == 6)
            {
                // Create points that define polygon4.
                Point po1 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point po2 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point po3 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point po4 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point po5 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point po6 = new Point(r.Next(0, 250), r.Next(0, 250));

                Point[] curvePoints4 =
                     {
                 po1,
                 po2,
                 po3,
                 po4,
                 po5,
                 po6,
             };
                System.Drawing.SolidBrush myBrush6 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(A, R, G, B));
                System.Drawing.Graphics formGraphics6;
                formGraphics6 = this.CreateGraphics();
                g.FillPolygon(myBrush6, curvePoints4);
                formGraphics6.FillPolygon(myBrush6, curvePoints4);
                myBrush6.Dispose();
                formGraphics6.Dispose();
                
            }
            else if (int.Parse(Tipo.Text) == 7)
            {
                // Create points that define polygon5.
                Point p1 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point p2 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point p3 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point p4 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point p5 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point p6 = new Point(r.Next(0, 250), r.Next(0, 250));
                Point p7 = new Point(r.Next(0, 250), r.Next(0, 250));

                Point[] curvePoints5 =
                     {
                 p1,
                 p2,
                 p3,
                 p4,
                 p5,
                 p6,
                 p7,
             };
                System.Drawing.SolidBrush myBrush7 = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(A, R, G, B));
                g.FillPolygon(myBrush7, curvePoints5);
                System.Drawing.Graphics formGraphics7;
                formGraphics7 = this.CreateGraphics();
                formGraphics7.FillPolygon(myBrush7, curvePoints5);
                myBrush7.Dispose();
                formGraphics7.Dispose();
            }
            else if (int.Parse(Tipo.Text) > 7)
            {
                MessageBox.Show("Numero no permitido!!! Solo debes ingresar numeros del 3 al 7");
            }
        }

        private void FigurasAleatorias_Load(object sender, EventArgs e)
        {

        }
    }
}
