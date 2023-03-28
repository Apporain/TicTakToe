using TickTackToeClass;

namespace TickTackToeTest
{
    [TestClass]
    public class UnitTest1
    {
        IGameWinnerService _service;
        char[,] _gameboard;

        [TestInitialize]
        public void MyInitialize()
        {
            _service = new GameWinnerService();
            _gameboard = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        }

        [TestMethod]
        public void ValidateGameboard()
        {
            Assert.AreEqual(_service.Validate(_gameboard), ' ');
        }

        [TestMethod]
        public void ValidateWinTopRowNaughts()
        {
            var expected = '0';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[0, i] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }

        [TestMethod]
        public void ValidateWinTopRowCrosses()
        {
            var expected = 'X';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[0, i] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }
        [TestMethod]
        public void ValidateWinMiddleRowNaughts()
        {
            var expected = '0';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[1, i] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }

        [TestMethod]
        public void ValidateWinMiddleRowCrosses()
        {
            var expected = 'X';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[1, i] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }

        [TestMethod]
        public void ValidateWinBottomRowCrosses()
        {
            var expected = 'X';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[2, i] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }

        [TestMethod]
        public void ValidateWinBottomRowNaughts()
        {
            var expected = '0';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[2, i] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }
        [TestMethod]
        public void ValidateWinLeftColumnNaughts()
        {
            var expected = '0';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[i, 0] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }

        [TestMethod]
        public void ValidateWinLeftColumnCrosses()
        {
            var expected = 'X';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[i, 0] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }
        [TestMethod]
        public void ValidateWinMiddleColumnNaughts()
        {
            var expected = '0';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[i, 1] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }

        [TestMethod]
        public void ValidateWinMiddleColumnCrosses()
        {
            var expected = 'X';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[i, 1] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }

        [TestMethod]
        public void ValidateWinRightColumnCrosses()
        {
            var expected = 'X';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[i, 2] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }

        [TestMethod]
        public void ValidateWinRightColumnNaughts()
        {
            var expected = '0';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[i, 2] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }

        [TestMethod]
        public void ValidateDiaganolLeftNaughts()
        {
            var expected = '0';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[i, i] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }
        [TestMethod]
        public void ValidateDiaganolLeftCrosses()
        {
            var expected = 'X';
            for (int i = 0; i < 3; i++)
            {
                _gameboard[i, i] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }
        [TestMethod]
        public void ValidateDiaganolRightNaughts()
        {
            var expected = '0';
            for (int i = 2; i >= 0; i--)
            {
                _gameboard[i, i] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }
        [TestMethod]
        public void ValidateDiaganolRightCrosses()
        {
            var expected = 'X';
            for (int i = 2; i >= 0; i--)
            {
                _gameboard[i, i] = expected;
            }
            Assert.AreEqual(_service.Validate(_gameboard), expected);
        }

    }


}