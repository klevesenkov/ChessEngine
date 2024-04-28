namespace ChessEngine
{
    public partial class frmMainForm : Form
    {
        Image imgDoska;
        Image imgKW;
        public frmMainForm()
        {
            InitializeComponent();

            imgDoska = Properties.Resources.doska;
            imgKW = Properties.Resources.KW;
        }

        private void frmMainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imgDoska, Point.Empty);
            e.Graphics.DrawImage(imgKW, 50, 350);
        }
    }
}
