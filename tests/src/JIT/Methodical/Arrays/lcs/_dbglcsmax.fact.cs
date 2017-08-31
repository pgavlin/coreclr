using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__dbglcsmax__dbglcsmax_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_lcs__dbglcsmax__dbglcsmax_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_dbglcsmax\\_dbglcsmax.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
