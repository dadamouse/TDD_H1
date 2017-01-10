using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumGroup
{
    public class SumGroup
    {


        private static void Main(string[] args)
        {
            //var rawData = new List<T>
            //{
            //    new Data<T> { Id=1, Cost=1, Revenue=11, SellPrice=21},
            //    new Data<T> { Id=2, Cost=2, Revenue=12, SellPrice=22},
            //};

            //var type = rawData.GetType();
            //var propertyInfos = type.GetProperties();


            //foreach (var raw in rawData) {
            //    var detail = raw.GetType().GetProperties().FirstOrDefault(x => x.Name == "Cost").GetValue(raw);
            //}
            //string command = Console.ReadLine();
            // Console.Write("Enter Command: ");
        }

        
        public List<int> getGroupSum<T>(List<T> rawData, string field, int group)
        {
            if (rawData == null)
            {
                throw new ArgumentException("rawData cannot be null");
            }

            if (field == null)
            {
                throw new ArgumentException("field cannot be null");
            }

            if (group < 1)
            {
                throw new ArgumentException("group is not correct");
            }

            var sumList = new List<int>();
            int sum = 0;
            // start by 1
            int i = 1;

            //check for has next run
            bool flag = false;
            foreach (var raw in rawData)
            {
                flag = false;

                try
                {
                    sum += (int)raw.GetType().GetProperties().FirstOrDefault(x => x.Name == field).GetValue(raw);
                }
                catch (NullReferenceException e)
                {
                    //null exception
                    throw new Exception(e.ToString());
                }

                //insert to list
                if (i % group == 0)
                {
                    sumList.Add(sum);
                    Console.WriteLine("{0}", sum);
                    sum = 0;
                    flag = true;
                }
                i++;
            }

            //check last run is happened
            if (!flag) sumList.Add(sum);

            //var sumList = new List<int> { 6, 15, 24, 21 };
            return sumList;
        }
    }

    //Any type of list
    public class Data
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}
