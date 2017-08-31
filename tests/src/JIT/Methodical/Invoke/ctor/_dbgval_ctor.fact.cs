using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_ctor__dbgval_ctor__dbgval_ctor_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_ctor__dbgval_ctor__dbgval_ctor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\ctor\\_dbgval_ctor\\_dbgval_ctor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
