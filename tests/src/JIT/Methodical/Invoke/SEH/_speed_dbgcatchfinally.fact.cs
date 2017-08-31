using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_SEH__speed_dbgcatchfinally__speed_dbgcatchfinally_
    {
        [Fact]
        public void _Invoke_SEH__speed_dbgcatchfinally__speed_dbgcatchfinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\SEH\\_speed_dbgcatchfinally\\_speed_dbgcatchfinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
