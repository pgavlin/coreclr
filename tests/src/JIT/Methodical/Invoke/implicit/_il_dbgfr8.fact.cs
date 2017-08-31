using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_dbgfr8__il_dbgfr8_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_dbgfr8__il_dbgfr8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_dbgfr8\\_il_dbgfr8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
