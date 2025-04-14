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
            root.TwinCAT_SystemInfoVarList._TaskInfo[0].CycleCount.Set(1);
            var taskTime = root.TwinCAT_SystemInfoVarList._TaskInfo[0].DcTaskTime.Get();
            // 打开对单变量的监控（PLC端发起中断）
            root.TwinCAT_SystemInfoVarList._TaskInfo[0].DcTaskTime.SelfNotify = true;
            root.TwinCAT_SystemInfoVarList._TaskInfo[0].DcTaskTime.Subscribe((value) =>
            {
                Console.WriteLine(root.TwinCAT_SystemInfoVarList._TaskInfo[0].DcTaskTime.Name + " Changed! Value is " + value);
            });
            Console.ReadLine();
            // 关闭对单变量的监控
            root.TwinCAT_SystemInfoVarList._TaskInfo[0].DcTaskTime.SelfNotify = false;
            Console.ReadLine();

            Console.WriteLine("Hello, World!");
        }
    }
}
