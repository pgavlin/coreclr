using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_deep__speed_dbgdeep__speed_dbgdeep_
    {
        [Fact]
        public void _Invoke_deep__speed_dbgdeep__speed_dbgdeep_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\deep\\_speed_dbgdeep\\_speed_dbgdeep.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
