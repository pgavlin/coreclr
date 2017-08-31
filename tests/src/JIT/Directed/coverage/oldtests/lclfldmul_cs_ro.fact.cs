using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_lclfldmul_cs_ro_lclfldmul_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_lclfldmul_cs_ro_lclfldmul_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\lclfldmul_cs_ro\\lclfldmul_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
