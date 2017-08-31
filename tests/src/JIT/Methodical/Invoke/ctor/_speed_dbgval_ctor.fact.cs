using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_ctor__speed_dbgval_ctor__speed_dbgval_ctor_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_ctor__speed_dbgval_ctor__speed_dbgval_ctor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\ctor\\_speed_dbgval_ctor\\_speed_dbgval_ctor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
