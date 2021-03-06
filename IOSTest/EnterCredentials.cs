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
    ///The EnterCredentials recording.
    /// </summary>
    [TestModule("c6a9dcdc-b1ec-464e-ae37-51b3cbe36c90", ModuleType.Recording, 1)]
    public partial class EnterCredentials : ITestModule
    {
        /// <summary>
        /// Holds an instance of the IOSTestRepository repository.
        /// </summary>
        public static IOSTestRepository repo = IOSTestRepository.Instance;

        static EnterCredentials instance = new EnterCredentials();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnterCredentials()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnterCredentials Instance
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to 'TestA' on item 'ComDigitalbarriersEdgeVisClient.UIWindow.Enter_Username'.", repo.ComDigitalbarriersEdgeVisClient.UIWindow.Enter_UsernameInfo, new RecordItemIndex(0));
            repo.ComDigitalbarriersEdgeVisClient.UIWindow.Enter_Username.Element.SetAttributeValue("Text", "TestA");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(1));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to 'password' on item 'ComDigitalbarriersEdgeVisClient.UIWindow.Enter_Password'.", repo.ComDigitalbarriersEdgeVisClient.UIWindow.Enter_PasswordInfo, new RecordItemIndex(2));
            repo.ComDigitalbarriersEdgeVisClient.UIWindow.Enter_Password.Element.SetAttributeValue("Text", "password");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
