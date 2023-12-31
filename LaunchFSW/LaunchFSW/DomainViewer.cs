﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace LaunchFSW
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DomainViewer recording.
    /// </summary>
    [TestModule("ca3eb170-d741-430a-8045-1671d756c1b5", ModuleType.Recording, 1)]
    public partial class DomainViewer : ITestModule
    {
        /// <summary>
        /// Holds an instance of the LaunchFSWRepository repository.
        /// </summary>
        public static LaunchFSWRepository repo = LaunchFSWRepository.Instance;

        static DomainViewer instance = new DomainViewer();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DomainViewer()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DomainViewer Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(0));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Smart_window.NavigationAutomationIdsMainAutomationId' at Center.", repo.Smart_window.NavigationAutomationIdsMainAutomationIdInfo, new RecordItemIndex(1));
            //repo.Smart_window.NavigationAutomationIdsMainAutomationId.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Smart_window.FittingAutomationIdsAdvancedFeaturesAut' at Center.", repo.Smart_window.FittingAutomationIdsAdvancedFeaturesAutInfo, new RecordItemIndex(2));
            //repo.Smart_window.FittingAutomationIdsAdvancedFeaturesAut.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SmartFit.FittingAutomationIdsAdvancedFeaturesAut' at Center.", repo.SmartFit.FittingAutomationIdsAdvancedFeaturesAutInfo, new RecordItemIndex(3));
            //repo.SmartFit.FittingAutomationIdsAdvancedFeaturesAut.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+Alt+Shift+D' Press.", new RecordItemIndex(4));
            //Keyboard.Press(System.Windows.Forms.Keys.D | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(5));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Window.Expander' at Center.", repo.Window.ExpanderInfo, new RecordItemIndex(6));
            //repo.Window.Expander.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Window.Maximize' at Center.", repo.Window.MaximizeInfo, new RecordItemIndex(7));
            //repo.Window.Maximize.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
            //Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Window.Expander1' at Center.", repo.Window.Expander1Info, new RecordItemIndex(9));
            //repo.Window.Expander1.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Window.Expander2' at Center.", repo.Window.Expander2Info, new RecordItemIndex(10));
            //repo.Window.Expander2.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'Window.Expander3' at Center.", repo.Window.Expander3Info, new RecordItemIndex(11));
            //repo.Window.Expander3.MoveTo();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Window.Expander3' at Center.", repo.Window.Expander3Info, new RecordItemIndex(12));
            //repo.Window.Expander3.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'Window.Directionality' at Center.", repo.Window.DirectionalityInfo, new RecordItemIndex(13));
            repo.Window.Directionality.MoveTo();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Window.Directionality' at Center.", repo.Window.DirectionalityInfo, new RecordItemIndex(14));
            repo.Window.Directionality.DoubleClick();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
