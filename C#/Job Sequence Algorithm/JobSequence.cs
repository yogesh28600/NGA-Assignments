using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job_Sequence_Algo
{
    public class JobSequence
    {
        int max_profit = 0;
        public void job_sequence_algo(Job[] jobs)
        {
            List<(Job,int)> jobSeq = new List<(Job,int)> ();
            int max_jobs = 0;
            foreach (Job job in jobs)
            {
                max_jobs = Math.Max(max_jobs, job.deadline);
                jobSeq.Add((job,job.profit));
            }
            jobSeq.Sort ((x,y) => y.Item2.CompareTo(x.Item2));
            Job[] result = new Job[max_jobs];

            foreach (var job in jobSeq)
            {
                if (result[job.Item1.deadline-1] == null)
                {
                    result[job.Item1.deadline - 1] = job.Item1;
                    max_profit += job.Item2;
                }
                else
                {
                    for(int i = job.Item1.deadline - 1; i >= 0; i--)
                    {
                        if (result[i] == null)
                        {
                            result[i] = job.Item1;
                            max_profit += job.Item2;
                        }
                    }
                }
            }

            //Display Output
            foreach (Job job in result)
            {
                Console.Write($"{job.Id}----->");
            }
            Console.WriteLine();
            Console.WriteLine($"Max profit: {max_profit}");
        }
    }
}
