using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_25params_25param3a_cs_do_25param3a_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_25params_25param3a_cs_do_25param3a_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\25params\\25param3a_cs_do\\25param3a_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
