namespace ChessEngine
{
    public partial class frmMainForm : Form
    {
        Image imgDoska;
        Image imgKW;

        int startFigureX = 33;
        int startFigureY = 33;
        int widthFigure = 90;
        int heightFigure = 90;
        int offsetX = 99;
        int offsetY = 99;
        int widthLine = 5;
        int heightLine = 5;

        public frmMainForm()
        {
            InitializeComponent();

            imgDoska = Properties.Resources.doska;
            imgKW = Properties.Resources.KW;
            
            
        }

        private void frmMainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imgDoska, 0, 0, 850, 850);
            e.Graphics.DrawImage(imgKW, startFigureX, startFigureY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgKW, startFigureX + offsetX, startFigureY + offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgKW, startFigureX + 2 * offsetX, startFigureY + 2 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgKW, startFigureX + 3 * offsetX, startFigureY + 3 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgKW, startFigureX + 4 * offsetX, startFigureY + 4 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgKW, startFigureX + 5 * offsetX, startFigureY + 5 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgKW, startFigureX + 6 * offsetX, startFigureY + 6 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgKW, startFigureX + 7 * offsetX, startFigureY + 7 * offsetY, widthFigure, heightFigure);
        }
    }
}
