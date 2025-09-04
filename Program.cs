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
        string valueName = args[1];

        return CheckRegistryValueExists(regPath, valueName);
    }

    /// <summary>
    /// 检查注册表路径下是否存在指定值名
    /// </summary>
    /// <param name="regPath">完整注册表路径，如 HKEY_LOCAL_MACHINE\SOFTWARE\test</param>
    /// <param name="valueName">要检查的值名</param>
    /// <returns>0=存在，1=不存在</returns>
    static int CheckRegistryValueExists(string regPath, string valueName)
    {
        object val = Registry.GetValue(regPath, valueName, null);
        return val != null ? 0 : 1;
    }
}
