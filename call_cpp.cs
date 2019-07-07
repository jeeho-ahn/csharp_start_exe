using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class call_cpp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.CreateNoWindow = false;
        startInfo.UseShellExecute = false;
        startInfo.FileName = "C:/csharp_start_trial.exe";
        startInfo.WindowStyle = ProcessWindowStyle.Hidden;
        startInfo.Arguments = "imhere";
        try
        {
            // Start the process with the info we specified.
            // Call WaitForExit and then the using statement will close.
            using (Process exeProcess = Process.Start(startInfo))
            {
                //exeProcess.WaitForExit();
            }
        }
        catch
        {
            // Log error.
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
