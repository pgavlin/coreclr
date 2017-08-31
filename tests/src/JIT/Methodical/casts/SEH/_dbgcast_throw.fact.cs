using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__dbgcast_throw__dbgcast_throw_
    {
        [OuterLoop]
        [Fact]
        public void _casts_SEH__dbgcast_throw__dbgcast_throw_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_dbgcast_throw\\_dbgcast_throw.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
