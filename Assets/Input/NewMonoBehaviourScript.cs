using UnityEngine;
using System.Diagnostics;

public class LaunchEXE : MonoBehaviour
{
    public string exePath = "D:/كتايب/منظومات دجو 360/buk_Windows.exe";

    public void OpenEXE()
    {
        Process.Start(exePath);
    }
}