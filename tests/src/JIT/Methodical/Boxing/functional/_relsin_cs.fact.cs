using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_functional__relsin_cs__relsin_cs_
    {
        [OuterLoop]
        [Fact]
        public void _Boxing_functional__relsin_cs__relsin_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\functional\\_relsin_cs\\_relsin_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
