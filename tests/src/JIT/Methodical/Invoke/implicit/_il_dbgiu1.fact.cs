using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_dbgiu1__il_dbgiu1_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_dbgiu1__il_dbgiu1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_dbgiu1\\_il_dbgiu1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
