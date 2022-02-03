using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("31.570771, -84.10353, Taco Bell Albany...",-84.10353)]
        [InlineData("33.59453,-86.694742,Taco Bell Birmingham...",-86.694742)]
        [InlineData("34.437096,-85.750809,Taco Bell Fort Payn...", -85.750809)]
        [InlineData("32.609135,-85.479907,Taco Bell Auburn...", -85.479907)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var ParseLong = new TacoParser();

            //Act
            var actual = ParseLong.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("33.724109, -84.937891, Taco Bell Villa Ric...", 33.724109)]
        [InlineData("33.205302,-87.569628,Taco Bell Tuscaloos...", 33.205302)]
        [InlineData("34.244093,-85.161119,Taco Bell Rome...", 34.244093)]
        public void ShouldParseLatitude(string line, double expected)
        {
            //act
            var LatitudeParse = new TacoParser();
            var actual = LatitudeParse.Parse(line);
            //assert
            Assert.Equal(expected, actual.Location.Latitude);
        }
    }
}
