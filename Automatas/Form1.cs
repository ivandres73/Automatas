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
        }

        private void txtDelta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Console.WriteLine("enter pressed");
            }
        }
    }
}
