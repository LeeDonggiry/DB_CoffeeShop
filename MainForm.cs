using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_CoffeeShop
{
    public partial class MainForm : Form
    {
        private static MainForm instance = new MainForm();

        public string DTP;
        public string americano = "americano";
        public string cafelatte = "cafelatte";
        public string cafemocha = "cafemocha";

        public static MainForm getinstance()
        {
            return instance;
        }
        
        public MainForm()
        {
            instance = this;
            InitializeComponent();
            DTPinitial();
        }

        private void DTPinitial()
        {
            DTP = DTPcasher.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(DTP);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBManager.getinstance().Login(this.textBoxID.Text, this.textBoxPassword.Text);
            userinfo.getinstance().valid_using_user(this.textBoxID.Text, this.textBoxPassword.Text);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DBManager.getinstance().Logout();
        }

        private void DTPcasher_ValueChanged_1(object sender, EventArgs e)
        {
            DTP = DTPcasher.Value.ToString("yyyy-MM-dd");
            Console.WriteLine(DTP);
        }
        private void buttoncoffee_americano_Click(object sender, EventArgs e)
        {
            coffee.getinstance().clicked_coffee(americano);
            coffee.getinstance().everyday_calculate(americano);
        }

        private void buttoncoffee_cafelatte_Click(object sender, EventArgs e)
        {
            coffee.getinstance().clicked_coffee(cafelatte);
            coffee.getinstance().everyday_calculate(cafelatte);
        }

        private void buttoncoffee_cafemocha_Click(object sender, EventArgs e)
        {
            coffee.getinstance().clicked_coffee(cafemocha);
            coffee.getinstance().everyday_calculate(cafemocha);
        }
    }
}
