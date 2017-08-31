using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_callvirt__speed_dbgtest1__speed_dbgtest1_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_callvirt__speed_dbgtest1__speed_dbgtest1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\callvirt\\_speed_dbgtest1\\_speed_dbgtest1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
