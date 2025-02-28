using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_3
{
    class Button
    {
        public delegate void ClickHandler();
        public event ClickHandler OnClick;

        public void Click()
        {
            if (OnClick != null)
                OnClick.Invoke();
            else
                Console.WriteLine("No event handler assigned.");
        }
    }

    //class Program15
    //{
    //    static void ButtonClicked()
    //    {
    //        Console.WriteLine("Button was clicked!");
    //    }

    //    static void Main()
    //    {
    //        Button button = new Button();
    //        button.OnClick += ButtonClicked;

    //        Console.WriteLine("Press Enter to click the button...");
    //        Console.ReadLine();

    //        button.Click();
    //    }
    //}
}
