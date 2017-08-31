using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_callvirt__il_dbgtest1__il_dbgtest1_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_callvirt__il_dbgtest1__il_dbgtest1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\callvirt\\_il_dbgtest1\\_il_dbgtest1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
