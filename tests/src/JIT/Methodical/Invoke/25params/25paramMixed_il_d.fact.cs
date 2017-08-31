using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_25params_25paramMixed_il_d_25paramMixed_il_d_
    {
        [Fact]
        public void _Invoke_25params_25paramMixed_il_d_25paramMixed_il_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\25params\\25paramMixed_il_d\\25paramMixed_il_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
