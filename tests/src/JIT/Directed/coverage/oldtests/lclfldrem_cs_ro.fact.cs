using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_lclfldrem_cs_ro_lclfldrem_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_lclfldrem_cs_ro_lclfldrem_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\lclfldrem_cs_ro\\lclfldrem_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
