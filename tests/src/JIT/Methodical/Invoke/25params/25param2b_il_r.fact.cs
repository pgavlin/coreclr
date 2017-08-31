using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_25params_25param2b_il_r_25param2b_il_r_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_25params_25param2b_il_r_25param2b_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\25params\\25param2b_il_r\\25param2b_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
