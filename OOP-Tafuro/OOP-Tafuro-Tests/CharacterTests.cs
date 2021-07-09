using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_Tafuro;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Tafuro.Tests
{
    [TestClass()]
    public class CharacterTests
    {
        Character testCharacter = new Character("Marty", 150, null);
        Character testPlayerCharacter = new PlayerCharacter(new Character("Marty", 150, null));
        Character testEnemyCharacter = new EnemyCharacter(new Character("Biff", 150, null), null);

        [TestMethod()]
        public void TestsCharacter()
        {
            Assert.AreEqual("Marty", testCharacter.Name);
            Assert.AreEqual(150, testCharacter.Hp);
            Assert.AreEqual(null, testCharacter.Weapon);
        }

        public void TestsPlayerCharacter()
        {
            Assert.AreEqual("Marty", testPlayerCharacter.Name);
            Assert.AreEqual(150, testPlayerCharacter.Hp);
            Assert.AreEqual(null, testPlayerCharacter.Weapon);
        }

        public void TestsEnemyCharacter()
        {
            Assert.AreEqual(null, testEnemyCharacter.DropWeapon);
        }
    }
}