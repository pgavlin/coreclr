using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__speed_dbgcast_throw__speed_dbgcast_throw_
    {
        [OuterLoop]
        [Fact]
        public void _casts_SEH__speed_dbgcast_throw__speed_dbgcast_throw_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_speed_dbgcast_throw\\_speed_dbgcast_throw.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
