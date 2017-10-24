using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Delegates
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MethodInvoker x = CreateDelegateInstance();

            x();
            x();
        }

        static MethodInvoker CreateDelegateInstance()
        {
            int counter = 5;

            MethodInvoker ret = delegate
            {
                Console.WriteLine(counter);
                counter++;
            };

            ret();

            return ret;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Action x = CreateDelegateInstance2();

            x();
            x();
        }

        static Action CreateDelegateInstance2()
        {
            int counter = 50;

            Action ret = delegate
            {
                Console.WriteLine(counter);
                counter += 10;
            };

            ret();

            return ret;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UselessMethod x = CreateDelegateInstance3();

            x();
            x();
        }

        public delegate void UselessMethod();

        //

        static UselessMethod CreateDelegateInstance3()
        {
            int counter = 500;

            UselessMethod ret = delegate
            {
                Console.WriteLine(counter);
                counter += 100;
            };

            ret();

            return ret;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            Action<int> transform = delegate (int x)
            {
                Console.WriteLine(x);
            };

            list.ForEach(transform);

            MultiplyBy10 transform2 = Display10;
            transform = Display10;

            list.ForEach(transform);

            //list.ForEach(transform2);
        }

        private delegate void MultiplyBy10(int x);

        public void Display10(int x)
        {
            Console.WriteLine(x * 10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kid<Button> kid = new Kid<Button>("Jake", 8);
            kid.PrintKidInfo();
            Console.WriteLine(kid.strTypeParameterType);

            List<Kid<Delegate>> kids = new List<Kid<Delegate>>();
            kids.Add(new Kid<Delegate>("Jake", 8));
            kids.Add(new Kid<Delegate>("Ella", 6));
            kids.Add(new Kid<Delegate>("Janice", 48));

            foreach (Kid<Delegate> kidIter in kids)
            {
                kidIter.PrintAllInfo();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kid<Form> kiddy = new Kid<Form>();

            object instance = kiddy.CreateInstanceOfParameterType();

            Console.WriteLine($"Type of type parameter: {instance.GetType().ToString()}");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            KidClass<System.Drawing.Point> kiddo = new KidClass<System.Drawing.Point>();
            kiddo.Name = "Ella";
            kiddo.Age = 6;

            System.Drawing.Point instanceType = kiddo.CreateInstanceOfParameterType();

            kiddo.PrintAllInfo();
            Console.WriteLine($"Type of type parameter: {instanceType.GetType().ToString()}");


        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Planet<Dictionary<int, string>> planet = new Planet<Dictionary<int, string>>();
            Planet planet = new Planet();
            //Console.WriteLine(planet.ReturnTypeName());
            object x = planet.CreateInstance<Dictionary<int, string>>();
            Console.WriteLine(x.GetType().ToString());
        }
    }
}
