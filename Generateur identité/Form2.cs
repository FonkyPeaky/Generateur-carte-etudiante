namespace Generateur_identité
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            // Les informations prevenant des TXTBOX de la Form1

            InitializeComponent();

            TXTID2.Text = Form1.GETID;
            TXTNOM2.Text = Form1.GETNOM;
            TXTPRENOM2.Text = Form1.GETPRENOM;
            TXTETUDE2.Text = Form1.GETETUDE;
            TXTTELEPHONE2.Text = Form1.GETTELEPHONE;
            TXTVALIDATION2.Text = Form1.GETDATE;
            TXTNAISSANCE2.Text = Form1.GETNAISSANCE;
            IMGPP.Image = Form1.pctBx.Image;

            // Kind reminder de la taille du screenshot
            panel1.Height = 542;
            panel1.Width = 867;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            //  Ouverture du lecteur pdf par defaut du system

            try
            {
                System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
                doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(ToPdf_PrintPage);
                doc.Print();
            }
            catch
            {
                MessageBox.Show("Vous devez posseder un lecteur PDF", "Erreur lecture");
            }
        }

        public void ToPdf_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //  Creation du Screenshot Taille + Localisation

            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height, panel1.CreateGraphics());
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, panel1.Width, panel1.Height));
            RectangleF bounds = e.PageSettings.PrintableArea;
            float factor = ((float)bmp.Height / (float)bmp.Width);
            e.Graphics.DrawImage(bmp, bounds.Left, bounds.Top, bounds.Width, factor * bounds.Width);

        }
    }
}
