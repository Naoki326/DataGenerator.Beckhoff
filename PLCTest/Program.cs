using PLCManager.Demo;

namespace PLCTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo001 root = new Demo001();

            root.Connect("", 001);

            // 基本设置和读取
            root.GVL_Motion.FBU_BZ1M_StepMotor_Index.Set(1);
            var index = root.GVL_Motion.FBU_BZ1M_StepMotor_Index.Get();
            // 打开对单变量的监控（PLC端发起中断）
            root.GVL_Motion.FBU_BZ1M_StepMotor_Index.SelfNotify = true;
            root.GVL_Motion.FBU_BZ1M_StepMotor_Index.Subscribe((value) =>
            {
                Console.WriteLine(nameof(root.GVL_Motion.FBU_BZ1M_StepMotor_Index) + " Changed! Value is " + value);
            });
            Console.ReadLine();
            // 关闭对单变量的监控
            root.GVL_Motion.FBU_BZ1M_StepMotor_Index.SelfNotify = false;
            Console.ReadLine();


            Console.WriteLine("Hello, World!");
        }
    }
}
