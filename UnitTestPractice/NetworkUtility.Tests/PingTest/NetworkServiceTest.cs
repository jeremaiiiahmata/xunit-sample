using FluentAssertions;
using NetworkUtility.Ping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Tests.PingTest
{
    public class NetworkServiceTest
    {
        //Testing Returning String
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange - variables, classes, mocks
            var pingService = new NetworkService();

            //Act - execution of the function
            var result = pingService.SendPing();


            //Assert
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Be("Success: Ping Sent!");
            result.Should().Contain("Success", Exactly.Once());

        }

        //Testing Returning Integers - Positive
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(10, 10, 20)]
        [InlineData(1354, 3612, 4966)]
        public void NetworkService_Addition_ReturnPositive(int a, int b, int expected)
        {
            //Arrange
            var pingService = new NetworkService();

            //Act
            var result = pingService.Addition(a, b);

            //Assert
            result.Should().BePositive();
            result.Should().Be(expected);
        }

        //Testing Returning Integers - Negative
        [Theory]
       
        [InlineData(1, 2, -1)]
        [InlineData(2, 10, -8)]
        [InlineData(10, 210, -200)]
        [InlineData(1354, 3612, -2258)]
        public void NetworkService_Subtraction_ReturnNegative(int a, int b, int expected)
        {
            //Arrange
            var pingService = new NetworkService();

            //Act
            var result = pingService.Subtraction(a, b);

            //Assert
            result.Should().BeNegative();
            result.Should().Be(expected);
        }


        //Testing Exceptions
        [Fact]
        public void NetworkService_DivideByZero_ThrowsException()
        {
            //Arrange
            var pingService = new NetworkService();

            //Act 
            Action result = () => pingService.DivideByZero(5, 0);

            //Assert
            result.Should().Throw<DivideByZeroException>()
            .WithMessage("Cannot be divided by zero.");
        }

        //Testing objects
        [Fact]
        public void NetworkService_GetPingResult_ReturnsObject()

        {
            //Arrange
            var pingService = new NetworkService();

            //Act 
            var result = pingService.GetPingResult();

            //Assert
            result.Should().NotBeNull();
            result.IsSuccessful.Should().BeTrue();
            result.Message.Should().Be("Ping Complete");
        }
    } 
}
