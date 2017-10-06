using Lab16TravelPackers.Controllers;
using Lab16TravelPackers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Xunit;

namespace MyUnitTests.tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanChangeTheBuget()
        {
            //Arrange
            var b = new Destination { Budget = 50m };

            //Act
            b.Budget = 100m;

            //Assert
            Assert.Equal(100m, b.Budget);
            

        }

        [Fact]
        public void TestBudgetInRange()
        {
            //Arrange
            var t = new Destination { Budget = 100m };

            //Act
            t.Budget = 300m; 

            //Assert
            Assert.InRange(t.Budget, 100m, 500m);
        }


        [Fact]
        public void TestRepoChangeInDestinationController()
        {
            //Arrange
            var controller = new DestinationController
            {
                _repository = new NewTestRepo()
            };

            //ACT
            var model = (controller.Index() as ViewResult)?.ViewData.Model
                as IEnumerable<Destination>;

            //Assert
            Assert.Equal(controller._repository.Destination, model,
                Comparer.Get<Destination>((p1, p2) => p1.Location == p2.Location
                && p1.Budget == p2.Budget));


        }

        class NewTestRepo : IDestinationRepository
        {
            public IEnumerable<Destination> Destination => new List<Destination>
            {
                new Destination {Location = "P1", Budget = 10m, RainGear = "R1", Shoes = "S1", SunBlock = "SU1"},
                new Destination {Location = "P2", Budget = 20m, RainGear = "R2", Shoes = "S2", SunBlock = "SU2"},
                new Destination {Location = "P3", Budget = 30m, RainGear = "R3", Shoes = "S3", SunBlock = "SU3"}
            };
        }


    }
}
