namespace Generateur_identité
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            TXTID2.Text = Form1.GETID;
            TXTNOM2.Text = Form1.GETNOM;
            TXTPRENOM2.Text = Form1.GETPRENOM;
            TXTETUDE2.Text = Form1.GETETUDE;
            TXTTELEPHONE2.Text = Form1.GETTELEPHONE;
            TXTVALIDATION2.Text = Form1.GETDATE;
            TXTNAISSANCE2.Text = Form1.GETNAISSANCE;
            IMGPP.Image = Form1.pctBx.Image;


        }

    }
}
