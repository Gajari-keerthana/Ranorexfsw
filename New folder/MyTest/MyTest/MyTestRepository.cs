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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("a31ce71c-0670-44af-a588-5876c70397f5")]
    public partial class MyTestRepository : RepoGenBaseFolder
    {
        static MyTestRepository instance = new MyTestRepository();
        MyTestRepositoryFolders.WindowAutomationIdsStandAloneShellAppFolder _windowautomationidsstandaloneshell;
        MyTestRepositoryFolders.WindowAutomationIdsShellAppFolder _windowautomationidsshell;

        /// <summary>
        /// Gets the singleton class instance representing the MyTestRepository element repository.
        /// </summary>
        [RepositoryFolder("a31ce71c-0670-44af-a588-5876c70397f5")]
        public static MyTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTestRepository() 
            : base("MyTestRepository", "/", null, 0, false, "a31ce71c-0670-44af-a588-5876c70397f5", ".\\RepositoryImages\\MyTestRepositorya31ce71c.rximgres")
        {
            _windowautomationidsstandaloneshell = new MyTestRepositoryFolders.WindowAutomationIdsStandAloneShellAppFolder(this);
            _windowautomationidsshell = new MyTestRepositoryFolders.WindowAutomationIdsShellAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("a31ce71c-0670-44af-a588-5876c70397f5")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The WindowAutomationIdsStandAloneShell folder.
        /// </summary>
        [RepositoryFolder("15b00a9b-1fe6-4d0d-9814-8a96574035d4")]
        public virtual MyTestRepositoryFolders.WindowAutomationIdsStandAloneShellAppFolder WindowAutomationIdsStandAloneShell
        {
            get { return _windowautomationidsstandaloneshell; }
        }

        /// <summary>
        /// The WindowAutomationIdsShell folder.
        /// </summary>
        [RepositoryFolder("e8034797-aefe-4fc0-8156-90f0b92833f9")]
        public virtual MyTestRepositoryFolders.WindowAutomationIdsShellAppFolder WindowAutomationIdsShell
        {
            get { return _windowautomationidsshell; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTestRepositoryFolders
    {
        /// <summary>
        /// The WindowAutomationIdsStandAloneShellAppFolder folder.
        /// </summary>
        [RepositoryFolder("15b00a9b-1fe6-4d0d-9814-8a96574035d4")]
        public partial class WindowAutomationIdsStandAloneShellAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _standaloneautomationidsadd2actionInfo;
            RepoItemInfo _standaloneautomationidsprofileautomatioInfo;
            RepoItemInfo _standaloneautomationidsprofileautomatio1Info;
            RepoItemInfo _standaloneautomationidsdetailsautomatioInfo;
            RepoItemInfo _contenttextblockInfo;
            RepoItemInfo _standaloneautomationidsaudiogramautomatInfo;
            RepoItemInfo _standaloneautomationidsaudiogramautomat1Info;
            RepoItemInfo _standaloneautomationidsdetailsautomatio1Info;
            RepoItemInfo _standaloneautomationidsdetailsautomatio2Info;

            /// <summary>
            /// Creates a new WindowAutomationIdsStandAloneShell  folder.
            /// </summary>
            public WindowAutomationIdsStandAloneShellAppFolder(RepoGenBaseFolder parentFolder) :
                    base("WindowAutomationIdsStandAloneShell", "/form[@automationid='WindowAutomationIds.StandAloneShell']", parentFolder, 30000, null, true, "15b00a9b-1fe6-4d0d-9814-8a96574035d4", "")
            {
                _standaloneautomationidsadd2actionInfo = new RepoItemInfo(this, "StandAloneAutomationIdsAdd2Action", "?/?/button[@automationid='StandAloneAutomationIds.Add2Action']", "?/?/button[@automationid='StandAloneAutomationIds.Add2Action']", 30000, null, "609b3f1e-0a8e-4e89-aeb9-d6ae2fa1971a");
                _standaloneautomationidsprofileautomatioInfo = new RepoItemInfo(this, "StandAloneAutomationIdsProfileAutomatio", "container[@caption='']/list/container[1]//text[@automationid='StandAloneAutomationIds.ProfileAutomationIds.FirstNameField']", ".//text[@automationid='StandAloneAutomationIds.ProfileAutomationIds.FirstNameField']", 30000, null, "07820af3-4ea4-4876-9fb8-4bb3313af23c");
                _standaloneautomationidsprofileautomatio1Info = new RepoItemInfo(this, "StandAloneAutomationIdsProfileAutomatio1", "container[@caption='']/list/container[1]//text[@automationid='StandAloneAutomationIds.ProfileAutomationIds.LastNameField']", ".//text[@automationid='StandAloneAutomationIds.ProfileAutomationIds.LastNameField']", 30000, null, "6d5495ec-f73a-41be-9b19-9fbb20212909");
                _standaloneautomationidsdetailsautomatioInfo = new RepoItemInfo(this, "StandAloneAutomationIdsDetailsAutomatio", "container[@caption='']/list/listitem[@automationid='StandAloneAutomationIds.DetailsAutomationIds.AudiogramAction']", ".//listitem[@automationid='StandAloneAutomationIds.DetailsAutomationIds.AudiogramAction']", 30000, null, "0061ccb3-45f4-41d5-9c9b-a912941e65fd");
                _contenttextblockInfo = new RepoItemInfo(this, "ContentTextBlock", ".//table[@automationid='StandAloneAutomationIds.AudiogramAutomationIds.CellItemsRight']/container[4]/cell[@automationid='StandAloneAutomationIds.AudiogramAutomationIds.CellItemsAutomationIds.AirConduction.125.RIGHT_EAR']/text[@automationid='ContentTextBlock']", ".//cell[@automationid='StandAloneAutomationIds.AudiogramAutomationIds.CellItemsAutomationIds.AirConduction.125.RIGHT_EAR']/text[@automationid='ContentTextBlock']", 30000, null, "41ffa598-7105-4ae2-b4ee-ccda0957f695");
                _standaloneautomationidsaudiogramautomatInfo = new RepoItemInfo(this, "StandAloneAutomationIdsAudiogramAutomat", ".//table[@automationid='StandAloneAutomationIds.AudiogramAutomationIds.CellItemsRight']/container[4]/cell[@automationid='StandAloneAutomationIds.AudiogramAutomationIds.CellItemsAutomationIds.AirConduction.125.RIGHT_EAR']", ".//cell[@automationid='StandAloneAutomationIds.AudiogramAutomationIds.CellItemsAutomationIds.AirConduction.125.RIGHT_EAR']", 30000, null, "409fde1e-e695-46ef-a2ac-d795810205ad");
                _standaloneautomationidsaudiogramautomat1Info = new RepoItemInfo(this, "StandAloneAutomationIdsAudiogramAutomat1", "container[@caption='']/list/?/?/container[@automationid='AudiogramRoot']/?/?/button[@automationid='StandAloneAutomationIds.AudiogramAutomationIds.CopyRightAction']", ".//button[@automationid='StandAloneAutomationIds.AudiogramAutomationIds.CopyRightAction']", 30000, null, "7248b958-457a-4e75-a4a2-242087cefeb1");
                _standaloneautomationidsdetailsautomatio1Info = new RepoItemInfo(this, "StandAloneAutomationIdsDetailsAutomatio1", "container[@caption='']/list/button[@automationid='StandAloneAutomationIds.DetailsAutomationIds.SaveAction']", ".//button[@automationid='StandAloneAutomationIds.DetailsAutomationIds.SaveAction']", 30000, null, "77142371-c472-417b-aa4b-11e547011ca9");
                _standaloneautomationidsdetailsautomatio2Info = new RepoItemInfo(this, "StandAloneAutomationIdsDetailsAutomatio2", "container[@caption='']/list/button[@automationid='StandAloneAutomationIds.DetailsAutomationIds.FitAction']", ".//button[@automationid='StandAloneAutomationIds.DetailsAutomationIds.FitAction']", 30000, null, "29f26ba1-8d07-40cb-8e7f-83dfeae9201a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("15b00a9b-1fe6-4d0d-9814-8a96574035d4")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("15b00a9b-1fe6-4d0d-9814-8a96574035d4")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsAdd2Action item.
            /// </summary>
            [RepositoryItem("609b3f1e-0a8e-4e89-aeb9-d6ae2fa1971a")]
            public virtual Ranorex.Button StandAloneAutomationIdsAdd2Action
            {
                get
                {
                    return _standaloneautomationidsadd2actionInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsAdd2Action item info.
            /// </summary>
            [RepositoryItemInfo("609b3f1e-0a8e-4e89-aeb9-d6ae2fa1971a")]
            public virtual RepoItemInfo StandAloneAutomationIdsAdd2ActionInfo
            {
                get
                {
                    return _standaloneautomationidsadd2actionInfo;
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsProfileAutomatio item.
            /// </summary>
            [RepositoryItem("07820af3-4ea4-4876-9fb8-4bb3313af23c")]
            public virtual Ranorex.Text StandAloneAutomationIdsProfileAutomatio
            {
                get
                {
                    return _standaloneautomationidsprofileautomatioInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsProfileAutomatio item info.
            /// </summary>
            [RepositoryItemInfo("07820af3-4ea4-4876-9fb8-4bb3313af23c")]
            public virtual RepoItemInfo StandAloneAutomationIdsProfileAutomatioInfo
            {
                get
                {
                    return _standaloneautomationidsprofileautomatioInfo;
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsProfileAutomatio1 item.
            /// </summary>
            [RepositoryItem("6d5495ec-f73a-41be-9b19-9fbb20212909")]
            public virtual Ranorex.Text StandAloneAutomationIdsProfileAutomatio1
            {
                get
                {
                    return _standaloneautomationidsprofileautomatio1Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsProfileAutomatio1 item info.
            /// </summary>
            [RepositoryItemInfo("6d5495ec-f73a-41be-9b19-9fbb20212909")]
            public virtual RepoItemInfo StandAloneAutomationIdsProfileAutomatio1Info
            {
                get
                {
                    return _standaloneautomationidsprofileautomatio1Info;
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsDetailsAutomatio item.
            /// </summary>
            [RepositoryItem("0061ccb3-45f4-41d5-9c9b-a912941e65fd")]
            public virtual Ranorex.ListItem StandAloneAutomationIdsDetailsAutomatio
            {
                get
                {
                    return _standaloneautomationidsdetailsautomatioInfo.CreateAdapter<Ranorex.ListItem>(true);
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsDetailsAutomatio item info.
            /// </summary>
            [RepositoryItemInfo("0061ccb3-45f4-41d5-9c9b-a912941e65fd")]
            public virtual RepoItemInfo StandAloneAutomationIdsDetailsAutomatioInfo
            {
                get
                {
                    return _standaloneautomationidsdetailsautomatioInfo;
                }
            }

            /// <summary>
            /// The ContentTextBlock item.
            /// </summary>
            [RepositoryItem("41ffa598-7105-4ae2-b4ee-ccda0957f695")]
            public virtual Ranorex.Text ContentTextBlock
            {
                get
                {
                    return _contenttextblockInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The ContentTextBlock item info.
            /// </summary>
            [RepositoryItemInfo("41ffa598-7105-4ae2-b4ee-ccda0957f695")]
            public virtual RepoItemInfo ContentTextBlockInfo
            {
                get
                {
                    return _contenttextblockInfo;
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsAudiogramAutomat item.
            /// </summary>
            [RepositoryItem("409fde1e-e695-46ef-a2ac-d795810205ad")]
            public virtual Ranorex.Cell StandAloneAutomationIdsAudiogramAutomat
            {
                get
                {
                    return _standaloneautomationidsaudiogramautomatInfo.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsAudiogramAutomat item info.
            /// </summary>
            [RepositoryItemInfo("409fde1e-e695-46ef-a2ac-d795810205ad")]
            public virtual RepoItemInfo StandAloneAutomationIdsAudiogramAutomatInfo
            {
                get
                {
                    return _standaloneautomationidsaudiogramautomatInfo;
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsAudiogramAutomat1 item.
            /// </summary>
            [RepositoryItem("7248b958-457a-4e75-a4a2-242087cefeb1")]
            public virtual Ranorex.Button StandAloneAutomationIdsAudiogramAutomat1
            {
                get
                {
                    return _standaloneautomationidsaudiogramautomat1Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsAudiogramAutomat1 item info.
            /// </summary>
            [RepositoryItemInfo("7248b958-457a-4e75-a4a2-242087cefeb1")]
            public virtual RepoItemInfo StandAloneAutomationIdsAudiogramAutomat1Info
            {
                get
                {
                    return _standaloneautomationidsaudiogramautomat1Info;
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsDetailsAutomatio1 item.
            /// </summary>
            [RepositoryItem("77142371-c472-417b-aa4b-11e547011ca9")]
            public virtual Ranorex.Button StandAloneAutomationIdsDetailsAutomatio1
            {
                get
                {
                    return _standaloneautomationidsdetailsautomatio1Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsDetailsAutomatio1 item info.
            /// </summary>
            [RepositoryItemInfo("77142371-c472-417b-aa4b-11e547011ca9")]
            public virtual RepoItemInfo StandAloneAutomationIdsDetailsAutomatio1Info
            {
                get
                {
                    return _standaloneautomationidsdetailsautomatio1Info;
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsDetailsAutomatio2 item.
            /// </summary>
            [RepositoryItem("29f26ba1-8d07-40cb-8e7f-83dfeae9201a")]
            public virtual Ranorex.Button StandAloneAutomationIdsDetailsAutomatio2
            {
                get
                {
                    return _standaloneautomationidsdetailsautomatio2Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The StandAloneAutomationIdsDetailsAutomatio2 item info.
            /// </summary>
            [RepositoryItemInfo("29f26ba1-8d07-40cb-8e7f-83dfeae9201a")]
            public virtual RepoItemInfo StandAloneAutomationIdsDetailsAutomatio2Info
            {
                get
                {
                    return _standaloneautomationidsdetailsautomatio2Info;
                }
            }
        }

        /// <summary>
        /// The WindowAutomationIdsShellAppFolder folder.
        /// </summary>
        [RepositoryFolder("e8034797-aefe-4fc0-8156-90f0b92833f9")]
        public partial class WindowAutomationIdsShellAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _parteditorInfo;
            RepoItemInfo _textInfo;

            /// <summary>
            /// Creates a new WindowAutomationIdsShell  folder.
            /// </summary>
            public WindowAutomationIdsShellAppFolder(RepoGenBaseFolder parentFolder) :
                    base("WindowAutomationIdsShell", "/form[@automationid='WindowAutomationIds.Shell']", parentFolder, 30000, null, true, "e8034797-aefe-4fc0-8156-90f0b92833f9", "")
            {
                _parteditorInfo = new RepoItemInfo(this, "PARTEditor", "?/?/form[@automationid='PART_FamilyGroupsPopup']/?/?/form[@automationid='PART_Popup']/text[@automationid='PART_Editor']", ".//text[@automationid='PART_Editor']", 30000, null, "8662a9e7-15e4-492a-9899-22f5c34bf0ed");
                _textInfo = new RepoItemInfo(this, "Text", "container[@automationid='PART_LayoutRoot']//text[@automationid='Text']", "?/?/container[@automationid='PART_TitleBar']/container[1]/text[@automationid='Text']", 30000, null, "2600b5eb-71f3-4a91-8859-bc6fb81d3816");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e8034797-aefe-4fc0-8156-90f0b92833f9")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e8034797-aefe-4fc0-8156-90f0b92833f9")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The PARTEditor item.
            /// </summary>
            [RepositoryItem("8662a9e7-15e4-492a-9899-22f5c34bf0ed")]
            public virtual Ranorex.Text PARTEditor
            {
                get
                {
                    return _parteditorInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The PARTEditor item info.
            /// </summary>
            [RepositoryItemInfo("8662a9e7-15e4-492a-9899-22f5c34bf0ed")]
            public virtual RepoItemInfo PARTEditorInfo
            {
                get
                {
                    return _parteditorInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("2600b5eb-71f3-4a91-8859-bc6fb81d3816")]
            public virtual Ranorex.Text Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("2600b5eb-71f3-4a91-8859-bc6fb81d3816")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}