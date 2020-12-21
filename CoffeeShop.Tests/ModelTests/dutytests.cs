using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using CoffeeShop.Models;
using MySql.Data.MySqlClient;

namespace CoffeeShop.Tests
{
    [TestClass]
    public class DutyTests : IDisposable
    {
        public void Dispose()
        {
            Duty.ClearAll();
        }

        public DutyTests()
        {
            DBConfiguration.ConnectionString = "server=localhost;user id=root;password=epicodus;port=3306;database=coffee_shop_test;";
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyDutyFromDatabase_DutyList()
        {
            List<Duty> newList = new List<Duty> { };
            List<Duty> result = Duty.GetAll();
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void Equals_ReturnsTrueIfDutyDescriptionsAreSame_Duty()
        {
            Duty firstDuty = new Duty("swab the decks");
            Duty secondDuty = new Duty("swab the decks");
            Assert.AreEqual(firstDuty, secondDuty);
        }

        [TestMethod]
        public void Save_SavesToDatabase_DutyList()
        {
            Duty testDuty = new Duty("swab the decks");
            testDuty.Save();
            List<Duty> result = Duty.GetAll();
            List<Duty> testDutyList = new List<Duty> { testDuty };
            CollectionAssert.AreEqual(testDutyList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsDutys_DutyList()
        {
            string dutyDescription1 = "swab decks";
            string dutyDescription2 = "Walk the plank";
            Duty newDuty1 = new Duty(dutyDescription1);
            newDuty1.Save();
            Duty newDuty2 = new Duty(dutyDescription2);
            newDuty2.Save();
            List<Duty> newDutyList = new List<Duty> { newDuty1, newDuty2 };
            List<Duty> result = Duty.GetAll();
            CollectionAssert.AreEqual(newDutyList, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectDutyFromDatabase_Duty()
        {
            Duty newDuty1 = new Duty("fire the cannons");
            newDuty1.Save();
            Duty newDuty2 = new Duty("trim sails");
            newDuty2.Save();
            Duty foundDuty = Duty.Find(newDuty1.Id);
            Assert.AreEqual(newDuty1, foundDuty);
        }

    }
}