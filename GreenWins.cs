﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATESTAT {
    public partial class GreenWins : Form {
        public GreenWins() {
            this.ControlBox = false;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            Game.click = 0;
            SelectPlayer1.ok = false;
            SelectPlayer2.ok2 = false;
            SelectPlayer1.playerList.Clear();
            this.Owner.Owner.Owner.Owner.Show();
            this.Owner.Close();
            this.Close();
        }
    }
}
