using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_callvirt__dbgtest1__dbgtest1_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_callvirt__dbgtest1__dbgtest1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\callvirt\\_dbgtest1\\_dbgtest1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
