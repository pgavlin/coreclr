using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__speed_dbgthrow__speed_dbgthrow_
    {
        [Fact]
        public void _casts_SEH__speed_dbgthrow__speed_dbgthrow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_speed_dbgthrow\\_speed_dbgthrow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
