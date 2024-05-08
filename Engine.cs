using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    /* Кодировка фигур в строке состояния игрового поля
     * 
           3-LB1  4-KnB1  5-SB1 6-FB  7-KB  8-SB2  9-KnB2  0-LB2
           S-PB1  T-PB2  V-PB3  W-PB4  X-PB5  Z-PB6  1-PB7  2-PB8 

           I-PW1  K-PW2  L-PW3  M-PW4  N-PW5  P-PW6  Q-PW7  R-PW8 
           A-LW1  B-KnW1  C-SW1 D-FW  E-KW  F-SW2  G-KnW2  H-LW2  
      
        */
    /// <summary>
    /// Положение фигур, движение фигур, оценка поля.
    /// </summary>
    internal class Engine
    {
        /// <summary>
        /// Стоимость пешки
        /// </summary>
        const int costPeshka = 1;  
        
        /// <summary>
        /// Стоимость Коня
        /// больше определенного количество фигур на доске
        /// </summary>
        const int costKonMorePercent = 4;

        /// <summary>
        /// Стоимость Коня
        /// меньше определенного количество фигур на доске
        /// </summary>
        const int costKonLessPercent = 2;

        /// <summary>
        /// Стоимость Слона
        /// больше определенного количество фигур на доске
        /// </summary>
        const int costSlonMorePercent = 2;

        /// <summary>
        /// Стоимость Слона
        /// меньше определенного количество фигур на доске
        /// </summary>
        const int costSlonLessPercent = 4;

        /// <summary>
        /// Процент фигур на доске для подсчета оценки
        /// </summary>
        const int percent = 50;

        /// <summary>
        /// стоимость ладьи
        /// </summary>
        const int costLadya = 5;

        /// <summary>
        /// Стоимость Ферзя
        /// </summary>
        const int costFerz = 20;

        /// <summary>
        /// Стоимость Короля
        /// </summary>
        const int costKorol = 1000;
                
        /// <summary>
        /// Начальное положение
        /// </summary>
        public readonly string initialState = "34567890STVWXZ12--------------------------------IKLMNPQRABCDEFGH";

        /// <summary>
        /// Текущее положение фигур
        /// </summary>
        public string currentState = "----------------------------------------------------------------";

        /// <summary>
        /// Подсчет стоимости положения фигур для Белых
        /// </summary>
        /// <param name="state">положение фигур на доске</param>
        /// <returns>оценка (int)</returns>
        public int ValueWhite(string state)
        {
            int value = 0;
            foreach(char c in state)
            {
                if (c == '3' || c == '0') { value -= costLadya; }
                if ((64 - (state.Count(c => c == '-')) / 32) * 100 >= percent) {
                    if (c == '4' || c == '9') { value -= costKonMorePercent; }
                    if (c == '5' || c == '8') { value -= costSlonMorePercent; } }
                else {
                    if (c == '4' || c == '9') { value -= costKonLessPercent; }
                    if (c == '5' || c == '8') { value -= costSlonLessPercent; }
                }
                if (c == '6') { value -= costFerz; }
                if (c == '7') { value -= costKorol; }
                if (c == 'S' || c == 'T' || c == 'V' || c == 'W' || c == 'X' || c == 'Z' || c == '1' || c == '2') { value -= costPeshka; }

                if (c == 'A' || c == 'H') { value += costLadya; }
                if ((64 - (state.Count(c => c == '-')) / 32) * 100 >= percent)
                {
                    if (c == 'B' || c == 'G') { value += costKonMorePercent; }
                    if (c == 'C' || c == 'F') { value += costSlonMorePercent; }
                }
                else
                {
                    if (c == 'B' || c == 'G') { value += costKonLessPercent; }
                    if (c == 'C' || c == 'F') { value += costSlonLessPercent; }
                }
                if (c == 'D') { value += costFerz; }
                if (c == 'E') { value += costKorol; }
                if (c == 'I' || c == 'K' || c == 'L' || c == 'M' || c == 'N' || c == 'P' || c == 'Q' || c == 'R') { value += costPeshka; }
            }
            return value;
        }

        /// <summary>
        /// Подсчет стоимости положения фигур для Черных
        /// </summary>
        /// <param name="state">положение фигур на доске</param>
        /// <returns>оценка (int)</returns>
        public int ValueBlack(string state)
        {
            int value = 0;
            foreach (char c in state)
            {
                if (c == '3' || c == '0') { value += costLadya; }
                if ((64 - (state.Count(c => c == '-')) / 32) * 100 >= percent)
                {
                    if (c == '4' || c == '9') { value += costKonMorePercent; }
                    if (c == '5' || c == '8') { value += costSlonMorePercent; }
                }
                else
                {
                    if (c == '4' || c == '9') { value += costKonLessPercent; }
                    if (c == '5' || c == '8') { value += costSlonLessPercent; }
                }
                if (c == '6') { value += costFerz; }
                if (c == '7') { value += costKorol; }
                if (c == 'S' || c == 'T' || c == 'V' || c == 'W' || c == 'X' || c == 'Z' || c == '1' || c == '2') { value += costPeshka; }

                if (c == 'A' || c == 'H') { value -= costLadya; }
                if ((64 - (state.Count(c => c == '-')) / 32) * 100 >= percent)
                {
                    if (c == 'B' || c == 'G') { value -= costKonMorePercent; }
                    if (c == 'C' || c == 'F') { value -= costSlonMorePercent; }
                }
                else
                {
                    if (c == 'B' || c == 'G') { value -= costKonLessPercent; }
                    if (c == 'C' || c == 'F') { value -= costSlonLessPercent; }
                }
                if (c == 'D') { value -= costFerz; }
                if (c == 'E') { value -= costKorol; }
                if (c == 'I' || c == 'K' || c == 'L' || c == 'M' || c == 'N' || c == 'P' || c == 'Q' || c == 'R') { value -= costPeshka; }
            }
            return value;
        }
    }
   
}
