/*
 * Created by Ranorex
 * User: I-Ray
 * Date: 10/20/2023
 * Time: 12:29 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
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
    public class viewlist
    {
    	
    	/// <summary>
    	/// This is a placeholder text. Please describe the purpose of the
    	/// user code method here. The method is published to the user code library
    	/// within a user code collection.
    	/// </summary>
    	[UserCodeMethod]
    	public static void setcouplers_randomly()
    	{
    		Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            Delay.Seconds(5);
            var repo = LaunchFSWRepository.Instance;
            
            var ViewAction = repo.Smart_window.MenuAutomationIdsViewAction
            for(int i=0; i <= 2; i++)
            {
            	ViewAction.Click();
            	var someContainer = repo.SmartFit.SomeContainer;
            	someContainer.Click();
         	
            	Ranorex.MenuItem insertion = repo.SmartFit.MenuAutomationIdsViewAutomationIdsCoup1;
            	var Coup = repo.MenuAutomationIdsViewAutomationIdsCoup;
            	var coupler = repo.SmartFit.MenuAutomationIdsViewAutomationIdsCoup2;

            	if(i==0 && insertion.Checked == true)
            	{
            		Report.Info("insertion is selected");
            		coupler.Click();
            	}
            	if(i==1 && insertion.Checked == false)
            	{
            		Report.Info("insertion is not selected");
            		Coup.Click();
            	}
            	if(i==2 && insertion.Checked == false)
            	{
            		insertion.Click();
            	}
            }
        }
            

            	

        	

        		
        	


    	}
    }
