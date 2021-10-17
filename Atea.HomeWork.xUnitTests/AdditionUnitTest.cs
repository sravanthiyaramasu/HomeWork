using Atea.Homework;
using Newtonsoft.Json;
using Xunit;

namespace Atea.HomeWork.xUnitTests
{
    public class AdditionUnitTest
    {
        [Fact]
        public void IntAdditionTest()
        {
            // Arrange
            // Preparing input data
            Input input = new Input();
            input.firstArgument = 20;
            input.secondArgument = 60;

            // Preparing output data to compare
            Entity output = new Entity();
            output.firstArgument ="20";
            output.secondArgument ="60";
            output.sum ="80";

            Entity result = new Entity();

            //Act
            var common = new Common();
            if(common.validateInputTypes(input))
            {
                result = common.AddValues(input);

            }
            //Assert
            Assert.Equal(JsonConvert.SerializeObject(output), JsonConvert.SerializeObject(result));
            
        }

        [Fact]
        public void DecimalAdditionTest()
        {
            // Arrange
            // Preparing input data
            Input input = new Input();
            input.firstArgument = 20.78;
            input.secondArgument = 60.21;

            // Preparing output data to compare
            Entity output = new Entity();
            output.firstArgument = "20.78";
            output.secondArgument = "60.21";
            output.sum = "80.99";

            Entity result = new Entity();

            //Act
            var common = new Common();
            if (common.validateInputTypes(input))
            {
                result = common.AddValues(input);

            }
            //Assert
            Assert.Equal(JsonConvert.SerializeObject(output), JsonConvert.SerializeObject(result));


        }

        [Fact]
        public void StringAdditionTest()
        {
            // Arrange
            // Preparing input data
            Input input = new Input();
            input.firstArgument = "ABC";
            input.secondArgument = "DEF";

            // Preparing output data to compare
            Entity output = new Entity();
            output.firstArgument = "ABC";
            output.secondArgument = "DEF";
            output.sum = "ABCDEF";

            Entity result = new Entity();

            //Act
            var common = new Common();
            if (common.validateInputTypes(input))
            {
                result = common.AddValues(input);

            }
            //Assert
            Assert.Equal(JsonConvert.SerializeObject(output), JsonConvert.SerializeObject(result));


        }
    }
}
