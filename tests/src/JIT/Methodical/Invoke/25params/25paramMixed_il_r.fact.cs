using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_25params_25paramMixed_il_r_25paramMixed_il_r_
    {
        [Fact]
        public void _Invoke_25params_25paramMixed_il_r_25paramMixed_il_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\25params\\25paramMixed_il_r\\25paramMixed_il_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
