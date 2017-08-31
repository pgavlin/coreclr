using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_callvirt__il_dbgtest2__il_dbgtest2_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_callvirt__il_dbgtest2__il_dbgtest2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\callvirt\\_il_dbgtest2\\_il_dbgtest2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
