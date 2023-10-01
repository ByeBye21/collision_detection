/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
**
** ÖDEV NUMARASI…...: 1
** ÖĞRENCİ ADI...............: YOUNES RAHEBI
** ÖĞRENCİ NUMARASI.: B221210588
** DERS GRUBU…………: B GRUBU 1.ÖĞRETİM
** YOUTUBE LİNKİ… …: https://youtu.be/hjA1cJUikO8
****************************************************************************/

using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;

namespace NDP___Carpisma
{
    public partial class Form1 : Form
    {
        private Random random;
        public Form1()
        {
            InitializeComponent();

            // Rastgele bir sayı üreteci oluştur
            random = new Random();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Graphics g = panel.CreateGraphics();
            g.Clear(panel.BackColor);

            // Combobox'tan seçilen öğeyi al
            string selectedItem = (string)comboBox.SelectedItem;
            string selectedItem1 = (string)comboBox1.SelectedItem;

            // Rastgele boyutlar ve koordinatlar üret
            int x = random.Next(0, panel.Width);
            int y = random.Next(0, panel.Height);

            Nesne nesne1 = null;

            // Seçilen geometrik nesneyi rastgele boyutlar ve koordinatlarla çiz
            if (selectedItem == "Nokta")
            {
                Nokta nokta = new Nokta(x, y);
                nokta.Draw(panel.CreateGraphics());
                nesne1 = nokta;
            }
            else if (selectedItem == "Dikdortgen")
            {
                int width = random.Next(10, 100);
                int height = random.Next(10, 100);
                Dikdortgen dikdortgen = new Dikdortgen(x, y, width, height);
                dikdortgen.Draw(panel.CreateGraphics());
                nesne1 = dikdortgen;
            }
            else if (selectedItem == "Daire")
            {
                int radius = random.Next(10, 50);
                Daire daire = new Daire(x, y, radius);
                daire.Draw(panel.CreateGraphics());
                nesne1 = daire;
            }
            else if (selectedItem == "Kure")
            {
                int radius = random.Next(10, 50);
                Kure kure = new Kure(x, y, radius);
                kure.Draw(panel.CreateGraphics());
                nesne1 = kure;
            }
            else if (selectedItem == "Yuzey")
            {
                int width = random.Next(50, 150);
                int height = random.Next(50, 150);
                Yuzey yuzey = new Yuzey(x, y, width, height);
                yuzey.Draw(panel.CreateGraphics());
                nesne1 = yuzey;

            }
            else if (selectedItem == "Prizma")
            {
                int width = random.Next(10, 100);
                int height = random.Next(10, 100);
                int depth = random.Next(10, 50);
                Prizma prizma = new Prizma(x, y, width, height, depth);
                prizma.Draw(panel.CreateGraphics());
                nesne1 = prizma;
            }
            else if (selectedItem == "Silindir")
            {
                int radius = random.Next(10, 50);
                int height = random.Next(10, 100);
                Silindir silindir = new Silindir(x, y, radius, height);
                silindir.Draw(panel.CreateGraphics());
                nesne1 = silindir;
            }


            // Rastgele boyutlar ve koordinatlar üret
            int m = random.Next(0, panel.Width);
            int n = random.Next(0, panel.Height);

            Nesne nesne2 = null;

            // Seçilen geometrik nesneyi rastgele boyutlar ve koordinatlarla çiz
            if (selectedItem1 == "Nokta")
            {
                Nokta nokta = new Nokta(m, n);
                nokta.Draw(panel.CreateGraphics());
                nesne2 = nokta;
            }
            else if (selectedItem1 == "Dikdortgen")
            {
                int width = random.Next(10, 100);
                int height = random.Next(10, 100);
                Dikdortgen dikdortgen = new Dikdortgen(m, n, width, height);
                dikdortgen.Draw(panel.CreateGraphics());
                nesne2 = dikdortgen;
            }
            else if (selectedItem1 == "Daire")
            {
                int radius = random.Next(10, 50);
                Daire daire = new Daire(m, n, radius);
                daire.Draw(panel.CreateGraphics());
                nesne2 = daire;
            }
            else if (selectedItem1 == "Kure")
            {
                int radius = random.Next(10, 50);
                Kure kure = new Kure(m, n, radius);
                kure.Draw(panel.CreateGraphics());
                nesne2 = kure;
            }
            else if (selectedItem1 == "Yuzey")
            {
                int width = random.Next(50, 150);
                int height = random.Next(50, 150);
                Yuzey yuzey = new Yuzey(m, n, width, height);
                yuzey.Draw(panel.CreateGraphics());
                nesne2 = yuzey;

            }
            else if (selectedItem1 == "Prizma")
            {
                int width = random.Next(10, 100);
                int height = random.Next(10, 100);
                int depth = random.Next(10, 50);
                Prizma prizma = new Prizma(m, n, width, height, depth);
                prizma.Draw(panel.CreateGraphics());
                nesne2 = prizma;
            }
            else if (selectedItem1 == "Silindir")
            {
                int radius = random.Next(10, 50);
                int height = random.Next(10, 100);
                Silindir silindir = new Silindir(m, n, radius, height);
                silindir.Draw(panel.CreateGraphics());
                nesne2 = silindir;
            }

            // Seçilen nesnelerin kesişip kesişmediğini kontrol ed
            if (nesne1 != null && nesne2 != null)
            {
                if (nesne1.Carpisma(nesne2) || nesne2.Carpisma(nesne1))
                {
                    label.BackColor = Color.Green;
                    label.Text = "Çarpısma Var";
                }
                else
                {
                    label.BackColor = Color.Red;
                    label.Text = "Çarpısma Yok";
                }
            }
            else
            {
                label.BackColor = Color.Yellow;
                label.Text = "Nesneleri Seçiniz";
            }

        }

    }

