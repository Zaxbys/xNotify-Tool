using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JRPC_Client;
using XDevkit;
using DiscordRpcDemo;

namespace Lucid
{
    public partial class Lucid : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;

        IXboxConsole jtag;
        public Lucid()
        {
            InitializeComponent();
            MessageBox.Show("Welcome To Tool Name XNotify Tool! :D", "Tool Name", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (jtag.Connect(out jtag))
            {
                MessageBox.Show("XNotify Tool - Connected!", "Tool Name", MessageBoxButtons.OK, MessageBoxIcon.None);
                jtag.XNotify("Welcome To Tool Name, Made With Love By Github.com/Zaxbys <3");
                label2.Text = "Connected";
            } 
            else
            {
                MessageBox.Show("Couldn't connect!");
                label2.Text = "Failed! Try again!"; 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jtag.XNotify(textBox1.Text);
        }

        private void Lucid_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("APP ID HERE", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("APP ID HERE", ref this.handlers, true, null);
            this.presence.details = "DETAILS HERE";
            this.presence.state = "State Here";
            this.presence.largeImageKey = "imageKey";
            this.presence.largeImageText = "large Image Key Text";
            DiscordRpc.UpdatePresence(ref this.presence);
        }
    }
}
