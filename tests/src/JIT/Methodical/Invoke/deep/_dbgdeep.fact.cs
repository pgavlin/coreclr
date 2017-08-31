using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_deep__dbgdeep__dbgdeep_
    {
        [Fact]
        public void _Invoke_deep__dbgdeep__dbgdeep_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\deep\\_dbgdeep\\_dbgdeep.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
