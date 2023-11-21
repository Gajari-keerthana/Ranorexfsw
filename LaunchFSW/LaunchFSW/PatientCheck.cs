/*
 * Created by Ranorex
 * User: I-Ray
 * Date: 11/20/2023
 * Time: 12:24 PM
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
    public class PatientCheck
    {
        // You can use the "Insert New User Code Method" functionality from the context menu,
        // to add a new method with the attribute [UserCodeMethod].
        
        /// <summary>
        /// This is a placeholder text. Please describe the purpose of the
        /// user code method here. The method is published to the user code library
        /// within a user code collection.
        /// </summary>
        [UserCodeMethod]
        public static void ValidatePatient()
        {
        	var repo = LaunchFSWRepository.Instance;
        	
        	var test = repo.Smart_window.Test
        	var patient = repo.Smart_window.Patient



    	  	string expectedTextForTest = "Test";
      		string expectedTextForPatient = "Patient";
      		

      		Validate.AreEqual(test.TextValue, expectedTextForTest, "Validation for Test element");
			Validate.AreEqual(patient.TextValue, expectedTextForPatient, "Validation for Patient element");
        	


        


        
        	
        }
        
    }
}
