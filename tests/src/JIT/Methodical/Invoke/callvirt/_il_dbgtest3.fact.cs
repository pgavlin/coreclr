using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_callvirt__il_dbgtest3__il_dbgtest3_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_callvirt__il_dbgtest3__il_dbgtest3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\callvirt\\_il_dbgtest3\\_il_dbgtest3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
