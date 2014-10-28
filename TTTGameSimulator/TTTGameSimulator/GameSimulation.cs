//GROUP : 6
//GROUP MEMBERS: William Wiltshire, Kirsti Tench, Zahidali Maknojia, Krishna Bhandari, Aleksander Mukhin
//ASSIGNMENT# 7
//Description: A Tic Tac Toe Game simulator
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TTTGameSimulator
{
    class GameSimulation : INotifyPropertyChanged
    {
        //This variable for main for
        public const int NUMBER_OF_POSITION = 9;
        public int[,] array = new int[3, 3];
        public Random r = new Random();
        public int currentPlayer = 1;

        #region Variables and properties for winners
        private int xWin;
        private int oWin;
        private int tie;

        public int XWin
        {
            get { return xWin; }
            set { xWin = value; NotifyPropertyChanged(); }
        }

        public int OWin
        {
            get { return oWin; }
            set { oWin = value; NotifyPropertyChanged(); }
        }

        public int Tie
        {
            get { return tie; }
            set { tie = value; NotifyPropertyChanged(); }
        }
        #endregion

        #region Notify

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Variables and properties for game board
        private string tl;
        private string tm;
        private string tr;

        public string TL
        {
            get
            {
                return tl;
            }
            set
            {
                tl = value;
                NotifyPropertyChanged();
            }
        }
        public string TM
        {
            get
            {
                return tm;
            }
            set
            {
                tm = value;
                NotifyPropertyChanged();
            }
        }
        public string TR
        {
            get
            {
                return tr;
            }
            set
            {
                tr = value;
                NotifyPropertyChanged();
            }
        }

        private string ml;
        private string mm;
        private string mr;

        public string ML
        {
            get
            {
                return ml;
            }
            set
            {
                ml = value;
                NotifyPropertyChanged();
            }
        }
        public string MM
        {
            get
            {
                return mm;
            }
            set
            {
                mm = value;
                NotifyPropertyChanged();
            }
        }
        public string MR
        {
            get
            {
                return mr;
            }
            set
            {
                mr = value;
                NotifyPropertyChanged();
            }
        }

        private string bl;
        private string bm;
        private string br;

        public string BL
        {
            get
            {
                return bl;
            }
            set
            {
                bl = value;
                NotifyPropertyChanged();
            }
        }
        public string BM
        {
            get
            {
                return bm;
            }
            set
            {
                bm = value;
                NotifyPropertyChanged();
            }
        }
        public string BR
        {
            get
            {
                return br;
            }
            set
            {
                br = value;
                NotifyPropertyChanged();
            }
        }
        #endregion

        public bool WinnerLogic()
        {
            //Vertical
            if (array[0, 0] == array[1, 0] && array[1, 0] == array[2, 0] && array[2,0]!=2)
            {
                return true;
            }
            if (array[0, 1] == array[1, 1] && array[1, 1] == array[2, 1] && array[2, 1] != 2)
            {
                return true;
            }
            if (array[0, 2] == array[1, 2] && array[1, 2] == array[2, 2] && array[2, 2] != 2)
            {
                return true;
            }

            //Horizontal
            if (array[0, 0] == array[0, 1] && array[0, 1] == array[0, 2] && array[0, 2] != 2)
            {
                return true;
            }
            if (array[1, 0] == array[1, 1] && array[1, 1] == array[1, 2] && array[1, 2] != 2)
            {
                return true;
            }
            if (array[2, 0] == array[2, 1] && array[2, 1] == array[2, 2] && array[2, 2] != 2)
            {
                return true;
            }

            //Diagonal
            if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2] && array[2, 2] != 2)
            {
                return true;
            }
            if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0] && array[2, 0] != 2)
            {
                return true;
            }
            return false;
        }

        public void ArrayFilling()
        {
            //position in array
            int x;
            int y;
            //to understand win or tie
            bool switcher = false;
            int numberOfPosition = 0;
            //fill an array 2
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = 2;
                }
            }

            //understand how many variant we have
            while (numberOfPosition < NUMBER_OF_POSITION)
            {
                //random position
                x = r.Next(0, 3);
                y = r.Next(0, 3);

                //put a value to the random position in array
                if (array[x, y] == 2)
                {
                    array[x, y] = currentPlayer;
                    if (WinnerLogic())
                    {
                        if (currentPlayer==1)
                        {
                            this.XWin = XWin + 1;
                        }
                        else
                        {
                            this.OWin = OWin + 1;
                        }
                        switcher = true;
                        numberOfPosition = 9;
                    }
                    //next player
                    if (currentPlayer == 1)
                    {
                        currentPlayer = 0;
                    }
                    else
                    {
                        currentPlayer = 1;
                    }
                    numberOfPosition = numberOfPosition + 1;
                }
            }

            #region ValuesToView
            if (array[0, 0] == 1)
            {
                this.TL = "X";
            }
            else if (array[0,0]==0)
            {
                this.TL = "O";
            }
            else
            {
                this.TL = "";
            }

            if (array[0, 1] == 1)
            {
                this.TM = "X";
            }
            else if (array[0, 1] == 0)
            {
                this.TM = "O";
            }
            else
            {
                this.TM = "";
            }

            if (array[0, 2] == 1)
            {
                this.TR = "X";
            }
            else if (array[0, 2] == 0)
            {
                this.TR = "O";
            }
            else
            {
                this.TR = "";
            }

            if (array[1, 0] == 1)
            {
                this.ML = "X";
            }
            else if (array[1, 0] == 0)
            {
                this.ML = "O";
            }
            else
            {
                this.ML = "";
            }

            if (array[1, 1] == 1)
            {
                this.MM = "X";
            }
            else if (array[1, 1] == 0)
            {
                this.MM = "O";
            }
            else
            {
                this.MM = "";
            }

            if (array[1, 2] == 1)
            {
                this.MR = "X";
            }
            else if (array[1, 2] == 0)
            {
                this.MR = "O";
            }
            else
            {
                this.MR = "";
            }

            if (array[2, 0] == 1)
            {
                this.BL = "X";
            }
            else if (array[2, 0] == 0)
            {
                this.BL = "O";
            }
            else
            {
                this.BL = "";
            }

            if (array[2, 1] == 1)
            {
                this.BM = "X";
            }
            else if (array[2, 1] == 0)
            {
                this.BM = "O";
            }
            else
            {
                this.BM = "";
            }

            if (array[2, 2] == 1)
            {
                this.BR = "X";
            }
            else if (array[2, 2] == 0)
            {
                this.BR = "O";
            }
            else
            {
                this.BR = "";
            }
            #endregion

            
            if (switcher)
            {
                //do anything
            }
            else
            {
                this.Tie = Tie + 1;
            }
        }

        public void ClearScore()
        {
            this.OWin = 0;
            this.XWin = 0;
            this.Tie = 0;

            this.TL = "";
            this.TM = "";
            this.TR = "";
            this.ML = "";
            this.MM = "";
            this.MR = "";
            this.BL = "";
            this.BM = "";
            this.BR = "";
        }

    }
}

