using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_lclfldrem_cs_do_lclfldrem_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_lclfldrem_cs_do_lclfldrem_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\lclfldrem_cs_do\\lclfldrem_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
