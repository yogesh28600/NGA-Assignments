using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knakspak_Algorithm
{
    public class Knakspak
    {
        public int  max_profit;
        public int max_weight;

        public Knakspak(int totalWeight)
        {
            this.max_profit = 0;
            this.max_weight = totalWeight;
        }
        private void sort(List<(Objects,int)> objects)
        {
            for(int i = 0; i < objects.Count; i++)
            {
                for(int j = i+1; j < objects.Count; j++)
                {
                    if (objects[i].Item2 < objects[j].Item2 || objects[i].Item2 == objects[j].Item2 && objects[i].Item1.profit < objects[j].Item1.profit)
                    {
                        var temp = objects[i];
                        objects[i] = objects[j];
                        objects[j] = temp;
                    }
                }
            }
        }
        public void knakspak_algo(Objects[] objects)
        {
            List<(Objects,int)> objs = new List<(Objects, int)> ();
            foreach (Objects obj in objects)
            {
                objs.Add((obj,obj.profit/obj.weight));
            }
            sort(objs);
            List<Objects> result = new List<Objects> ();
            for (int i = 0; i < objs.Count; i++)
            {
                if(this.max_weight > 0)
                {
                    if (objs[i].Item1.weight <= this.max_weight)
                    {
                        result.Add(objs[i].Item1 );
                        this.max_weight -= objs[i].Item1.weight;
                        this.max_profit += objs[i].Item1.profit;
                    }
                    else
                    {
                        int newProfit = (objs[i].Item1.profit / objs[i].Item1.weight) * this.max_weight;
                        this.max_profit += newProfit;
                        result.Add(objs[i].Item1);
                        this.max_weight = 0;
                        break;
                    }
                }
            }

            //Display output
            foreach (Objects obj in result)
            {
                Console.Write($"{obj.id}----->");
            }
            Console.WriteLine();
            Console.WriteLine($"Remaining weight: {this.max_weight}");
            Console.WriteLine($"Maximum profit: {this.max_profit}");
        }

        public void knakspak_algo_with_weight(Objects[] objects)
        {
            List<(Objects, int)> objs = new List<(Objects, int)>();
            foreach (Objects obj in objects)
            {
                objs.Add((obj, obj.weight));
            }
            objs.Sort((x, y) => x.Item2.CompareTo(y.Item2));
            
            List<Objects> result = new List<Objects>();
            for (int i = 0; i < objs.Count; i++)
            {
                if (this.max_weight > 0)
                {
                    if (objs[i].Item1.weight <= this.max_weight)
                    {
                        result.Add(objs[i].Item1);
                        this.max_weight -= objs[i].Item1.weight;
                        this.max_profit += objs[i].Item1.profit;
                    }
                    else
                    {
                        int newProfit = (objs[i].Item1.profit / objs[i].Item1.weight) * this.max_weight;
                        this.max_profit += newProfit;
                        result.Add(objs[i].Item1);
                        this.max_weight = 0;
                        break;
                    }
                }
            }

            //Display output
            foreach (Objects obj in result)
            {
                Console.Write($"{obj.id}----->");
            }
            Console.WriteLine();
            Console.WriteLine($"Remaining weight: {this.max_weight}");
            Console.WriteLine($"Maximum profit: {this.max_profit}");
        }

        public void knakspak_algo_with_profit(Objects[] objects)
        {
            List<(Objects, int)> objs = new List<(Objects, int)>();
            foreach (Objects obj in objects)
            {
                objs.Add((obj, obj.profit));
            }
            objs.Sort((x, y) => y.Item2.CompareTo(x.Item2));

            List<Objects> result = new List<Objects>();
            for (int i = 0; i < objs.Count; i++)
            {
                if (this.max_weight > 0)
                {
                    if (objs[i].Item1.weight <= this.max_weight)
                    {
                        result.Add(objs[i].Item1);
                        this.max_weight -= objs[i].Item1.weight;
                        this.max_profit += objs[i].Item1.profit;
                    }
                    else
                    {
                        int newProfit = (objs[i].Item1.profit / objs[i].Item1.weight) * this.max_weight;
                        this.max_profit += newProfit;
                        result.Add(objs[i].Item1);
                        this.max_weight = 0;
                        break;
                    }
                }
            }

            //Display output
            foreach (Objects obj in result)
            {
                Console.Write($"{obj.id}----->");
            }
            Console.WriteLine();
            Console.WriteLine($"Remaining weight: {this.max_weight}");
            Console.WriteLine($"Maximum profit: {this.max_profit}");
        }


    }
}
