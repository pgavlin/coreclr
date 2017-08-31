using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_25params_25param1b_il_d_25param1b_il_d_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_25params_25param1b_il_d_25param1b_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\25params\\25param1b_il_d\\25param1b_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
