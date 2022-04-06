namespace Generateur_identité
{
    public partial class Form1 : Form
    {
        // On crée les prestataires Form to Form2

        public static string GETNOM = "";
        public static string GETPRENOM = "";
        public static string GETGENRE = "";
        public static string GETTELEPHONE = "";
        public static string GETNAISSANCE = "";
        public static string GETDATE = "";
        public static string GETETUDE = "";
        public static string GETID = "";

        public static PictureBox pctBx = new();

        string GenderReveal = "";


        public Form1()
        {
            InitializeComponent();
        }


        // Clear la textbox ID au changement du genre afin de pas crée de confusion entre #H & #F

        private void RDFEMME_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RDHOMME.Checked)
            {
                GenderReveal = "Homme";
                TXTID.Clear();
            }
            GETGENRE = GenderReveal;
        }

        private void RDHOMME_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RDFEMME.Checked)
            {
                GenderReveal = "Femme";
                TXTID.Clear();
            }
            GETGENRE = GenderReveal;

        }

        public void BTNRANDOM_Click(object sender, EventArgs e)
        {
            // Generer un nombre aleatoire pour un identifiant unique de 10025493 a 99463299;
            // Debute par #H si Homme check & #F si Femme check

            Random num = new();
            var randomBetween = num.Next(10025493, 99463299);

            if (this.RDHOMME.Checked)
            {
                TXTID.Text = "#H" + randomBetween.ToString();
            }
            if (this.RDFEMME.Checked)
            {
                TXTID.Text = "#F" + randomBetween.ToString();
            }
        }

        private void BTNDOWNLOAD_Click_1(object sender, EventArgs e)
        {
            // Filtrer les Img compatibles et ouvrir l'explorateur de ficher

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

            if (String.IsNullOrEmpty(TXTNOM.Text))
            {
                string ErrorNom = Microsoft.VisualBasic.Interaction.InputBox("Merci de renseigné votre nom", "Oups !", "Votre Nom ICI");
                TXTNOM.Text = ErrorNom;
            }
            if (String.IsNullOrEmpty(TXTPRENOM.Text))
            {
                string ErrorPrenom = Microsoft.VisualBasic.Interaction.InputBox("Merci de renseigné votre prenom", "Oups !", "Votre prenom ICI");
                TXTPRENOM.Text = ErrorPrenom;
            }

            if (String.IsNullOrEmpty(TXTNUMERO.Text))
            {
                string ErrorNumero = Microsoft.VisualBasic.Interaction.InputBox("Merci de renseigné votre numero", "Oups !", "Inserer votre numero ICI");
                TXTNUMERO.Text = ErrorNumero;
            }
            if (String.IsNullOrEmpty(TXTETUDE.Text))
            {
                string ErrorEtude = Microsoft.VisualBasic.Interaction.InputBox("Merci de renseigné vos etudes", "Oups !", "Inserer votre Etude ICI");
                TXTETUDE.Text = ErrorEtude;
            }
            if (String.IsNullOrEmpty(TXTID.Text))
            {

                MessageBox.Show("Merci de renseigné votre ID \nAstuce = Cliquez sur le bouton de droite pour faire apparaître votre ID", "Oups !");
            }
            else if (TXTID.Text.Contains("#"))
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }



        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " dd  -  MM  -  yyyy  ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
            dateTimePicker1.Text = datetime1;

            dateTimePicker2.CustomFormat = " dd  -  MM  -  yyyy  ";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            dateTimePicker2.Text = datetime2;
        }

        private void TXTNOM_TextChanged(object sender, EventArgs e)
        {

            GETNOM = TXTNOM.Text;

        }

        private void TXTPRENOM_TextChanged(object sender, EventArgs e)
        {

            GETPRENOM = TXTPRENOM.Text;

        }

        private void TXTETUDE_TextChanged(object sender, EventArgs e)
        {

            GETETUDE = TXTETUDE.Text;

        }

        private void TXTNUMERO_TextChanged(object sender, EventArgs e)
        {

            GETTELEPHONE = TXTNUMERO.Text;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            GETNAISSANCE = dateTimePicker1.Text;

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

            GETDATE = dateTimePicker2.Text;

        }

        private void TXTID_TextChanged(object sender, EventArgs e)
        {

            GETID = TXTID.Text;

        }
    }
}


