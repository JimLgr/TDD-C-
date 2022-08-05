using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Time;

namespace TestProject1
{
    [TestClass]
    public class UnitMethode
    {
        [TestMethod]
        public void TestMethodAgeInferieur1An()
        {
            // Arrangement
            DateTime dateNaissance = new DateTime(2022, 01, 02);
            DateTime dateFin = new DateTime(2022, 02, 10);
            int ExpectedYear = 0;
            int ExpectedMonth = 1;
            int ExpectedDay = 8;
            // Action
            int[] result = ClsAge.GetAge(dateNaissance, dateFin);

            // Assert
            Assert.AreEqual(ExpectedYear, result[0]);
            Assert.AreEqual(ExpectedMonth, result[1]);
            Assert.AreEqual(ExpectedDay, result[2]);
        }
        [TestMethod]
        public void TestMethodAgeEgale1An()
        {
            // Arrangement
            DateTime dateNaissance = new DateTime(2021, 02, 10);
            DateTime dateFin = new DateTime(2022, 02, 10);
            int ExpectedYear = 1;
            int ExpectedMonth = 0;
            int ExpectedDay = 0;
            // Action
            int[] result = ClsAge.GetAge(dateNaissance, dateFin);

            // Assert
            Assert.AreEqual(ExpectedYear, result[0]);
            Assert.AreEqual(ExpectedMonth, result[1]);
            Assert.AreEqual(ExpectedDay, result[2]);
        }
        [TestMethod]
        public void TestMethodAgeEgale1An1Jour()
        {
            // Arrangement
            DateTime dateNaissance = new DateTime(2021, 02, 09);
            DateTime dateFin = new DateTime(2022, 02, 10);
            int ExpectedYear = 1;
            int ExpectedMonth = 0;
            int ExpectedDay = 1;
            // Action
            int[] result = ClsAge.GetAge(dateNaissance, dateFin);

            // Assert
            Assert.AreEqual(ExpectedYear, result[0]);
            Assert.AreEqual(ExpectedMonth, result[1]);
            Assert.AreEqual(ExpectedDay, result[2]);
        }
        [TestMethod]
        public void TestMethodAgeEgale1AnMoins1Jours()
        {
            // Arrangement
            DateTime dateNaissance = new DateTime(2021, 02, 11);
            DateTime dateFin = new DateTime(2022, 02, 10);
            int ExpectedYear = 0;
            int ExpectedMonth = 11;
            int ExpectedDay = 30;
            // Action
            int[] result = ClsAge.GetAge(dateNaissance, dateFin);

            // Assert
            Assert.AreEqual(ExpectedYear, result[0],"Année différente");
            Assert.AreEqual(ExpectedMonth, result[1], "Mois différent");
            Assert.AreEqual(ExpectedDay, result[2],"Jour différent");
        }
        [TestMethod]
        public void TestMethodAgeEgale2MoisMoins1Jours()
        {
            // Arrangement
            DateTime dateNaissance = new DateTime(2022, 02, 11);
            DateTime dateFin = new DateTime(2022, 04, 10);
            int ExpectedYear = 0;
            int ExpectedMonth = 1;
            int ExpectedDay = 30;
            // Action
            int[] result = ClsAge.GetAge(dateNaissance, dateFin);

            // Assert
            Assert.AreEqual(ExpectedYear, result[0], "Année différente");
            Assert.AreEqual(ExpectedMonth, result[1], "Mois différent");
            Assert.AreEqual(ExpectedDay, result[2], "Jour différent");
        }
    }
}