using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__dbgcatchfinally_tail__dbgcatchfinally_tail_
    {
        [Fact]
        public void _Invoke_SEH__dbgcatchfinally_tail__dbgcatchfinally_tail_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_dbgcatchfinally_tail\\_dbgcatchfinally_tail.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
