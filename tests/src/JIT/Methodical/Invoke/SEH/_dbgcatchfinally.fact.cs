using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__dbgcatchfinally__dbgcatchfinally_
    {
        [Fact]
        public void _Invoke_SEH__dbgcatchfinally__dbgcatchfinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_dbgcatchfinally\\_dbgcatchfinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
