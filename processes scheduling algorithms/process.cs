using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processes_scheduling_algorithms
{
    class process
    {
        //variables
        private static int number_of_processes = 0;
        public string name;
        public int burst_time;
        public int arrival_time;
        public string status;
        public int priority;
        
        //constructor
        public process()
        {
            number_of_processes++;
            name = "process#" + number_of_processes.ToString();
            status = "ready";
            priority = 0;
        }

        public process(int arrival_time, int burst_time)
            : this()
        {
            this.arrival_time = arrival_time;
            this.burst_time = burst_time;
        }
        public process(int arrival_time, int burst_time, int priority)
            : this(arrival_time, burst_time)
        {
            this.priority = priority;
        }

        //setters and getters
        public static int get_number_of_processes()
        {
            return number_of_processes;
        }

        //functions
        public void perform()
        {
            status = "running";
            burst_time--;
            priority=(priority+1)%140;
            if (burst_time == 0)
                status = "done";
        }

    }
}
