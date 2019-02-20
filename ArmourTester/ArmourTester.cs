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
        [TestMethod]
        public void testConditionMint()
        {
            string condition;
            for (int i = 100; i < 110; i++) // test return for protection at 100 and over
            {
                Armour ar = new Armour("Jorma", "Kokkeli", i, 2, 2);
                condition = ar.getCondition();
                if (condition != "Mint")
                {
                    Assert.Fail();
                }
                ar = null;
            }     
        }
        [TestMethod]
        public void testConditionExcellent()
        {
            string condition;
            for (int i = 80; i < 89; i++) // test return for protection between the values 80 and 99
            {
                Armour ar = new Armour("Jorma", "Kokkeli", i, 2, 2);
                condition = ar.getCondition();
                if (condition != "Excellent")
                {
                    Assert.Fail();
                }
                ar = null;
            }
        }
        [TestMethod]
        public void testConditionGood() // test Good
        {
            
    
                Armour ar = new Armour("Jorma", "Kokkeli", 62, 2, 2);

                if (ar.getCondition() != "Good")
                {
                    Assert.Fail();
                }
            
        }
        /* 
         if (relation >= 1.0)
        {
            retVal = "Mint";
        }
        else if (relation >= 0.8)
        {
            retVal = "Excellent";
        }
        else if (relation >= 0.6)
        {
            retVal = "Good";
        }
        else if (relation >= 0.4)
        {
            retVal = "Average";
        }
        else if (relation >= 0.2)
        {
            retVal = "Weak";
        }
        else if (relation >= 0.01)
        {
            retVal = "Poor";
        }
        else
        {
            retVal = "Destroyed";
        }
         */
    }
}
