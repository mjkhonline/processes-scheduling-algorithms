using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace processes_scheduling_algorithms
{
    class rr : algorithm
    {
        public rr(int max_process_to_create)
         : base(max_process_to_create)
        {

        }

        protected override process select_next_process()
        {
            if (queue.Count != 0)
                return queue.First();
            return null;
        }

        public override void run()
        {
            base.run();
            running_process = select_next_process();
            if (running_process != null)
            {
                running_process.perform();
                queue.Remove(running_process);
                if (running_process.status != "done")
                    queue.Add(running_process);
            }
        }
    }
}
