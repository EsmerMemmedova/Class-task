using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classandİDtask
{
    public class Car
    {
        public int Id;
        public string Name { get; set; }
        public int Speed { get; set; }

        public string CarCode { get; set; }
        public Car(int id,string name,int speed)
        {
            Id = id;
            CarCode = name.Substring(0, 2).ToUpper() + id.ToString();
            Name = name;
            Speed = speed;
   
        }
    }
}
