using DebugInformation;

namespace Tester
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Naama", "")]
        [InlineData("asf", " ")]
        public void DebugInformationFormatVariables_NotEmptyString_ReturnTrue(string input, string variableName)
        {
            // Arrange

            // Act
            var actual = DebugInf.FormatVariables(input, variableName);

            // Assert
            Assert.NotEmpty(actual);
        }

        [Theory]
        [InlineData(100, "100")]
        [InlineData(-4512, "-4512")]
        [InlineData(0, "0")]
        public void DebugInformationFormatVariables_IntToFormatedString_ReturnTrue(int input, string variableName)
        {
            // Arrange
            string re = $"{DateTime.Now} / Name: {variableName} | Value: {input} | Type: {typeof(int)}";

            // Act
            var actual = DebugInf.FormatVariables(input, variableName);

            // Assert
            Assert.Equal(re, actual);
        }

        [Theory]
        [InlineData("ToLower()")]
        public void DebugInformationFormatFunctionCall_NotEmptyString_ReturnTrue(string input)
        {
            //arrange
            string re = $"{DateTime.Now} / Calling: {input}";

            // act
            var actual = DebugInf.FormatFunctionCall(input);

            // Assert
            Assert.Equal(re, actual);
        }

    }
}