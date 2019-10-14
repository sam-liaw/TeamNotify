using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSTestTool;
using System;
using System.Collections.Generic;
using TeamNotify;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public virtual void Initialize()
        {
            MSTestLog.Initialize();
        }

        [TestMethod]
        public void TestMethodTeamNotify()
        {
            Dictionary<int, string> dicUrl = new Dictionary<int, string>()
            {
                {1,"https://" }
            };
            Team notify_ = new Team(dicUrl);
            notify_.Notify($"���� Notify:{DateTime.Now.ToString()}", 1, "����");

            MSTestLog.WriteLine($"���զ��\:{DateTime.Now.ToString()}");
        }

        [TestMethod]
        public void TestMethodJandiNotify()
        {
            Dictionary<int, string> dicUrl = new Dictionary<int, string>()
            {
                {1,"https://" }
            };
            JANDI notify_ = new JANDI(dicUrl);
            notify_.Notify($"���� Notify:{DateTime.Now.ToString()}", 1, "����");

            MSTestLog.WriteLine($"���զ��\:{DateTime.Now.ToString()}");
        }
    }
}
