using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_implicit__il_dbgii1__il_dbgii1_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_implicit__il_dbgii1__il_dbgii1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\implicit\\_il_dbgii1\\_il_dbgii1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
