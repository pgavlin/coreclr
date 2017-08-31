using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_dbgldnull__il_dbgldnull_
    {
        [OuterLoop]
        [Fact]
        public void _casts_coverage__il_dbgldnull__il_dbgldnull_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_dbgldnull\\_il_dbgldnull.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
