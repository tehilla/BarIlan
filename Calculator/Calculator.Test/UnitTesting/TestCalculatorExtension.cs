﻿using Calculator.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Test.UnitTesting
{
    [TestClass]
    public class TestCalculatorExtension
    {
        [TestMethod]
        public void TestReturnsNumericFromNumericChar()
        {
            //arrange 
            string numeric = "5";

            //act
            Token result = numeric.GetTokenFromString();

            //assert
            Assert.IsInstanceOfType(result, typeof(NumericToken));
        }

        [TestMethod]
        public void TestReturnsNullFromNotNumericOrOperator()
        {
            //arrange 
            string numeric = "(";

            //act
            Token result = numeric.GetTokenFromString();

            //assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestReturnsOperatorFromOperatorChar()
        {
            //arrange 
            string numeric = "+";

            //act
            Token result = numeric.GetTokenFromString();

            //assert
            Assert.IsInstanceOfType(result, typeof(OperatorToken));
        }

        //[TestMethod]
        //public void TestReturnsNumericFromNotNumericBiggerThenNine()
        //{
        //    //arrange 
        //    char numeric = '11';

        //    //act
        //    Token result = numeric.GetTokenFromChar();

        //    //assert
        //    Assert.IsNull(result);
        //}
    }
}
