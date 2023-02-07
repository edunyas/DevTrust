using DevTrust.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DevTrust.Tests
{
    [TestClass]
    public class DataAccessServiceTests
    {
        private IDataAccessService _service;

        [TestInitialize]
        public void TestInitialize()
        {
            _service = new DataAccessService();
        }

        [TestMethod]
        public void GetPeople_ReturnsListOfPeople()
        {
            // Act
            var result = _service.Get
