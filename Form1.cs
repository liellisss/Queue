using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace очередь
{
    public partial class Form1 : Form
    {
        Queue<string> queue = new Queue<string>();
        static Double value = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void print_queue(Queue<string> temp_queue)
        {
            label1.Text = "";
            foreach (string element in queue)
            {
                label1.Text += element;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string result = Microsoft.VisualBasic.Interaction.InputBox("Введите элемент:");
            queue.Enqueue(result);
            print_queue(queue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            queue.Dequeue();
            print_queue(queue);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(queue.Peek(), "Первый элемент");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var que = queue.Count().ToString();
            MessageBox.Show(que, "Количество элементов в очереди");
        }
    }
}
