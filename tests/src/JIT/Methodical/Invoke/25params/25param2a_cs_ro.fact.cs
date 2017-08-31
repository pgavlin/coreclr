using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Invoke_25params_25param2a_cs_ro_25param2a_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _Invoke_25params_25param2a_cs_ro_25param2a_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Invoke\\25params\\25param2a_cs_ro\\25param2a_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