    public abstract class Nesne
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Nesne(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void Draw(Graphics graphics);

        public virtual bool Carpisma(Nesne nesne)
        {
            return false;
        }
    }

    public class Nokta : Nesne
    {
        public Nokta(int x, int y) : base(x, y) { }

        public override void Draw(Graphics graphics)
        {
            graphics.FillEllipse(Brushes.Blue, X, Y, 4, 4);
        }

        public override bool Carpisma(Nesne nesne)
        {
            if (nesne is Nokta nokta)
            {
                // İki noktanın aynı koordinatlara sahip olup olmadığını kontrol ed
                return X == nokta.X && Y == nokta.Y;
            }
            else if (nesne is Dikdortgen dikdortgen)
            {
                // Noktanın dikdörtgenin içinde olup olmadığını kontrol ed
                return X >= dikdortgen.X && X <= dikdortgen.X + dikdortgen.Width && Y >= dikdortgen.Y && Y <= dikdortgen.Y + dikdortgen.Height;
            }
            else if (nesne is Daire daire)
            {
                // Dairenin merkezi ile nokta arasındaki mesafeyi hesapla
                int distanceX = X - daire.X;
                int distanceY = Y - daire.Y;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin dairenin yarıçapından küçük veya eşit olup olmadığını kontrol ed
                return distanceSquared <= daire.Radius * daire.Radius;
            }
            else if (nesne is Kure kure)
            {
                // Kürenin merkezi ile nokta arasındaki mesafeyi hesapla
                int distanceX = X - kure.X;
                int distanceY = Y - kure.Y;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin kürenin yarıçapından küçük veya eşit olup olmadığını kontrol ed
                return distanceSquared <= kure.Radius * kure.Radius;
            }
            else if (nesne is Yuzey yuzey)
            {
                // Noktanın yüzeyin içinde olup olmadığını kontrol ed
                return X >= yuzey.X && X <= yuzey.X + yuzey.Width && Y >= yuzey.Y && Y <= yuzey.Y + yuzey.Height;
            }
            else if (nesne is Prizma prizma)
            {
                // Noktanın prizmanın içinde olup olmadığını kontrol ed
                return X >= prizma.X && X <= prizma.X + prizma.Width && Y >= prizma.Y && Y <= prizma.Y + prizma.Height;
            }
            else if (nesne is Silindir silindir)
            {
                // Silindirin merkezi ile nokta arasındaki mesafeyi hesapla
                int distanceX = X - silindir.X;
                int distanceY = Y - silindir.Y;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin silindirin yarıçapından küçük veya eşit olup olmadığını kontrol ed
                return distanceSquared <= silindir.Radius * silindir.Radius;
            }
            return base.Carpisma(nesne);
        }
    }
    public class Dikdortgen : Nesne
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public Dikdortgen(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(Pens.Black, X, Y, Width, Height);
        }

