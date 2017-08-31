using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_dbglongsig__il_dbglongsig_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_dbglongsig__il_dbglongsig_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_dbglongsig\\_il_dbglongsig.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
