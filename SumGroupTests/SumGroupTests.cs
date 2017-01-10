using System;
using System.Collections.Generic;
using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using SumGroup;

namespace SumGroup.Tests
{
    [TestClass()]
    //1. 來源可以是「任何型別的集合」
    //2. 可以任意決定幾筆一組
    //3. 回傳每一組 Σf(x) 的集合
    //- Σ結果型別可直接用int
    public class SumGroupTests
    {
        [TestMethod()]
        public void SumTest_field_cost_group_3_get_6_15_24_21()
        {
            //arrange
            var rawData = new List<Data>
            {
                new Data { Id=1, Cost=1, Revenue=11, SellPrice=21},
                new Data { Id=2, Cost=2, Revenue=12, SellPrice=22},
                new Data { Id=3, Cost=3, Revenue=13, SellPrice=23},
                new Data { Id=4, Cost=4, Revenue=14, SellPrice=24},
                new Data { Id=5, Cost=5, Revenue=15, SellPrice=25},
                new Data { Id=6, Cost=6, Revenue=16, SellPrice=26},
                new Data { Id=7, Cost=7, Revenue=17, SellPrice=27},
                new Data { Id=8, Cost=8, Revenue=18, SellPrice=28},
                new Data { Id=9, Cost=9, Revenue=19, SellPrice=29},
                new Data { Id=10, Cost=10, Revenue=20, SellPrice=30},
                new Data { Id=11, Cost=11, Revenue=21, SellPrice=31},
            };

            var field = "Cost";
            int group = 3;
            var expected = new List<int> { 6, 15, 24, 21 };
            SumGroup sumGroup = new SumGroup();

            //act
            var actual = sumGroup.getGroupSum(rawData, field, group);

            //assert
            actual.ShouldBeEquivalentTo(expected);  
        }

        [TestMethod()]
        public void SumTest_field_Revenue_group_4_get_50_66_60()
        {
            //arrange
            var rawData = new List<Data>
            {
                new Data { Id=1, Cost=1, Revenue=11, SellPrice=21},
                new Data { Id=2, Cost=2, Revenue=12, SellPrice=22},
                new Data { Id=3, Cost=3, Revenue=13, SellPrice=23},
                new Data { Id=4, Cost=4, Revenue=14, SellPrice=24},
                new Data { Id=5, Cost=5, Revenue=15, SellPrice=25},
                new Data { Id=6, Cost=6, Revenue=16, SellPrice=26},
                new Data { Id=7, Cost=7, Revenue=17, SellPrice=27},
                new Data { Id=8, Cost=8, Revenue=18, SellPrice=28},
                new Data { Id=9, Cost=9, Revenue=19, SellPrice=29},
                new Data { Id=10, Cost=10, Revenue=20, SellPrice=30},
                new Data { Id=11, Cost=11, Revenue=21, SellPrice=31},
            };

            var field = "Revenue";
            int group = 4;
            var expected = new List<int> { 50, 66, 60 };
            SumGroup sumGroup = new SumGroup();

            //act
            var actual = sumGroup.getGroupSum(rawData, field, group);

            //assert
            actual.ShouldBeEquivalentTo(expected);
        }
    }
}