        public override bool Carpisma(Nesne nesne)
        {
            if (nesne is Dikdortgen dikdortgen)
            {
                return X < dikdortgen.X + dikdortgen.Width && X + Width > dikdortgen.X && Y < dikdortgen.Y + dikdortgen.Height && Y + Height > dikdortgen.Y;
            }
            else if (nesne is Daire daire)
            {
                // Dairenin merkezine en yakın dikdörtgen noktasını bul
                int closestX = Math.Max(X, Math.Min(daire.X, X + Width));
                int closestY = Math.Max(Y, Math.Min(daire.Y, Y + Height));

                // Bu nokta ile dairenin merkezi arasındaki mesafeyi hesapla
                int distanceX = daire.X - closestX;
                int distanceY = daire.Y - closestY;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin dairenin yarıçapından küçük veya eşit olup olmadığını kontrol ed
                return distanceSquared <= daire.Radius * daire.Radius;
            }
            else if (nesne is Kure kure)
            {
                // Kürenin merkezine en yakın dikdörtgen noktasını bul
                int closestX = Math.Max(X, Math.Min(kure.X, X + Width));
                int closestY = Math.Max(Y, Math.Min(kure.Y, Y + Height));

                // Bu nokta ile kürenin merkezi arasındaki mesafeyi hesapla
                int distanceX = kure.X - closestX;
                int distanceY = kure.Y - closestY;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin kürenin yarıçapından küçük veya eşit olup olmadığını kontrol ed
                return distanceSquared <= kure.Radius * kure.Radius;
            }
            else if (nesne is Yuzey yuzey)
            {
                return X < yuzey.X + yuzey.Width && X + Width > yuzey.X && Y < yuzey.Y + yuzey.Height && Y + Height > yuzey.Y;
            }
            else if (nesne is Prizma prizma)
            {
                return X < prizma.X + prizma.Width && X + Width > prizma.X && Y < prizma.Y + prizma.Height && Y + Height > prizma.Y;
            }
            else if (nesne is Silindir silindir)
            {
                // Silindirin merkezine en yakın dikdörtgen noktasını bul
                int closestX = Math.Max(X, Math.Min(silindir.X, X + Width));
                int closestY = Math.Max(Y, Math.Min(silindir.Y, Y + Height));

                // Bu nokta ile silindirin merkezi arasındaki mesafeyi hesapla
                int distanceX = silindir.X - closestX;
                int distanceY = silindir.Y - closestY;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin silindirin yarıçapından küçük veya eşit olup olmadığını kontrol ed
                return distanceSquared <= silindir.Radius * silindir.Radius;
            }
            return base.Carpisma(nesne);
        }
    }

    public class Daire : Nesne
    {
        public int Radius { get; set; }

        public Daire(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(Pens.Black, X - Radius, Y - Radius, Radius + Radius, Radius + Radius);
        }

        public override bool Carpisma(Nesne nesne)
        {
            if (nesne is Daire daire)
            {
                // İki dairenin merkezleri arasındaki mesafeyi hesapla
                int distanceX = X - daire.X;
                int distanceY = Y - daire.Y;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin iki dairenin yarıçaplarının toplamından küçük veya eşit olup olmadığını kontrol ed
                int toplamradius = Radius + daire.Radius;
                return distanceSquared <= toplamradius * toplamradius;
            }
            else if (nesne is Kure kure)
            {
                // Dairenin merkezi ile kürenin merkezi arasındaki mesafeyi hesapla
                int distanceX = X - kure.X;
                int distanceY = Y - kure.Y;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin dairenin ve kürenin yarıçaplarının toplamından küçük veya eşit olup olmadığını kontrol ed
                int toplamradius = Radius + kure.Radius;

                return distanceSquared <= toplamradius * toplamradius;
            }
            else if (nesne is Yuzey yuzey)
            {
                // Dairenin merkezine en yakın yüzey noktasını bul
                int closestX = Math.Max(yuzey.X, Math.Min(X, yuzey.X + yuzey.Width));
                int closestY = Math.Max(yuzey.Y, Math.Min(Y, yuzey.Y + yuzey.Height));

                // Bu nokta ile dairenin merkezi arasındaki mesafeyi hesapla
                int distanceX = X - closestX;
                int distanceY = Y - closestY;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin dairenin yarıçapından küçük veya eşit olup olmadığını kontrol ed
                return distanceSquared <= Radius * Radius;
            }
            else if (nesne is Prizma prizma)
            {
                // Dairenin merkezine en yakın prizma noktasını bul
                int closestX = Math.Max(prizma.X, Math.Min(X, prizma.X + prizma.Width));
                int closestY = Math.Max(prizma.Y, Math.Min(Y, prizma.Y + prizma.Height));

                // Bu nokta ile dairenin merkezi arasındaki mesafeyi hesapla
                int distanceX = X - closestX;
                int distanceY = Y - closestY;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin dairenin yarıçapından küçük veya eşit olup olmadığını kontrol ed
                return distanceSquared <= Radius * Radius;
            }
            else if (nesne is Silindir silindir)
            {
                // Dairenin merkezi ile silindirin merkezi arasındaki mesafeyi hesapla
                int distanceX = X - silindir.X;
                int distanceY = Y - silindir.Y;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin dairenin ve silindirin yarıçaplarının toplamından küçük veya eşit olup olmadığını kontrol ed
                int toplamradius = Radius + silindir.Radius;

                return distanceSquared <= toplamradius * toplamradius;
            }

            return base.Carpisma(nesne);
        }
    }

    public class Kure : Nesne
    {
        public int Radius { get; set; }

        public Kure(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public override void Draw(Graphics graphics)
        {
            // Bir radyal gradyan fırçası oluştur
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(X - Radius, Y - Radius, Radius + Radius, Radius + Radius);
            PathGradientBrush brush = new PathGradientBrush(path);
            brush.CenterColor = Color.White;
            brush.SurroundColors = new Color[] { Color.Gray };

            // Daireyi radyal gradyan fırçası ile doldur
            graphics.FillEllipse(brush, X - Radius, Y - Radius, Radius + Radius, Radius + Radius);

            // Dairenin dış çizgisini çiz
            graphics.DrawEllipse(Pens.Black, X - Radius, Y - Radius, Radius + Radius, Radius + Radius);
        }

        public override bool Carpisma(Nesne nesne)
        {
            if (nesne is Kure kure)
            {
                // İki kürenin merkezleri arasındaki mesafeyi hesapla
                int distanceX = X - kure.X;
                int distanceY = Y - kure.Y;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin iki kürenin yarıçaplarının toplamından küçük veya eşit olup olmadığını kontrol ed
                int toplamradius = Radius + kure.Radius;

                return distanceSquared <= toplamradius * toplamradius;
            }
            else if (nesne is Yuzey yuzey)
            {
                // Kürenin merkezine en yakın yüzey noktasını bul
                int closestX = Math.Max(yuzey.X, Math.Min(X, yuzey.X + yuzey.Width));
                int closestY = Math.Max(yuzey.Y, Math.Min(Y, yuzey.Y + yuzey.Height));

                // Bu nokta ile kürenin merkezi arasındaki mesafeyi hesapla
                int distanceX = X - closestX;
                int distanceY = Y - closestY;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin kürenin yarıçapından küçük veya eşit olup olmadığını kontrol ed
                return distanceSquared <= Radius * Radius;
            }
            else if (nesne is Prizma prizma)
            {
                // Kürenin merkezine en yakın prizma noktasını bul
                int closestX = Math.Max(prizma.X, Math.Min(X, prizma.X + prizma.Width));
                int closestY = Math.Max(prizma.Y, Math.Min(Y, prizma.Y + prizma.Height));

                // Bu nokta ile kürenin merkezi arasındaki mesafeyi hesapla
                int distanceX = X - closestX;
                int distanceY = Y - closestY;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin kürenin yarıçapından küçük veya eşit olup olmadığını kontrol ed
                return distanceSquared <= Radius * Radius;
            }
            else if (nesne is Silindir silindir)
            {
                // Kürenin merkezi ile silindirin merkezi arasındaki mesafeyi hesapla
                int distanceX = X - silindir.X;
                int distanceY = Y - silindir.Y;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin kürenin ve silindirin yarıçaplarının toplamından küçük veya eşit olup olmadığını kontrol ed
                int toplamradius = Radius + silindir.Radius;

                return distanceSquared <= toplamradius * toplamradius;
            }

            return base.Carpisma(nesne);
        }
    }

    public class Yuzey : Nesne
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public Yuzey(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.FillRectangle(Brushes.Gray, X, Y, Width, Height);
        }

        public override bool Carpisma(Nesne nesne)
        {
            if (nesne is Yuzey yuzey)
            {
                return X < yuzey.X + yuzey.Width && X + Width > yuzey.X && Y < yuzey.Y + yuzey.Height && Y + Height > yuzey.Y;
            }
            else if (nesne is Prizma prizma)
            {
                return X < prizma.X + prizma.Width && X + Width > prizma.X && Y < prizma.Y + prizma.Height && Y + Height > prizma.Y;
            }
            else if (nesne is Silindir silindir)
            {
                // Silindirin merkezine en yakın yüzey noktasını bul
                int closestX = Math.Max(X, Math.Min(silindir.X, X + Width));
                int closestY = Math.Max(Y, Math.Min(silindir.Y, Y + Height));

                // Bu nokta ile silindirin merkezi arasındaki mesafeyi hesapla
                int distanceX = silindir.X - closestX;
                int distanceY = silindir.Y - closestY;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin silindirin yarıçapından küçük veya eşit olup olmadığını kontrol ed
                return distanceSquared <= silindir.Radius * silindir.Radius;
            }

            return base.Carpisma(nesne);
        }
    }

    public class Prizma : Nesne
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Depth { get; set; }

        public Prizma(int x, int y, int width, int height, int depth) : base(x, y)
        {
            Width = width;
            Height = height;
            Depth = depth;
        }

        public override void Draw(Graphics graphics)
        {
            // Prizmanın noktalarını tanımla
            Point[] points = new Point[8];
            points[0] = new Point(X, Y);
            points[1] = new Point(X + Width, Y);
            points[2] = new Point(X + Width + Depth, Y + Depth);
            points[3] = new Point(X + Depth, Y + Depth);
            points[4] = new Point(X, Y + Height);
            points[5] = new Point(X + Width, Y + Height);
            points[6] = new Point(X + Width + Depth, Y + Height + Depth);
            points[7] = new Point(X + Depth, Y + Height + Depth);

            // Prizmanın kenarlarını çiz
            graphics.DrawPolygon(Pens.Black, new Point[] { points[0], points[1], points[5], points[4] });
            graphics.DrawPolygon(Pens.Black, new Point[] { points[1], points[2], points[6], points[5] });
            graphics.DrawPolygon(Pens.Black, new Point[] { points[2], points[3], points[7], points[6] });
            graphics.DrawPolygon(Pens.Black, new Point[] { points[3], points[0], points[4], points[7] });

            // Prizmanın üst ve altını çiz
            graphics.DrawPolygon(Pens.Black, new Point[] { points[0], points[1], points[2], points[3] });
            graphics.DrawPolygon(Pens.Black, new Point[] { points[4], points[5], points[6], points[7] });

        }

        public override bool Carpisma(Nesne nesne)
        {
            if (nesne is Prizma prizma)
            {
                return X < prizma.X + prizma.Width && X + Width > prizma.X && Y < prizma.Y + prizma.Height && Y + Height > prizma.Y;
            }
            else if (nesne is Silindir silindir)
            {
                // Silindirin merkezine en yakın prizma noktasını bul
                int closestX = Math.Max(X, Math.Min(silindir.X, X + Width));
                int closestY = Math.Max(Y, Math.Min(silindir.Y, Y + Height));

                // Bu nokta ile silindirin merkezi arasındaki mesafeyi hesapla
                int distanceX = silindir.X - closestX;
                int distanceY = silindir.Y - closestY;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin silindirin yarıçapından küçük veya eşit olup olmadığını kontrol ed
                return distanceSquared <= silindir.Radius * silindir.Radius;
            }
            return base.Carpisma(nesne);
        }
    }

    public class Silindir : Nesne
    {
        public int Radius { get; set; }
        public int Height { get; set; }

        public Silindir(int x, int y, int radius, int height) : base(x, y)
        {
            Radius = radius;
            Height = height;
        }

        public override void Draw(Graphics graphics)
        {
            // Üst ve alt daireler için bir yol oluştur
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(X - Radius, Y - Radius, Radius + Radius, Radius + Radius);
            path.AddEllipse(X - Radius, Y + Height - Radius, Radius + Radius, Radius + Radius);

            // Silindirin kenarları için bir yol oluştur
            GraphicsPath sidePath = new GraphicsPath();
            sidePath.AddLine(X - Radius, Y, X - Radius, Y + Height);
            sidePath.AddLine(X - Radius, Y + Height, X + Radius, Y + Height);
            sidePath.AddLine(X + Radius, Y + Height, X + Radius, Y);
            sidePath.AddLine(X + Radius, Y, X - Radius, Y);

            // Üst ve alt daireler için bir yol gradyan fırçası oluştur
            PathGradientBrush brush = new PathGradientBrush(path);
            brush.CenterColor = Color.White;
            brush.SurroundColors = new Color[] { Color.Gray };

            // Üst ve alt daireleri yol gradyan fırçası ile doldur
            graphics.FillPath(brush, path);

            // Silindirin kenarlarını doğrusal gradyan fırçası ile doldur
            LinearGradientBrush sideBrush = new LinearGradientBrush(new Point(X - Radius, Y), new Point(X - Radius, Y + Height), Color.White, Color.Gray);
            graphics.FillPath(sideBrush, sidePath);

            // Silindirin dış çizgisini çiz
            graphics.DrawPath(Pens.Black, path);
            graphics.DrawPath(Pens.Black, sidePath);
        }
        public override bool Carpisma(Nesne nesne)
        {
            if (nesne is Silindir silindir)
            {
                // İki silindirin merkezleri arasındaki mesafeyi hesapla
                int distanceX = X - silindir.X;
                int distanceY = Y - silindir.Y;
                int distanceSquared = distanceX * distanceX + distanceY * distanceY;

                // Bu mesafenin iki silindirin yarıçaplarının toplamından küçük veya eşit olup olmadığını kontrol ed
                int toplamradius = Radius + silindir.Radius;

                return distanceSquared <= toplamradius * toplamradius;
            }
            return base.Carpisma(nesne);
        }
    }


}