using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace PasswordChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void check_Click(object sender, EventArgs e)
        {
            Process Tibia = Process.GetProcessesByName("Tibia")[0];
            UInt32 Base = (UInt32)Tibia.MainModule.BaseAddress.ToInt32();
            IntPtr Handle = Tibia.Handle;
            Checker Checker = new Checker();
            login.Text = Checker.findLogin(Base, Handle);
            password.Text = Checker.findPassword(Base, Handle);

        }
    }
}
