using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_dbgiu2__il_dbgiu2_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_dbgiu2__il_dbgiu2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_dbgiu2\\_il_dbgiu2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
