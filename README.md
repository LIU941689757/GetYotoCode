# GetYotoCode

一个用 **C# (.NET Framework, VS2017)** 写的小工具，用于在 Windows 注册表中检查指定的值名是否存在，并通过返回码告诉调用者。  
非常适合在 **批处理脚本 (.bat)** 中调用，通过 `%ERRORLEVEL%` 获取结果。

## 功能说明

- 第 **0 号参数**：注册表完整路径，例如  
  `HKEY_LOCAL_MACHINE\SOFTWARE\test`  
- 第 **1 号及后续参数**：要检查的值名列表  
- 程序会依次检查这些值名：
  - 如果第 1 号参数的值名存在 → 返回 **1**
  - 如果第 2 号参数的值名存在 → 返回 **2**
  - 以此类推
- 如果所有值名都没找到 → 返回 **99**
- 参数不足 → 返回 **2**

## 使用示例

### 命令行

```bat
GetYotoCode.exe "HKEY_LOCAL_MACHINE\SOFTWARE\test" "cipn" "copn"
echo %ERRORLEVEL%
