using System;
using System.Collections.Generic;
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
    internal class Pole
    {
        public string initialState = "GHILKIHGMMMMMMMM--------------------------------FFFFFFFFABCEDCBA"; 
    }
   
}
