using System;
using MovieNight.Library.Models;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MovieNight.Tests
{
    public class ShowingTests
    {
        [Fact]
        public void Test_ShowingId()
        {
            var expected = typeof(Guid);
            var sut = new Showing();
            var actual = sut.Id;

            Assert.True(expected == actual.GetType());
        }
        [Fact]
        public void Test_ShowingMovies()
        {
            var expected = 1;
            var sut = new Showing();
            var actual = sut.Movies;

            Assert.True(expected == actual.GetType());

        }
    }
}
