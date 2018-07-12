using System;
using MovieNight.Library.Models;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class MPersonTests
    {
        [Fact]
        public void Test_PersonId()
        {
            var expected = typeof(Guid);
            var sut = new Person();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }

        [Fact]
        public void Test_PersonHistory()
        {
        
            Assert.NotNull(new Person().History);
        }
    }
}

