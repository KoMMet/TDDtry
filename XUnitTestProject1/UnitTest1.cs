using System;
using Xunit;
using ConsoleTry;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void goo_tai_paa_p1_win()
        {
            var j = new Janken();
            Assert.True(j.poi("goo", "paa")== "p1");
        }
        [Fact]
        public void thoki_tai_paa_p1_win()
        {
            var j = new Janken();
            Assert.True(j.poi("thoki","paa")=="p1");
        }
        [Fact]
        public void paa_tai_goo_p2_win()
        {
            var j =new Janken();
            Assert.True(j.poi("paa","goo")=="p2");
        }
    }
}
