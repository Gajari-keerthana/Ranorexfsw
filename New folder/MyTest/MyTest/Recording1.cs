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

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("77107a43-dbc3-4756-8a8f-2b296af4006b", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Recording1Repository repository.
        /// </summary>
        public static Recording1Repository repo = Recording1Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
            First_Name = "";
            Last_Name = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

        string _First_Name;

        /// <summary>
        /// Gets or sets the value of variable First_Name.
        /// </summary>
        [TestVariable("ef439210-e4c6-4592-b0a6-a0c1859010b0")]
        public string First_Name
        {
            get { return _First_Name; }
            set { _First_Name = value; }
        }

        string _Last_Name;

        /// <summary>
        /// Gets or sets the value of variable Last_Name.
        /// </summary>
        [TestVariable("96b55345-6d30-48c5-ab4b-0f4787c98d87")]
        public string Last_Name
        {
            get { return _Last_Name; }
            set { _Last_Name = value; }
        }

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

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\ReSound\\SmartFit\\SmartFitSA.exe' with arguments 'C:\\Program Files (x86)\\ReSound\\SmartFit' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Program Files (x86)\\ReSound\\SmartFit\\SmartFitSA.exe", "C:\\Program Files (x86)\\ReSound\\SmartFit", "", false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(1));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsAdd2Action' at Center.", repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsAdd2ActionInfo, new RecordItemIndex(2));
            repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsAdd2Action.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(3));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsProfileAutomatio' at Center.", repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsProfileAutomatioInfo, new RecordItemIndex(4));
            repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsProfileAutomatio.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(5));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$First_Name'.", new RecordItemIndex(6));
            Keyboard.Press(First_Name);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsProfileAutomatio1' at Center.", repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsProfileAutomatio1Info, new RecordItemIndex(7));
            repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsProfileAutomatio1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Last_Name'.", new RecordItemIndex(8));
            Keyboard.Press(Last_Name);
            Delay.Milliseconds(20);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsDetailsAutomatio' at Center.", repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsDetailsAutomatioInfo, new RecordItemIndex(9));
            repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsDetailsAutomatio.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(10));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowAutomationIdsStandAloneShell.ContentTextBlock' at Center.", repo.WindowAutomationIdsStandAloneShell.ContentTextBlockInfo, new RecordItemIndex(11));
            repo.WindowAutomationIdsStandAloneShell.ContentTextBlock.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}'.", new RecordItemIndex(12));
            Keyboard.Press("{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}{Tab}{NumPad6}{NumPad0}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsAudiogramAutomat1' at Center.", repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsAudiogramAutomat1Info, new RecordItemIndex(13));
            repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsAudiogramAutomat1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(14));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsDetailsAutomatio1' at Center.", repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsDetailsAutomatio1Info, new RecordItemIndex(15));
            repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsDetailsAutomatio1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(16));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsDetailsAutomatio2' at Center.", repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsDetailsAutomatio2Info, new RecordItemIndex(17));
            repo.WindowAutomationIdsStandAloneShell.StandAloneAutomationIdsDetailsAutomatio2.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
