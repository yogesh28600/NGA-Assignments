using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Sequence_Algo
{
    public class Job
    {
        public string Id;
        public int profit;
        public int deadline;

        public Job(string Id,int profit,int deadline)
        {
            this.Id = Id;
            this.deadline = deadline;
            this.profit = profit;
        }
    }
}
