using System.Diagnostics;

namespace ImageRescaling.Common.CustomProcesses;

public static class CustomProcesses
{
    public static void OpenFolder(string command, string folderPath)
    {
        if (Directory.Exists(folderPath))
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = folderPath,
                FileName = command,
            };

            Process.Start(startInfo);
        }
        else
        {
            throw new Exception(string.Format("{0} Directory does not exist!", folderPath));
        }
    }
}