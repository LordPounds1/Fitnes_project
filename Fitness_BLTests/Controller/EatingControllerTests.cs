﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fitness_BL.Controller;
using System;
using System.Collections.Generic;
using System.Text;
using Fitness_BL.Model;
using System.Linq;

namespace Fitness_BL.Controller.Tests
{
    [TestClass()]
    public class EatingControllerTests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arrange
            var userName = Guid.NewGuid().ToString();
            var foodName = Guid.NewGuid().ToString();
            var rnd = new Random();
            var userController = new UserController(userName);
            var eatingController = new EatingController(userController.CurrentUser);
            var food = new Food(foodName, rnd.Next(50, 500), rnd.Next(50, 500), rnd.Next(50, 500), rnd.Next(50, 500));

            // Act

            eatingController.Add(food, 100);

            // Assert
            Assert.AreEqual(food.Name, eatingController.Eating.Foods.First().Key.Name);
        }
    }
}