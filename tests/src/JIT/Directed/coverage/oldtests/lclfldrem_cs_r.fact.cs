using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_lclfldrem_cs_r_lclfldrem_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_lclfldrem_cs_r_lclfldrem_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\lclfldrem_cs_r\\lclfldrem_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
