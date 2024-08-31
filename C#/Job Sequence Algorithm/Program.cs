namespace Job_Sequence_Algo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Job job1 = new Job("J1", 20, 2);
            Job job2 = new Job("J2", 25, 2);
            Job job3 = new Job("J3", 15, 1);
            Job job4 = new Job("J4", 40, 4);
            Job job5 = new Job("J5", 5, 3);
            Job job6 = new Job("J6", 10, 3);
            Job job7 = new Job("J7", 9, 4);

            Job[] jobs = {job1, job2, job3, job4, job5, job6,job7};

            JobSequence js= new JobSequence();
            js.job_sequence_algo(jobs);
        }
    }
}
