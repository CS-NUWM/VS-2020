using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void kunderenko_KN31_5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Це мій анегодот", "Вікно Кундеренка Д.І.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
        private void KN_11INT_3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ахахахахахахахахахахахахахахахахахахахахахахахахахахахахахахаха", "Вікно Нечипорук М.І.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);

        }

        private void Khmelnychyi_KN_31_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I run alot, from my problems...", "Вікно Хмельничого Т.В.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
        

       

        private void karpov_kn_31_Click(object sender, EventArgs e)
        {
            MessageBox.Show("колобок покотився", "Вікно Карпов", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void Zhakun_KN11int_1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Анекдот", "Вікно Жакун А.В.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void Zhylchuk_KN31_2_Click(object sender, EventArgs e)
        {
            string anecdot = "  Чи є у тебе мрія? \n- Є.\n- Яка ?\n-Хочу кинути пити.\n- Так кинь.\n- А як потім, жити без мрії?";
            MessageBox.Show(anecdot, "Жильчук", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
