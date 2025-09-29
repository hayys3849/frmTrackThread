using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTrackThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread threadA = new Thread(MyThreadClass.Thread1);
            Thread threadB = new Thread(MyThreadClass.Thread2);
            Thread threadC = new Thread(MyThreadClass.Thread1);
            Thread threadD = new Thread(MyThreadClass.Thread2);

            threadA.Name = "ThreadA";
            threadB.Name = "ThreadB";
            threadC.Name = "ThreadC";
            threadD.Name = "ThreadD";

            threadA.Priority = ThreadPriority.Highest;

            threadB.Priority = ThreadPriority.Normal;

            threadC.Priority = ThreadPriority.AboveNormal;

            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();


            

            label1.Text = "End of Thread";

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }



