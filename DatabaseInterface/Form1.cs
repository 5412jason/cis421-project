using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.itemTableAdapter.Update(playItAgainSportsDataSet.Item);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'playItAgainSportsDataSet.Rewards' table. You can move, or remove it, as needed.
            this.rewardsTableAdapter.Fill(this.playItAgainSportsDataSet.Rewards);
            // TODO: This line of code loads data into the 'playItAgainSportsDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.playItAgainSportsDataSet.Transactions);
            // TODO: This line of code loads data into the 'playItAgainSportsDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.playItAgainSportsDataSet.Person);
            // TODO: This line of code loads data into the 'playItAgainSportsDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.playItAgainSportsDataSet.Employee);
            // TODO: This line of code loads data into the 'playItAgainSportsDataSet.Item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.playItAgainSportsDataSet.Item);

        }

        private void updateEmployees_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Update(playItAgainSportsDataSet.Employee);
        }

        private void updatePerson_Click(object sender, EventArgs e)
        {
            this.personTableAdapter.Update(playItAgainSportsDataSet.Person);
        }

        private void updateTransaction_Click(object sender, EventArgs e)
        {
            this.transactionsTableAdapter.Update(playItAgainSportsDataSet.Transactions);
        }

        private void updateRewards_Click(object sender, EventArgs e)
        {
            this.rewardsTableAdapter.Update(playItAgainSportsDataSet.Rewards);
        }
    }
}
