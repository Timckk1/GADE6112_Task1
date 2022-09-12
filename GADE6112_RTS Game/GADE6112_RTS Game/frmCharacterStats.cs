using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6112_RTS_Game
{
    public partial class frmCharacterStats : Form
    {
        public frmCharacterStats(Character character)
        {
            InitializeComponent();
            txtCharacterStats.Text = character.ToString();
        }
    }
}
