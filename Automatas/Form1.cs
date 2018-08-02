using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatas
{
    public partial class Main : Form
    {
        Automatas ams;
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arregloF = null;
            char[] arregloSigma = Parser.StrToCharArray(txtSigma.Text);
            int numberQ;
            int numbers;
            try
            {
                arregloF = Parser.StrToIntArray(txtF.Text);
            } catch (FormatException ex)
            {
                MessageBox.Show("F must not contain other than digits");
                return;
            }
            try
            {
                numberQ = int.Parse(txtQ.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Q must be a number");
                return;
            }
            try
            {
                numbers = int.Parse(txts.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("s must be a number");
                return;
            }
            Automata automaton = new Automata(
                (txtName.Text == "") ? "nameless" : txtName.Text, numberQ, arregloSigma, numbers, arregloF
                );
            automaton.print();
            if (automaton.save())
                Console.WriteLine(automaton.Name + " saved correctly!");
        }

        private void txtDelta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Console.WriteLine("enter pressed");
            }
        }

        void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabPage current = (sender as TabControl).SelectedTab;
            cboAutomata.Items.Clear();

            ams.loadList();
            ams.lista.First<Automata>().print();
            foreach (Automata a in ams.lista)
            {
                cboAutomata.Items.Add(a.Name);
            }
            Console.WriteLine("cargado supuestamente");
            ams.lista.First<Automata>().print();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);
            ams = new Automatas();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ams.loadList();
            Console.WriteLine("------------------");
            foreach(Automata a in ams.lista)
            {
                if (a.Name == cboAutomata.Text)
                {
                    a.print();
                    return;
                }
            }
        }
    }
}
