/*
 * Created by Ranorex
 * User: I-Ray
 * Date: 11/14/2023
 * Time: 5:19 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace LaunchFSW
{
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class CloseApp
    {


    	/// <summary>
/// This is a placeholder text. Please describe the purpose of the
/// user code method here. The method is published to the user code library
/// within a user code collection.
/// </summary>
[UserCodeMethod]
	public static void killFSW()
	{
       //string applicationPath = @"C:\Program Files (x86)\ReSound\SmartFit\SmartFit.exe";
       
       foreach(Process proc in Process.GetProcessesByName("SmartFitSA"))
       {
       	proc.Kill();
       }

    
   
           

	}

    }
}
