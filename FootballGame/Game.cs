﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Game
    {
        public Team T1 { get; set; }
        public Team T2 { get; set; }

        public int T1Score = 0;
        public int T2Score = 0;
        public Random random;

        public Game(Team T1, Team T2)
        {

            this.T1 = T1;
            this.T2 = T2;
            random = new Random();

        }
    }
 }
