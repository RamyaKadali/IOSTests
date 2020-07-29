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

namespace IOSTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ManageEdit_Click recording.
    /// </summary>
    [TestModule("f673de3b-40cd-483a-9e01-f991f9de4253", ModuleType.Recording, 1)]
    public partial class ManageEdit_Click : ITestModule
    {
        /// <summary>
        /// Holds an instance of the IOSTestRepository repository.
        /// </summary>
        public static IOSTestRepository repo = IOSTestRepository.Instance;

        static ManageEdit_Click instance = new ManageEdit_Click();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ManageEdit_Click()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ManageEdit_Click Instance
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

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComDigitalbarriersEdgeVisClient.UIWindow.Click_MANAGE' at Center", repo.ComDigitalbarriersEdgeVisClient.UIWindow.Click_MANAGEInfo, new RecordItemIndex(0));
            repo.ComDigitalbarriersEdgeVisClient.UIWindow.Click_MANAGE.Touch();
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComDigitalbarriersEdgeVisClient.UIWindow.Click_EDIT' at Center", repo.ComDigitalbarriersEdgeVisClient.UIWindow.Click_EDITInfo, new RecordItemIndex(1));
            repo.ComDigitalbarriersEdgeVisClient.UIWindow.Click_EDIT.Touch();
            Delay.Milliseconds(300);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
