using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany_lcs_lcs_
    {
        [OuterLoop]
        [Fact]
        public void _refany_lcs_lcs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\lcs\\lcs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
