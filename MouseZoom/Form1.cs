using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseZoom
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }
        private Bitmap OriginalImage;
        private Bitmap CroppedImage;      
        private Bitmap DisplayImage;
        private Graphics DisplayGraphics;             
        PictureBox yeni = new PictureBox();
        int x, y;
        int w = 200;
        int h = 200;      
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {        
            if (pictureBox1.Image != null)
            {            
                Rectangle source_rect = new Rectangle(e.Location.X, e.Location.Y,w, h);
                Rectangle dest_rect = new Rectangle(0, 0, w, h);
                DisplayImage = new Bitmap(w, h);
                DisplayGraphics = Graphics.FromImage(DisplayImage);
                DisplayGraphics.DrawImage(CroppedImage,
                dest_rect, source_rect, GraphicsUnit.Pixel);
                // pictureBox2.Image = DisplayImage;
                yeni.Image = DisplayImage;
                yeni.Location = new Point(e.X, e.Y -25);
                GC.Collect();
                GC.SuppressFinalize(this);
                GC.WaitForPendingFinalizers();
                x = e.Location.X;
                y = e.Location.Y;            
            }                      
        }      
        private Bitmap LoadBitmapUnlocked(string file_name)
        {
            int w, h;
            using (Bitmap bm = new Bitmap(file_name))
            {
                Bitmap yeni = null;        
                Bitmap new_bitmap = new Bitmap(bm.Width, bm.Height);              
                using (Graphics gr = Graphics.FromImage(new_bitmap))
                {
                    gr.DrawImage(bm, 0, 0);
                }
                w = bm.Width;
                h = bm.Height;
                if (bm.Width > 1000  )
                {
                    w = panel1.Width;
                    h = panel1.Height;                 
                }                            
                yeni = new Bitmap(bm,w, h);
                pictureBox1.Size = new Size(w, h);
                return yeni;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {              
               OriginalImage = LoadBitmapUnlocked(openFileDialog1.FileName);
               label1.Text = openFileDialog1.FileName;              
               CroppedImage = OriginalImage.Clone() as Bitmap;
               DisplayImage = CroppedImage.Clone() as Bitmap;
               DisplayGraphics = Graphics.FromImage(DisplayImage);
               pictureBox1.Image = DisplayImage;
               pictureBox1.Visible = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            yeni.Size = new Size(300, 300);
            yeni.SizeMode = PictureBoxSizeMode.Zoom;
           // yeni.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Controls.Add(yeni);         
            yeni.Paint += Yeni_Paint;          
        }          
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            CroppedImage = pictureBox1.Image as Bitmap;         
            DisplayImage = CroppedImage.Clone() as Bitmap;
            DisplayGraphics = Graphics.FromImage(DisplayImage);
            pictureBox1.Refresh();
            yeni.Refresh();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            CroppedImage = pictureBox1.Image as Bitmap;
            DisplayImage = CroppedImage.Clone() as Bitmap;
            DisplayGraphics = Graphics.FromImage(DisplayImage);
            pictureBox1.Refresh();
            yeni.Refresh();
        }       
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle cerceve = pictureBox1.ClientRectangle;
            cerceve.Inflate(0, 0);
            Size a = new Size(10, 10);
            ControlPaint.DrawBorder(e.Graphics, cerceve, Color.Black, ButtonBorderStyle.Inset);        
        }
        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var fileName = label1.Text;
                var image = LoadBitmapUnlocked(fileName);
                var blur = new GaussianBlur(image as Bitmap);
                var sw = Stopwatch.StartNew();
                var result = blur.Process(5);            
                pictureBox1.Image = result as Image;
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;        
                blur = null;
                result = null;
                image = null;
                sw = null;
                GC.Collect();
                GC.SuppressFinalize(this);
                GC.SuppressFinalize(blur);
                GC.SuppressFinalize(image);
                GC.SuppressFinalize(sw);
                GC.WaitForPendingFinalizers();
            }
            catch (Exception hata)
            {
                Console.WriteLine("Hata :" + hata.Message);
            }
        }
        private void efektlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = OriginalImage;          
            CroppedImage = pictureBox1.Image as Bitmap;
            DisplayImage = CroppedImage.Clone() as Bitmap;
            DisplayGraphics = Graphics.FromImage(DisplayImage);
            pictureBox1.Refresh();
        }
        private void Yeni_Paint(object sender, PaintEventArgs e)
        {
            Rectangle cerceve = yeni.ClientRectangle;
             GraphicsPath gr = new GraphicsPath(FillMode.Alternate);
            gr.AddEllipse(0, 0, yeni.Width, yeni.Height);
            Region r = new Region(gr);
            yeni.Region = r;
            cerceve.Inflate(4, 4);
            SolidBrush br = new SolidBrush(Color.FromArgb(55, 255, 255, 255));
            Pen eee = new Pen(br, 20);       
            //e.Graphics.DrawRectangle(eee, cerceve);
            e.Graphics.DrawEllipse(eee, cerceve);
            cerceve.Inflate(-5,-5);
            Size a = new Size(10, 10);
           //  ControlPaint.DrawGrid(e.Graphics, cerceve, a, Color.White);                                 
           //  Pen pen = new Pen(Color.FromArgb(45,45,45),1.99f);
           //  pen.Alignment = PenAlignment.Inset; //<-- this
           //  e.Graphics.DrawEllipse(pen, cerceve);                  
               SolidBrush MyBrush = new SolidBrush(Color.FromArgb(45, 255, 255, 255));
              // e.Graphics.DrawRectangle(eee, cerceve);        
               e.Graphics.DrawEllipse(eee, cerceve);
            
        }            
    }
}
