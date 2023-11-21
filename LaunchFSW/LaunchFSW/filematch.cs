/*
 * Created by Ranorex
 * User: I-Ray
 * Date: 11/15/2023
 * Time: 5:56 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace LaunchFSW
{
    [UserCodeCollection]
    public class Filematch
    {
        
        [UserCodeMethod]
        public static void Compare()
        {
			string[] lines1 = File.ReadAllLines("C:\\Users\\I-Ray\\Desktop\\New folder\\DefaultGains.csv");
        	string[] lines2 = File.ReadAllLines("C:\\Users\\I-Ray\\Desktop\\New folder\\ResetGains.csv");
       	  	bool filesAreEqual = true;
    		for (int i = 0; i < Math.Min(lines1.Length, lines2.Length); i++)
    		{
        		if (lines1[i] != lines2[i])
        		{
            	filesAreEqual = false;
            	Ranorex.Report.Info("Comparision UnSuccessfull");
            	Ranorex.Report.Failure("Comparision UnSuccessfull");
            	break; 
        	}
    	}
    	if (filesAreEqual)
    	{
       			Ranorex.Report.Success("Comparision Successfull");
    	}	
      }
        
      
        [UserCodeMethod]
        public static void compare2()
        {
        	string[] lines1 = File.ReadAllLines("C:\\Users\\I-Ray\\Desktop\\New folder\\CouplerGains.csv");
        	string[] lines2 = File.ReadAllLines("C:\\Users\\I-Ray\\Desktop\\New folder\\CouplerGains1.csv");
       	  	bool filesAreEqual = true;
    		for (int i = 0; i < Math.Min(lines1.Length, lines2.Length); i++)
    		{
        		if (lines1[i] != lines2[i])
        		{
            	filesAreEqual = false;
				//Report.Screenshot(ReportLevel.Failure, "", "Data Failure", false);
				Report.Failure("Comparision UnSuccessfull");
				Ranorex.Report.Info("Comparision UnSuccessfull");
            	break; 
        	}
    	}
    	if (filesAreEqual)
    	{
       		 Ranorex.Report.Info("Comparision Successfull");
    	}	
        }
  }
}

        
    
