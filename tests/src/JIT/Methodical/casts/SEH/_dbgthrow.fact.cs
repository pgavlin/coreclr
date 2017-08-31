using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_SEH__dbgthrow__dbgthrow_
    {
        [Fact]
        public void _casts_SEH__dbgthrow__dbgthrow_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\SEH\\_dbgthrow\\_dbgthrow.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
