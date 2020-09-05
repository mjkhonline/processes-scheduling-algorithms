using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processes_scheduling_algorithms
{
    class sjf : algorithm
    {
        public sjf(int max_process_to_create)
         : base(max_process_to_create)
        {

        }

        protected override process select_next_process()
        {
            if (queue.Count != 0)
                return find_shortest_process(queue);
            return null;
        }

        public override void run()
        {
            running_process = select_next_process();
            if (running_process != null)
            {
                running_process.perform();
                if (running_process.status == "done")
                    queue.Remove(running_process);
            }
            base.run();
        }

        private process find_shortest_process(List<process> q)
        {
            process output = q.First();
            foreach (process p in q)
            {
                if (p.burst_time < output.burst_time)
                    output = p;
            }
            return output;
        }
    }
}
