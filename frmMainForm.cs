using System.Drawing;
using System.Windows.Forms;

namespace ChessEngine
{
    public partial class FrmMainForm : Form
    {
        Image imgDoska;
        Pole pole = new Pole();

        int startFigureX = 33;
        int startFigureY = 33;
        int widthFigure = 90;
        int heightFigure = 90;
        int offsetX = 99;
        int offsetY = 99; 
        

        public FrmMainForm()
        {
            InitializeComponent();
            imgDoska = Properties.Resources.doska;
            initilizationPole(pole.initialState);                     
        }

        private void frmMainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imgDoska, 0, 0, 850, 850);           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            pbxPW1.Location = new Point(startFigureX + rnd.Next(0, 7) * offsetX, startFigureY + rnd2.Next(0, 7) * offsetY);
        }

        private void initilizationPole(string pole)
        {
            pbxPW1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPW1.Size = new Size(widthFigure, heightFigure);
            pbxPW2.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPW2.Size = new Size(widthFigure, heightFigure);
            pbxPW3.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPW3.Size = new Size(widthFigure, heightFigure);
            pbxPW4.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPW4.Size = new Size(widthFigure, heightFigure);
            pbxPW5.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPW5.Size = new Size(widthFigure, heightFigure);
            pbxPW6.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPW6.Size = new Size(widthFigure, heightFigure);
            pbxPW7.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPW7.Size = new Size(widthFigure, heightFigure);
            pbxPW8.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPW8.Size = new Size(widthFigure, heightFigure);
            pbxLW1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLW1.Size = new Size(widthFigure, heightFigure);
            pbxKnW1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxKnW1.Size = new Size(widthFigure, heightFigure);
            pbxSW1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxSW1.Size = new Size(widthFigure, heightFigure);
            pbxFW.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFW.Size = new Size(widthFigure, heightFigure);
            pbxKW.SizeMode = PictureBoxSizeMode.Zoom;
            pbxKW.Size = new Size(widthFigure, heightFigure);
            pbxSW2.SizeMode = PictureBoxSizeMode.Zoom;
            pbxSW2.Size = new Size(widthFigure, heightFigure);
            pbxKnW2.SizeMode = PictureBoxSizeMode.Zoom;
            pbxKnW2.Size = new Size(widthFigure, heightFigure);
            pbxLW2.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLW2.Size = new Size(widthFigure, heightFigure);

            pbxPB1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPB1.Size = new Size(widthFigure, heightFigure);
            pbxPB2.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPB2.Size = new Size(widthFigure, heightFigure);
            pbxPB3.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPB3.Size = new Size(widthFigure, heightFigure);
            pbxPB4.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPB4.Size = new Size(widthFigure, heightFigure);
            pbxPB5.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPB5.Size = new Size(widthFigure, heightFigure);
            pbxPB6.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPB6.Size = new Size(widthFigure, heightFigure);
            pbxPB7.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPB7.Size = new Size(widthFigure, heightFigure);
            pbxPB8.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPB8.Size = new Size(widthFigure, heightFigure);
            pbxLB1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLB1.Size = new Size(widthFigure, heightFigure);
            pbxKnB1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxKnB1.Size = new Size(widthFigure, heightFigure);
            pbxSB1.SizeMode = PictureBoxSizeMode.Zoom;
            pbxSB1.Size = new Size(widthFigure, heightFigure);
            pbxFB.SizeMode = PictureBoxSizeMode.Zoom;
            pbxFB.Size = new Size(widthFigure, heightFigure);
            pbxKB.SizeMode = PictureBoxSizeMode.Zoom;
            pbxKB.Size = new Size(widthFigure, heightFigure);
            pbxSB2.SizeMode = PictureBoxSizeMode.Zoom;
            pbxSB2.Size = new Size(widthFigure, heightFigure);
            pbxKnB2.SizeMode = PictureBoxSizeMode.Zoom;
            pbxKnB2.Size = new Size(widthFigure, heightFigure);
            pbxLB2.SizeMode = PictureBoxSizeMode.Zoom;
            pbxLB2.Size = new Size(widthFigure, heightFigure);


            pbxPW1.Location = new Point(startFigureX + 0 * offsetX, startFigureY + 6 * offsetY);
            pbxPW2.Location = new Point(startFigureX + 1 * offsetX, startFigureY + 6 * offsetY);
            pbxPW3.Location = new Point(startFigureX + 2 * offsetX, startFigureY + 6 * offsetY);
            pbxPW4.Location = new Point(startFigureX + 3 * offsetX, startFigureY + 6 * offsetY);
            pbxPW5.Location = new Point(startFigureX + 4 * offsetX, startFigureY + 6 * offsetY);
            pbxPW6.Location = new Point(startFigureX + 5 * offsetX, startFigureY + 6 * offsetY);
            pbxPW7.Location = new Point(startFigureX + 6 * offsetX, startFigureY + 6 * offsetY);
            pbxPW8.Location = new Point(startFigureX + 7 * offsetX, startFigureY + 6 * offsetY);
            pbxLW1.Location = new Point(startFigureX + 0 * offsetX, startFigureY + 7 * offsetY);
            pbxKnW1.Location = new Point(startFigureX + 1 * offsetX, startFigureY + 7 * offsetY);
            pbxSW1.Location = new Point(startFigureX + 2 * offsetX, startFigureY + 7 * offsetY);
            pbxFW.Location = new Point(startFigureX + 3 * offsetX, startFigureY + 7 * offsetY);
            pbxKW.Location = new Point(startFigureX + 4 * offsetX, startFigureY + 7 * offsetY);
            pbxSW2.Location = new Point(startFigureX + 5 * offsetX, startFigureY + 7 * offsetY);
            pbxKnW2.Location = new Point(startFigureX + 6 * offsetX, startFigureY + 7 * offsetY);
            pbxLW2.Location = new Point(startFigureX + 7 * offsetX, startFigureY + 7 * offsetY);

            pbxPB1.Location = new Point(startFigureX + 0 * offsetX, startFigureY + 1 * offsetY);
            pbxPB2.Location = new Point(startFigureX + 1 * offsetX, startFigureY + 1 * offsetY);
            pbxPB3.Location = new Point(startFigureX + 2 * offsetX, startFigureY + 1 * offsetY);
            pbxPB4.Location = new Point(startFigureX + 3 * offsetX, startFigureY + 1 * offsetY);
            pbxPB5.Location = new Point(startFigureX + 4 * offsetX, startFigureY + 1 * offsetY);
            pbxPB6.Location = new Point(startFigureX + 5 * offsetX, startFigureY + 1 * offsetY);
            pbxPB7.Location = new Point(startFigureX + 6 * offsetX, startFigureY + 1 * offsetY);
            pbxPB8.Location = new Point(startFigureX + 7 * offsetX, startFigureY + 1 * offsetY);
            pbxLB1.Location = new Point(startFigureX + 0 * offsetX, startFigureY + 0 * offsetY);
            pbxKnB1.Location = new Point(startFigureX + 1 * offsetX, startFigureY + 0 * offsetY);
            pbxSB1.Location = new Point(startFigureX + 2 * offsetX, startFigureY + 0 * offsetY);
            pbxFB.Location = new Point(startFigureX + 3 * offsetX, startFigureY + 0 * offsetY);
            pbxKB.Location = new Point(startFigureX + 4 * offsetX, startFigureY + 0 * offsetY);
            pbxSB2.Location = new Point(startFigureX + 5 * offsetX, startFigureY + 0 * offsetY);
            pbxKnB2.Location = new Point(startFigureX + 6 * offsetX, startFigureY + 0 * offsetY);
            pbxLB2.Location = new Point(startFigureX + 7 * offsetX, startFigureY + 0 * offsetY);
        }        
    }
}
