namespace ChessEngine
{
    public partial class frmMainForm : Form
    {
        Image imgDoska;
        Image imgKW;
        Image imgFW;
        Image imgLW;
        Image imgKnW;
        Image imgPW;
        Image imgSW;
        Image imgKB;
        Image imgFB;
        Image imgLB;
        Image imgKnB;
        Image imgPB;
        Image imgSB;


        int startFigureX = 33;
        int startFigureY = 33;
        int widthFigure = 90;
        int heightFigure = 90;
        int offsetX = 99;
        int offsetY = 99;

        Graphics GR;

        /*
         * A - LW
         * B - KnW
         * C - SW
         * D - KW
         * E - FW
         * F - PW
         * G - LB
         * H - KnB
         * I - SB
         * K - KB
         * L - FB
         * M - PB
        */
        string Pole = "GHILKIHGMMMMMMMM--------------------------------FFFFFFFFABCEDCBA";

        public frmMainForm()
        {
            InitializeComponent();            

            imgDoska = Properties.Resources.doska;
            imgKW = Properties.Resources.KW;
            imgFW = Properties.Resources.FW;
            imgLW = Properties.Resources.LW;
            imgKnW = Properties.Resources.KnW;
            imgPW = Properties.Resources.PW;
            imgSW = Properties.Resources.SW;
            imgKB = Properties.Resources.KB;
            imgFB = Properties.Resources.FB;
            imgLB = Properties.Resources.LB;
            imgKnB = Properties.Resources.KnB;
            imgPB = Properties.Resources.PB;
            imgSB = Properties.Resources.SB;            
        }

        private void frmMainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imgDoska, 0, 0, 850, 850);

            e.Graphics.DrawImage(imgPW, startFigureX + 0 * offsetX, startFigureY + 6 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPW, startFigureX + 1 * offsetX, startFigureY + 6 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPW, startFigureX + 2 * offsetX, startFigureY + 6 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPW, startFigureX + 3 * offsetX, startFigureY + 6 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPW, startFigureX + 4 * offsetX, startFigureY + 6 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPW, startFigureX + 5 * offsetX, startFigureY + 6 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPW, startFigureX + 6 * offsetX, startFigureY + 6 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPW, startFigureX + 7 * offsetX, startFigureY + 6 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgLW, startFigureX + 0 * offsetX, startFigureY + 7 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgKnW, startFigureX + 1 * offsetX, startFigureY + 7 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgSW, startFigureX + 2 * offsetX, startFigureY + 7 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgFW, startFigureX + 3 * offsetX, startFigureY + 7 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgKW, startFigureX + 4 * offsetX, startFigureY + 7 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgSW, startFigureX + 5 * offsetX, startFigureY + 7 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgKnW, startFigureX + 6 * offsetX, startFigureY + 7 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgLW, startFigureX + 7 * offsetX, startFigureY + 7 * offsetY, widthFigure, heightFigure);

            e.Graphics.DrawImage(imgPB, startFigureX + 0 * offsetX, startFigureY + 1 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPB, startFigureX + 1 * offsetX, startFigureY + 1 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPB, startFigureX + 2 * offsetX, startFigureY + 1 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPB, startFigureX + 3 * offsetX, startFigureY + 1 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPB, startFigureX + 4 * offsetX, startFigureY + 1 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPB, startFigureX + 5 * offsetX, startFigureY + 1 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPB, startFigureX + 6 * offsetX, startFigureY + 1 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgPB, startFigureX + 7 * offsetX, startFigureY + 1 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgLB, startFigureX + 0 * offsetX, startFigureY + 0 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgKnB, startFigureX + 1 * offsetX, startFigureY + 0 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgSB, startFigureX + 2 * offsetX, startFigureY + 0 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgFB, startFigureX + 3 * offsetX, startFigureY + 0 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgKB, startFigureX + 4 * offsetX, startFigureY + 0 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgSB, startFigureX + 5 * offsetX, startFigureY + 0 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgKnB, startFigureX + 6 * offsetX, startFigureY + 0 * offsetY, widthFigure, heightFigure);
            e.Graphics.DrawImage(imgLB, startFigureX + 7 * offsetX, startFigureY + 0 * offsetY, widthFigure, heightFigure);                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
