/*
 * Created by Ranorex
 * User: I-Ray
 * Date: 10/26/2023
 * Time: 11:47 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.IO;
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
    /// <summary>
    /// Creates a Ranorex user code collection. A collection is used to publish user code methods to the user code library.
    /// </summary>
    [UserCodeCollection]
    public class Datagains
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void targetrules()
        {
        	Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            Delay.Seconds(5);
        	string filePath = "C:\\Users\\I-Ray\\Desktop\\New folder\\gains.csv";
        	var repo = LaunchFSWRepository.Instance;
 			Ranorex.Table dataGrid = repo.TargetViewer.DataGrid.FindSingle("/form[@name='Target Viewer' and @classname='Window' and @orientation='None']/?/?/tabpagelist/tabpage[1]/container[@automationid='MainScrollViewer']/table[3]");

        	var rows = dataGrid.Rows;
			var columns = dataGrid.Columns;

 			List<string[]> tableData = new List<string[]>();

 			foreach(var row in rows)
    		{
     		List<string> rowData = new List<string>();
     		foreach(var cell in row.Cells)
    		{
        	string cellValue = cell.Text;
        	rowData.Add(cellValue);
     		}
    		tableData.Add(rowData.ToArray());
			}

			using (var writer = new StreamWriter(filePath))
			{
    	  	foreach (var rowData in tableData)
    		{
       		 writer.WriteLine(string.Join(",", rowData));
    		}
			}    	
     

	  }
    
    }
}
        	
        
			