using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_rellongsig__il_rellongsig_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_rellongsig__il_rellongsig_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_rellongsig\\_il_rellongsig.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
