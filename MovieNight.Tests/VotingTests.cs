using System;
using MovieNight.Library.Models;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class VotingTests
    {
        [Fact]
        public void Test_VotingId()
        {
            var expected = typeof(Guid);
            var sut = new Voting();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
        [Fact]

        public void Test_Voting1()
        {
           
            var sut = new Voting();
            var actual = sut.People;

            Assert.True(expected == actual.GetType());
        }
        [Fact]

        public void Test_Voting2()
        {
            var expected = typeof(Guid);
            var sut = new Voting();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
    }
}
