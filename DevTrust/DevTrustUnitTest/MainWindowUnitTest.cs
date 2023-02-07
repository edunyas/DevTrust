using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using DevTrust;

namespace DevTrustUnitTest
{
    [TestClass]
    public class MainWindowUnitTest
    {
        [TestMethod]
        public void TestExportCSV_Click()
        {
            // Arrange
            var mainWindow = new MainWindow();
            var data = new List<PersonModel>()
        {
            new PersonModel() { FirstName = "Ecem", LastName = "Dunya", Email = "ecem.dunya@gmail.com", FullAddress = "Istanbul Umraniye" },
            new PersonModel() { FirstName = "Nadire", LastName = "Okur", Email = "nadireokur@gmail.com", FullAddress = "Hatay Antakya" }
        };
            mainWindow.dataGrid.SelectedItemsSource = data;

            // Act
            mainWindow.ExportCSV_Click(null, null);

            // Assert
            var exportedData = File.ReadAllText(@"C:\export.csv");
            var expectedData = "First Name,Last Name, Email, FullAddress\r\nEcem,Dunya,ecem.dunya@gmail.com,Istanbul Umraniye\r\nNadire,Okur,nadireokur@gmail.com,Hatay Antakya\r\n";
            Assert.AreEqual(expectedData, exportedData);
        }
    }
}
