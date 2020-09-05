using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processes_scheduling_algorithms
{
    abstract class algorithm
    {
        //variables:
        public int spent_time;
        private int max_process;
        protected int number_of_created_processes;
        protected process running_process;
        protected List<process> queue;
        public List<process> recently_added_process;
        Random rnd = new Random();
        private int alpha;
        private int beta;
        //constructor
        private algorithm()
        {
            queue = new List<process>();
            recently_added_process = new List<process>();
            spent_time = 0;
            number_of_created_processes = 0;
            running_process = null;
        }
        public algorithm(int max_process_to_create)
            : this()
        {
            max_process = max_process_to_create;
            for (int i = 0; i < (max_process / 5); i++)
                add_process();
            alpha = (int)(Math.Pow(Math.Log(max_process), 1.52));
            beta = -alpha;
        }
        //getters and setters
        public process get_current_process()
        {
            return running_process;
        }
        public int get_progress()
        {
            return (int)((number_of_created_processes / (double)(max_process - 1) * 100) % 101);
        }
        //functions:
        protected abstract process select_next_process();

        protected void add_process()
        {
            process p = new process(spent_time,rnd.Next(1,15),rnd.Next(0, 139));
            queue.Add(p);
            recently_added_process.Add(p);
            number_of_created_processes++;
        }

        public virtual void run()
        {
            recently_added_process.Clear();
            create_processes_occasionally();
            spent_time++;
        }

        private void create_processes_occasionally()
        {
            if (number_of_created_processes < max_process)
            {
                int gamma = Math.Min(alpha, max_process - number_of_created_processes);
                int n = rnd.Next(beta, gamma);
                for (int i = 0; i < n; i++)
                    add_process();
            }
        }
    }
}
