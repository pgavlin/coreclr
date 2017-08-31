using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_lclfldsub_cs_r_lclfldsub_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_lclfldsub_cs_r_lclfldsub_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\lclfldsub_cs_r\\lclfldsub_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
