using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing2018;

namespace ArmourTester
{
    [TestClass]
    public class ArmourTester
    {
        [TestMethod]
        public void TestLevel1()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int lvl = ar.getLevel();

            if (lvl != 2)
            {
                Assert.Fail();
            }
            
        }
        [TestMethod]
        public void TestSlot1()
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 20, 2, 2);
            int slot = ar.getSlot();
            
            if (slot != 2)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestProtection1() // Test output for unexpected protection levels
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 200, 8, 4);
            string condition = ar.getCondition();

            if (condition == "")
            {
                Console.WriteLine(condition);
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestDamage1() // Check for negative damage
        {
            Armour ar = new Armour("Jorma", "Kokkeli", 40, 2, 2);
  
            ar.takeDam(42);
            int curProt = ar.getCurProt();

            if (curProt < 0)
            {
                Assert.Fail();
            }
        }
    }
}
