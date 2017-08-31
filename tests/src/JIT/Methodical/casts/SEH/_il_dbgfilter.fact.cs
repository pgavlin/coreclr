using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__il_dbgfilter__il_dbgfilter_
    {
        [Fact]
        public void _casts_SEH__il_dbgfilter__il_dbgfilter_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_il_dbgfilter\\_il_dbgfilter.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
