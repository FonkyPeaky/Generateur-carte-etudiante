namespace Generateur_identité
{
    public partial class Form1 : Form
    {
        //On crée les prestataires Form to Form2

        public static string GETNOM = "";
        public static string GETPRENOM = "";
        public static string GETGENRE = "";
        public static string GETTELEPHONE = "";
        public static string GETNAISSANCE = "";
        public static string GETDATE = "";
        public static string GETETUDE = "";
        public static string GETID = "";

        public static PictureBox pctBx = new();

        string Reveal = "";

        public Form1()
        {
            InitializeComponent();

        }

        public void BTNRANDOM_Click(object sender, EventArgs e)
        {
            // Generer un nombre aleatoire pour un identifiant unique de 19870500 a 98463240;
            // Debute par #H si Homme coché & #F si femme coché

            Random num = new();
            var randomBetween = num.Next(19870500, 98463240);

            if (this.RDHOMME.Checked)
            {
                TXTID.Text = "#H" + randomBetween.ToString();
            }
            if (this.RDFEMME.Checked)
            {
                TXTID.Text = "#F" + randomBetween.ToString();
            }
        }

        public string RDHOMME_Checked()
        {
            //Clear la textbox ID au changement du genre afin de pas crée de confusion 

            if (this.RDFEMME.Checked)
            {
                TXTID.Clear();
                Reveal = "Femme";
            }
            else
            {
                TXTID.Clear();
                Reveal = "Homme";
            }
            return Reveal;
        }

        private void BTNDOWNLOAD_Click_1(object sender, EventArgs e)
        {
            //Filtrer les Img compatibles et ouvrir l'explorateur de ficher

            OpenFileDialog open = new();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {

                PIC_ID.Image = new Bitmap(open.FileName);
            }

            pctBx.Image = PIC_ID.Image;
        }

        private void BTNAPERCU_Click(object sender, EventArgs e)
        {
            //Appel a un prestataire pour envoyé les infos dans un enouvelle form (form2)
            GETNOM = TXTNOM.Text;
            GETPRENOM = TXTPRENOM.Text;
            GETETUDE = TXTETUDE.Text;
            GETDATE = dateTimePicker2.Text;
            GETTELEPHONE = TXTNUMERO.Text;
            GETID = TXTID.Text;
            GETNAISSANCE = dateTimePicker1.Text;
            this.RDHOMME_Checked();
            GETGENRE = Reveal;

            Form form2 = new Form2();
            form2.ShowDialog();
        }

        public void BTNADD_Click(object sender, EventArgs e)
        {
            Form2 form2 = new();

            using Graphics gfx = form2.CreateGraphics();
            using Bitmap card = new Bitmap(form2.Height, form2.Width, gfx);

            form2.DrawToBitmap(card, new(0, 0, form2.Height, form2.Width));
            card.Save("panel.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            form2.ShowDialog();
        }
    }
}