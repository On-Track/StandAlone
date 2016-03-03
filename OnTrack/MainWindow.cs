using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using OnTrack.src.Monitor;
using System.Diagnostics;

namespace OnTrack
{
    public partial class MainWindow : MetroForm
    {

        public MainWindow()
        {
            InitializeComponent();
            new Monitor();
            this.FormClosing += this.MainWindow_Close;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //@todo load all study material from server
        }

        private void MainWindow_Close(object sender, EventArgs e)
        {
            //@todo try save any unsaved progress
            Environment.Exit(1);
        }
    }
}
