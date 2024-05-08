using System.Drawing;
using System.Windows.Forms;

namespace ChessEngine
{
    public partial class FrmMainForm : Form
    {
        /// <summary>
        ///  артинка доски
        /// </summary>
        Image imgDoska;

        /// <summary>
        /// ’ранение состо€ни€ пол€, движение фигур, оценка состо€ни€
        /// </summary>
        Engine engine = new();

        /// <summary>
        /// начальна€ координата фигуры на доске
        /// </summary>
        const int startFigureX = 33;

        /// <summary>
        /// начальна€ координата фигуры на доске
        /// </summary>
        const int startFigureY = 33;

        /// <summary>
        /// ширина фигуры на доске
        /// </summary>
        const int widthFigure = 90;

        /// <summary>
        /// высота фигуры на доске
        /// </summary>
        const int heightFigure = 90;

        /// <summary>
        /// рассто€ние между фигурами
        /// </summary>
        const int offsetX = 99;

        /// <summary>
        /// рассто€ние между фигурами
        /// </summary>
        const int offsetY = 99;        

        public FrmMainForm()
        {
            InitializeComponent();
            imgDoska = Properties.Resources.doska;
            drawingPole(engine.initialState);  

            //////////////////  “ест   ////////////////////////////
            label2.Text = engine.ValueWhite(engine.initialState).ToString();
            label3.Text = engine.ValueBlack(engine.initialState).ToString();
            /////////////////////////////////////////////////
        }

        /// <summary>
        /// ќтрисовка шахматной доски
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(imgDoska, 0, 0, 850, 850);           
        }

        /// <summary>
        /// служжебна€ кнопка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            /*Random rnd = new Random();
            Random rnd2 = new Random();
            pbxPW1.Location = new Point(startFigureX + rnd.Next(0, 7) * offsetX, startFigureY + rnd2.Next(0, 7) * offsetY);*/

            drawingPole("34567890STVWXZ12-----------B--------------------IKLMNPQRA-CDEFGH");
        }

        /// <summary>
        /// ќтрисовка фигур на доске (отрисовка сделанного хода)
        /// </summary>
        /// <param name="newState">новое состо€ние фигур</param>
        private void drawingPole(string newState)
        {
            /*
             * на вход новое состо€ние, сравниваем с текущим состо€ние и отрисовываем только ходы
             */

            /// координаты фигуры на доске дл€ отрисовки
            int x = 0;
            int y = 0;

            // ”станавливаем размеры фигур
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

            // отрисовываем ход
            for (int i = 0; i <= 63; i++)
            {
                if (newState[i] != engine.currentState[i])
                {
                    y = i / 8;
                    x = i - 8 * y;                    

                    switch (newState[i])
                    {
                        case 'I': pbxPW1.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'K': pbxPW2.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'L': pbxPW3.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'M': pbxPW4.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'N': pbxPW5.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'P': pbxPW6.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'Q': pbxPW7.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'R': pbxPW8.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'A': pbxLW1.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'H': pbxLW2.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'B': pbxKnW1.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'G': pbxKnW2.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'C': pbxSW1.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'F': pbxSW2.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'D': pbxFW.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'E': pbxKW.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;

                        case 'S': pbxPB1.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'T': pbxPB2.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'V': pbxPB3.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'W': pbxPB4.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'X': pbxPB5.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case 'Z': pbxPB6.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case '1': pbxPB7.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case '2': pbxPB8.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case '3': pbxLB1.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case '0': pbxLB2.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case '4': pbxKnB1.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case '9': pbxKnB2.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case '5': pbxSB1.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case '8': pbxSB2.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case '6': pbxFB.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                        case '7': pbxKB.Location = new Point(startFigureX + x * offsetX, startFigureY + y * offsetY); break;
                    }
                }                
            }
        } 
    }
}
