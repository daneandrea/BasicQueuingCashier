using System;
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
    public partial class CustomerView : Form
    {

        public CustomerView()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(Update);
            timer.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            Queue<string> queue = CashierClass.CashierQueue;
            lblQueuing.Text = queue.Count > 0 ? queue.Peek() : "";
        }

        private void CustomerView_Load(object sender, EventArgs e)
        {

        }
    }
}
