using DecisionMaker.UserOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecisionMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Options model = new Options();
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string option = textBoxItem.Text;
            model.ItemList.Add(option);
            
            listView1.Items.Add(option);
            textBoxItem.Clear();
        }

        private void buttonDecisionList_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            var dList = model.ItemList;
            
            if (dList.Count > 0)
            {
                int index = rand.Next(0, dList.Count);
                MessageBox.Show(dList[index]);
            }
        }


    }
}
