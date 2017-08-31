using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_coverage__il_dbgcastclass_calli__il_dbgcastclass_calli_
    {
        [Fact]
        public void _casts_coverage__il_dbgcastclass_calli__il_dbgcastclass_calli_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\coverage\\_il_dbgcastclass_calli\\_il_dbgcastclass_calli.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
