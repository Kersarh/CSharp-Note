Выполнение команд (cmd)

```c#
string cmd = "notepad.exe";
var proc = new ProcessStartInfo()
{
    UseShellExecute = true,
    WorkingDirectory = @"C:\Windows\System32",
    FileName = @"C:\Windows\System32\cmd.exe",
    Arguments = "/c " + cmd,
    WindowStyle = ProcessWindowStyle.Hidden
};
Process.Start(proc);
```

Запустить исполняемый файл
```c#
ProcessStartInfo startInfo = new()
{
    FileName = "myfile.exe",
    Arguments = "arg1 arg2 arg3",
};
Process proc = new()
{
    StartInfo = startInfo
};
proc.Start();
```