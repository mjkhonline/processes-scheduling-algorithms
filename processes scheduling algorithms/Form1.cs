using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace processes_scheduling_algorithms
{
    public partial class Form1 : Form
    {
        algorithm running_algorithm;

        public Form1()
        {
            InitializeComponent();

        }

        private void log(string str)
        {
            txt_log.Text += "\r\n" + str;
            txt_log.SelectionStart = txt_log.Text.Length;
            txt_log.ScrollToCaret();
        }

        private void set_progress_bar(int value)
        {
            progress_bar.Value = (int)((value % 101) / 100.0);
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            general_timer.Interval = (3) * 1000;
            lbl_timer_speed.Text = "1/3x";
            log("******** timer interval set to: " + lbl_timer_speed.Text);
        }

        private void xToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            general_timer.Interval = (1) * 1000;
            lbl_timer_speed.Text = "1x";
            log("******** timer interval set to: " + lbl_timer_speed.Text);
        }

        private void xToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            general_timer.Interval = (int)((1 / 2.0) * 1000);
            lbl_timer_speed.Text = "2x";
            log("******** timer interval set to: " + lbl_timer_speed.Text);
        }

        private void xToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            general_timer.Interval = (int)((1 / 5.0) * 1000);
            lbl_timer_speed.Text = "5x";
            log("******** timer interval set to: " + lbl_timer_speed.Text);
        }

        private void xToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            general_timer.Interval = (5) * 1000;
            lbl_timer_speed.Text = "1/5x";
            log("******** timer interval set to: " + lbl_timer_speed.Text);

        }

        private void xToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            general_timer.Interval = (int)((1 / 10.0) * 1000);
            lbl_timer_speed.Text = "10x";
            log("******** timer interval set to: " + lbl_timer_speed.Text);
        }

        private void xToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            general_timer.Interval = (int)((1 / 100.0) * 1000);
            lbl_timer_speed.Text = "100x";
            log("******** timer interval set to: " + lbl_timer_speed.Text);
        }

        private void xToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            general_timer.Interval = (int)((1 / 1000.0) * 1000);
            lbl_timer_speed.Text = "1000x";
            log("******** timer interval set to: " + lbl_timer_speed.Text);
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            if (rb_fcfs.Checked)
            {
                running_algorithm = new fcfs((int)(txt_n_map.Value) + 1);
                log("------ first come first served algorithm started at " + DateTime.Now.ToString("h:mm:ss tt") + " with " + txt_n_map.Value + " process:");
                log("[overal time]\t[process]\t\t[status]\t\t[remaining time]");
            }
            else if (rb_sjf.Checked)
            {
                running_algorithm = new sjf((int)(txt_n_map.Value) + 1);
                log("------ short job first algorithm started at " + DateTime.Now.ToString("h:mm:ss tt") + " with " + txt_n_map.Value + " process:");
                log("[overal time]\t[process]\t\t[status]\t\t[remaining time]");
            }
            else if (rb_priority.Checked)
            {
                running_algorithm = new priority((int)(txt_n_map.Value) + 1);
                log("------ priority algorithm started at " + DateTime.Now.ToString("h:mm:ss tt") + " with " + txt_n_map.Value + " process:");
                log("[overal time]\t[process]\t\t[status]\t\t[remaining time]\t\t[priority]");
            }
            else if (rb_rr.Checked)
            {
                running_algorithm = new rr((int)(txt_n_map.Value) + 1);
                log("------ round robin algorithm started at " + DateTime.Now.ToString("h:mm:ss tt") + " with " + txt_n_map.Value + " process:");
                log("[overal time]\t[process]\t\t[status]\t\t[remaining time]");
            }
            btn_run.Enabled = false;
            progress_bar.Style = ProgressBarStyle.Continuous;
            general_timer.Enabled = true;
            btn_determine.Enabled = true;

        }

        private void general_timer_Tick(object sender, EventArgs e)
        {
            print_processes_state(running_algorithm.recently_added_process);
            running_algorithm.run();
            process p = running_algorithm.get_current_process();
            if (p == null)
            {
                stop_timer();
            }
            else {
                print_process_state(p);
                progress_bar.Value = running_algorithm.get_progress();
            }

        }

        private void stop_timer()
        {
            general_timer.Enabled = false;
            btn_run.Enabled = true;
            btn_determine.Enabled = false;
            log("all requested processes performed.................. [" + DateTime.Now.ToString("h:mm:ss tt") + "]\r\n");
            progress_bar.Style = ProgressBarStyle.Marquee;
            running_algorithm = null;
        }

        private void print_process_state(process p)
        {
            string message = running_algorithm.spent_time.ToString() + "\t\t";
            message += p.name + "\t";
            message += p.status + "\t\t";
            message += "remaining time: " + p.burst_time + "\t\t";
            message += p.priority;
            log(message);
        }
        private void print_processes_state(List<process> processes)
        {
            foreach (process p in processes)
            {
                string message = running_algorithm.spent_time.ToString() + "\t\t";
                message += p.name + "\t";
                message += p.status + "\t\t";
                message += "burst time: " + p.burst_time + "\t\t";
                message += p.priority;
                log(message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            log("Developed by Mohammad Javad Khademian as Operating Systems Project in jan 2016.");
            txt_n_map.Focus();
        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is project of operating system course in Shiraz univeristy of technoloy.\nDeveloped by Mohammad Javad Khademian.\nShiraz-Iran\n\rwork mail: mjkhonline@live.com", "about");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (btn_run.Enabled)
                btn_run_Click(sender, e);
            else
                log("running in progress!!");
        }

        private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt_log.Text = "";
        }

        private void btn_determine_Click(object sender, EventArgs e)
        {
            stop_timer();
        }

    }
}
