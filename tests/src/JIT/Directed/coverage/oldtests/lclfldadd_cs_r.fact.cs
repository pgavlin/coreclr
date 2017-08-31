using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_lclfldadd_cs_r_lclfldadd_cs_r_
    {
        [Fact]
        public void _coverage_oldtests_lclfldadd_cs_r_lclfldadd_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\lclfldadd_cs_r\\lclfldadd_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
