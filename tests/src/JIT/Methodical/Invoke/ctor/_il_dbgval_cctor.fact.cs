using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_ctor__il_dbgval_cctor__il_dbgval_cctor_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_ctor__il_dbgval_cctor__il_dbgval_cctor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\ctor\\_il_dbgval_cctor\\_il_dbgval_cctor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
