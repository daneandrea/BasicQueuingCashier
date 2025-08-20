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


namespace BasicQueuingCashier
{
    public partial class CashierWindowQueue : Form
    {
        Timer timer = new Timer();
        private object obj;

        public CashierWindowQueue()
        {
            InitializeComponent();
            RefreshAutomatically();
        }

       

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);

        }

        private void DisplayCashierQueue(object cashierQueue)
        {
            throw new NotImplementedException();
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            RemoveNumberQueue(CashierClass.CashierQueue);
        }
        private void RemoveNumberQueue(Queue<string> cashierqueue)
        {
            if (cashierqueue.Count > 0) cashierqueue.Dequeue();
        }
        private void RefreshAutomatically()
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(btnRefresh_Click);
            timer.Start();
        }
    }
}
