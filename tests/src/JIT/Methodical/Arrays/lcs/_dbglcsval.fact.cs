using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_lcs__dbglcsval__dbglcsval_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_lcs__dbglcsval__dbglcsval_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\lcs\\_dbglcsval\\_dbglcsval.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
