using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_lclfldrem_cs_d_lclfldrem_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_lclfldrem_cs_d_lclfldrem_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\lclfldrem_cs_d\\lclfldrem_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
