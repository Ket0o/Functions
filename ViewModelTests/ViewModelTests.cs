using Model.Classes;
using ViewModel;

namespace ViewModelTests
{
    public class Tests
    {
        [Test]
        public void LinearValueFunctionTest()
        {
            // arrange
            double x = 2;
            int c = 2;
            double expected = 8;

            // act
            LinearViewModel linearViewModel = new();
            linearViewModel.CoefficientA = 
                linearViewModel.CoefficientB =
                linearViewModel.CoefficientX = 
                linearViewModel.CoefficientY = x;
            linearViewModel.CoefficientC = c;
            double actual = linearViewModel.ValueFunction;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void QuadraticValueFunctionTest()
        {
            // arrange
            double x = 2;
            int c = 20;
            double expected = 32;

            // act
            QuadraticViewModel quadraticViewModel = new();
            quadraticViewModel.CoefficientA = 
                quadraticViewModel.CoefficientB =
                quadraticViewModel.CoefficientX = 
                quadraticViewModel.CoefficientY = x;
            quadraticViewModel.CoefficientC = c;
            double actual = quadraticViewModel.ValueFunction;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CubicValueFunctionTest()
        {
            // arrange
            double x = 2;
            int c = 200;
            double expected = 224;

            // act
            CubicViewModel cubicViewModel = new();
            cubicViewModel.CoefficientA = 
                cubicViewModel.CoefficientB =
                cubicViewModel.CoefficientX = 
                cubicViewModel.CoefficientY = x;
            cubicViewModel.CoefficientC = c;
            double actual = cubicViewModel.ValueFunction;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FourthDegreeValueFunctionTest()
        {
            // arrange
            double x = 2;
            int c = 2000;
            double expected = 2048;

            // act
            FourthDegreeViewModel fourthDegreeViewModel = new();
            fourthDegreeViewModel.CoefficientA = 
                fourthDegreeViewModel.CoefficientB =
                fourthDegreeViewModel.CoefficientX = 
                fourthDegreeViewModel.CoefficientY = x;
            fourthDegreeViewModel.CoefficientC = c;
            double actual = fourthDegreeViewModel.ValueFunction;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FifthDegreeValueFunctionTest()
        {
            // arrange
            double x = 2;
            int c = 20000;
            double expected = 20096;

            // act
            FifthDegreeViewModel fifthDegreeViewModel = new();
            fifthDegreeViewModel.CoefficientA = 
                fifthDegreeViewModel.CoefficientB =
                fifthDegreeViewModel.CoefficientX = 
                fifthDegreeViewModel.CoefficientY = x;
            fifthDegreeViewModel.CoefficientC = c;
            double actual = fifthDegreeViewModel.ValueFunction;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}