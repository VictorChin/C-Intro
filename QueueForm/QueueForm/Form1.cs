using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueueForm
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            _orders.Enqueue("Apple");
            _orders.Enqueue("Orange");
            _orders.Enqueue("Cherry");

            updateListBox();
        }

        private void updateListBox()
        {
            listOrders.Items.Clear();
            foreach (var item in _orders)
            {
                listOrders.Items.Add(item);
            }
        }

        

        private void handleAll(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (sender == btnJoinQueue)
                {
                    _orders.Enqueue(txtNewOrder.Text);
                }
                else if (sender == btnTakeOrder)
                {
                    string anOrder = _orders.Dequeue();
                    MessageBox.Show($"Process {anOrder}");
                }
                else
                {
                    MessageBox.Show($"Peeked next item: {_orders.Peek()}");
                }

                updateListBox();
             

            }


        }
        private Queue<string> _orders = new Queue<string>();
    }
}
