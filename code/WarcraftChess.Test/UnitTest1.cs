using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarcraftChess.Domain.Concrete;

namespace WarcraftChess.Test
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Can_Create_Board()
        {
            //Arrange
            Board classUnderTest = new Board();
            classUnderTest.CreateBoard();

            //Assert
            Assert.AreEqual(classUnderTest.ChessBoard.Length, 81);
            Assert.AreEqual(classUnderTest.ChessBoard[1,1].Row, 1);
            Assert.AreEqual(classUnderTest.ChessBoard[8, 8].Column, 8);
        }
    }
}
