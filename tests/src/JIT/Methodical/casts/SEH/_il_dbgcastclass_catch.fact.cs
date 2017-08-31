using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__il_dbgcastclass_catch__il_dbgcastclass_catch_
    {
        [Fact]
        public void _casts_SEH__il_dbgcastclass_catch__il_dbgcastclass_catch_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_il_dbgcastclass_catch\\_il_dbgcastclass_catch.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
