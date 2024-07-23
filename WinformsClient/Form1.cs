using System;
using System.Windows.Forms;

namespace WinformsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webView21.Source = new Uri("https://localhost:7060/");
        }
    }
}
