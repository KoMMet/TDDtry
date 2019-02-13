using System;
using Xunit;
using ConsoleTry;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private Janken j = new Janken();
        [Fact]
        public void goo_tai_thoki_p1_win()
        {
            var res = j.poi("goo", "thoki");
            Assert.True(res == "p1");
        }
        
        [Fact]
        public void paa_tai_goo_p1_win()
        {
            var res = j.poi("paa", "goo");
            Assert.True(res=="p1");
        }
        [Fact]
        public void goo_tai_paa_p2_win()
        {
            var res = j.poi("goo", "paa");
            Assert.True(res == "p2");
        }
    }
}
