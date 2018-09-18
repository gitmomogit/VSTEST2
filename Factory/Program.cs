using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutoCarMake parents = new Factory().CreateAutoCar("red");

            //IAutoCarMake parents = new Factory().CreateAutoCar("blue");

            //parents.CreateAutoCar();

            Console.WriteLine($"{DateTime.Now.ToString("yyyyMMdd")}校园日领券");

            Console.ReadKey();

        }
    }

    /// <summary>
    /// 简单工厂模式
    /// </summary>
    public interface IAutoCarMake
    {
        /// <summary>
        /// 创建汽车
        /// </summary>
        void CreateAutoCar();
    }
    /// <summary>
    /// 红色小轿车
    /// </summary>
    public class _RedCar : IAutoCarMake
    {
        public void CreateAutoCar()
        {
            Console.WriteLine("生成红色小轿车");
        }
    }
    /// <summary>
    /// 蓝色小轿车
    /// </summary>
    public class _BlueCar : IAutoCarMake
    {
        public void CreateAutoCar()
        {
            Console.WriteLine("生成蓝色小轿车");
        }
    }

    /// <summary>
    /// 简单工厂模式-工厂类
    /// </summary>
    public class Factory
    {
        public IAutoCarMake CreateAutoCar(string flag)
        {
            switch (flag)
            {
                case "red":
                    return new _RedCar();
                case "blue":
                    return new _BlueCar();
            }
            return null;
        }
    }
}
