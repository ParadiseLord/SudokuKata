using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoko_Kata;

namespace SudoKo_Test
{
    [TestClass]
    public class SudoKoTests
    {
        [TestMethod]
        public void SudoKoTest()
        {
            // Arrange
            var testBoard = new int[][]
                    {
                      new int[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 },
                      new int[] { 6, 7, 2, 1, 9, 5, 3, 4, 8 },
                      new int[] { 1, 9, 8, 3, 0, 2, 5, 6, 7 },
                      new int[] { 8, 5, 0, 7, 6, 1, 4, 2, 3 },
                      new int[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 },
                      new int[] { 7, 0, 3, 9, 2, 4, 8, 5, 6 },
                      new int[] { 9, 6, 1, 5, 3, 7, 2, 8, 4 },
                      new int[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 },
                      new int[] { 3, 0, 0, 2, 8, 6, 1, 7, 9 },
                    };

            // Act
            var Result = Sudoko.ValidateSolution(testBoard);

            // Assert
            Assert.AreEqual(false, Result);
        }
        [TestMethod]
        public void SudoKoTest2()
        {
            // Arrange
            var testBoard = new int[][]
                        {
                          new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
                          new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
                          new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
                          new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
                          new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
                          new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
                          new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
                          new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
                          new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
                        };
            
            // Act
            var Result = Sudoko.ValidateSolution(testBoard);

            // Assert
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void SudoKoTest3()
        {
            // Arrange
            var testBoard = new int[][]
            {
                new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
                new int[] {2, 3, 1, 5, 6, 4, 8, 9, 7},
                new int[] {3, 1, 2, 6, 4, 5, 9, 7, 8},
                new int[] {4, 5, 6, 7, 8, 9, 1, 2, 3},
                new int[] {5, 6, 4, 8, 9, 7, 2, 3, 1},
                new int[] {6, 4, 5, 9, 7, 8, 3, 1, 2},
                new int[] {7, 8, 9, 1, 2, 3, 4, 5, 6},
                new int[] {8, 9, 7, 2, 3, 1, 5, 6, 4},
                new int[] {9, 7, 8, 3, 1, 2, 6, 4, 5},
            };


            // Act
            var Result = Sudoko.ValidateSolution(testBoard);

            // Assert
            Assert.AreEqual(false, Result);
        }
    }
}
