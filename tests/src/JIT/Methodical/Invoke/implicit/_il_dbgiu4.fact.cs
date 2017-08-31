using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_dbgiu4__il_dbgiu4_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_dbgiu4__il_dbgiu4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_dbgiu4\\_il_dbgiu4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
