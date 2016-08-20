using System;
using System.Collections.Generic;
using System.Text;
using System.Boolean;
/*
* 块注释：shift+alt+A 
* https://code.visualstudio.com/docs/customization/keybindings
*/
namespace Test
{
    ///<summary>
    ///文档注释(///): 文档注释写在类、方法或属性（以后会学到）的前面.
    ///</summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  多行注释():这是一段提示信息
             */
            Console.WriteLine("积跬步，至千里");//单行注释(/): 打印并换行
            var xgqfrms = "https://msdn.microsoft.com/zh-cn/library/ms173104.aspx";
            //在程序中声明变量或常量时，必须指定其类型或者使用关键字 var 让编译器可以推断其类型。
            bool isOK = false; // 没问题
            Boolean isNotOK = true; // error CS0246: 找不到类型或命名空间名称“Boolean”(是否缺少 using 指令或程序集引用?)
            double salary = 6000.00;//基本工资
            double prize = 3200.00;//奖金
            double tax = 4500.00;//交税
            Console.WriteLine("我的工资奖金总额是{0}元",(salary+prize));
            Console.WriteLine("我的税后收入是{0}元",(salary+prize-tax));

            int x=1;
            bool a = ++x * x > 3;
            bool b = true;//请赋值
            Console.WriteLine(a==b);//true?
            
        }
    }
}