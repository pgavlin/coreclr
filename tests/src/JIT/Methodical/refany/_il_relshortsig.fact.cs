using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_relshortsig__il_relshortsig_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_relshortsig__il_relshortsig_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_relshortsig\\_il_relshortsig.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
