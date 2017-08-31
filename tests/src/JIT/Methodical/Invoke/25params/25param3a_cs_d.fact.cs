using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_25params_25param3a_cs_d_25param3a_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_25params_25param3a_cs_d_25param3a_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\25params\\25param3a_cs_d\\25param3a_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
