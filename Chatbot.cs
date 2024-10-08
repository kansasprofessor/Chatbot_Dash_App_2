using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Forms;

namespace MIS566_group_project
{
    public partial class Chatbot : Form
    {
        public Form FormToShowOnClosing { get; set; }

        public Chatbot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            //if (null != FormToShowOnClosing)
            //    FormToShowOnClosing.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (userinput.Text.Contains("time off"))
            //{
            //    chatbottext.Clear();
            //    chatbottext.Text = "Would you like to go to your schedule?";
                   
            //    if (userinput.Text.Contains("yes"))
            //    {
            //        var sched = new monthschedule();
            //        sched.FormToShowOnClosing = this;
            //        sched.Show();
            //        this.Hide();
            //    }
            //}
        }

        private void userinput_KeyDown(object sender, KeyEventArgs e)
        {
            string input = userinput.Text.ToLower();

            if (input.Contains("time off") || input.Contains("drop shift")&& e.KeyCode == Keys.Enter)
            {
                chatbottext.Text = chatbottext.Text + "\n\n" + "User>   " + userinput.Text;
                chatbottext.Text = chatbottext.Text + "\n\n" + "Chatbot>   Would you like to go to your schedule?";
                userinput.Clear();
                //testing = 1;
            }
            else if ((input.Contains("pick up a shift") || userinput.Text.Contains("cover shift")) && e.KeyCode == Keys.Enter)
            {
                chatbottext.Text = chatbottext.Text + "\n\n" + "User>   " + userinput.Text;
                chatbottext.Text = chatbottext.Text + "\n\n" + "Chatbot>   Would you like to go the schedule to find shifts?";
                userinput.Clear();
                //testing = 2;
            }

            

            if (input.Contains("yes") && e.KeyCode == Keys.Enter && chatbottext.Text.Contains("Would you like to go to your schedule"))
            {
                chatbottext.Text = chatbottext.Text + "\n\n" + "User>   " + userinput.Text;
                userinput.Clear();
                var sched = new scheduleTakeOff();
                sched.FormToShowOnClosing = new DashBoard();
                sched.Show();
                this.Hide();
            }
            else if (input.Contains("no") && e.KeyCode == Keys.Enter && chatbottext.Text.Contains("Would you like to go to your schedule"))
            {
                chatbottext.Text = chatbottext.Text + "\n\n" + "User>   " + userinput.Text;
                chatbottext.Text = chatbottext.Text + "\n\n" + "Chatbot>   If there's nothing else I can help" +
                    " you with type in Exit. Or type something else";
                userinput.Clear();
            }
            else if (input.Contains("yes") && e.KeyCode == Keys.Enter && chatbottext.Text.Contains("Would you like to go the schedule to find shifts"))
            {
                chatbottext.Text = chatbottext.Text + "\n\n" + "User>   " + userinput.Text;
                userinput.Clear();
                var sched = new schedulePickUp();
                sched.FormToShowOnClosing = new DashBoard();
                sched.Show();
                this.Hide();
            }
            else if (input.Contains("no") && e.KeyCode == Keys.Enter && chatbottext.Text.Contains("Would you like to go the schedule to find shifts"))
            {
                chatbottext.Text = chatbottext.Text + "\n\n" + "User>   " + userinput.Text;
                chatbottext.Text = chatbottext.Text + "\n\n" + "Chatbot>   If there's nothing else I can help" +
                    " you with type in Exit. Or type something else";
                userinput.Clear();
            }

            if (input.Contains("exit") && e.KeyCode == Keys.Enter)
            {
                this.Close();
                if (null != FormToShowOnClosing)
                    FormToShowOnClosing.Show();
            }

            // explore Compiler Error CS0079 for possibly reading when textchanged

        }

        private void userinput_TextChanged(object sender, EventArgs e)
        {
            userinput.Update();
            if (userinput.Text.Contains("time off") && Console.ReadKey(true).Key == ConsoleKey.Enter) //e.KeyCode == Keys.Enter)
            {

            }
        }

        private void Chatbot_Load(object sender, EventArgs e)
        {
            //if (userinput.Text.Contains("time off") && Console.ReadKey(true).Key == ConsoleKey.Enter)
            //{
            //    chatbottext.Clear();
            //    chatbottext.Text = "Would you like to go to your schedule?";

            //    if (userinput.Text.Contains("yes"))
            //    {
            //        var sched = new monthschedule();
            //        sched.FormToShowOnClosing = this;
            //        sched.Show();
            //        this.Hide();
            //    }
            //}

        }

        private void userinput_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
