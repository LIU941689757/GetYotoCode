using Microsoft.Win32;
using System;

class Program
{
    static int Main(string[] args)
    {
        if (args.Length < 2)
        {
            return 2; // 参数不足
        }

        string regPath = args[0];

        // 从第1个参数开始依次检查
        for (int i = 1; i < args.Length; i++)
        {
            string valueName = args[i];
            if (CheckRegistryValueExists(regPath, valueName))
            {
                return i; // 返回对应序号
            }
        }

        return 99; // 都没找到
    }

    /// <summary>
    /// 检查注册表路径下是否存在指定值名
    /// </summary>
    static bool CheckRegistryValueExists(string regPath, string valueName)
    {
        object val = Registry.GetValue(regPath, valueName, null);
        return val != null;
    }
}
