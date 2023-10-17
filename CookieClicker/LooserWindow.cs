using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookieClicker
{
    public partial class LooserWindow : Form
    {
        public LooserWindow()
        {
            InitializeComponent();
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\Malwina\source\repos\CookieClicker\5449.wav";
            player.Load();
            player.Play();
        }
    }
}
