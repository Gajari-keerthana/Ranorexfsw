/*
 * Created by Ranorex
 * User: I-Ray
 * Date: 11/15/2023
 * Time: 4:49 PM
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
    public class C2cgains
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void N2ccoupler()
        {
        	string filePath = "C:\\Users\\I-Ray\\Desktop\\New folder\\CouplerGains.csv";
    		var repo = LaunchFSWRepository.Instance;
    		Ranorex.Container values = "/form[@name='ReSound Smart Fit 1.17']/container[2]";
    		
    		using (var writer = new StreamWriter(filePath))
    			
    		foreach(Ranorex.Text txt in values.FindChildren<Ranorex.Text>())
    		{
    			writer.WriteLine(txt.TextValue);
    		}
    
        }
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void N2ccoupler2()
        {
        	string filePath1 = "C:\\Users\\I-Ray\\Desktop\\New folder\\CouplerGains1.csv";
    		var repo = LaunchFSWRepository.Instance;
    		Ranorex.Container values = "/form[@name='ReSound Smart Fit 1.17']/container[2]";
    		
    		using (var writer = new StreamWriter(filePath1))
    			
    		foreach(Ranorex.Text txt in values.FindChildren<Ranorex.Text>())
    		{
    			writer.WriteLine(txt.TextValue);
    		}
        }
    }
}
