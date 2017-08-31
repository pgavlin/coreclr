using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    class _CLR_x86_JIT_V2_0_Beta2_b323557_b323557_dbg_b323557_dbg_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V2_0_Beta2_b323557_b323557_dbg_b323557_dbg_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V2.0-Beta2\\b323557\\b323557-dbg\\b323557-dbg.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
