using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_dbgshortsig__il_dbgshortsig_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_dbgshortsig__il_dbgshortsig_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_dbgshortsig\\_il_dbgshortsig.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
