using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_lclflddiv_cs_d_lclflddiv_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_lclflddiv_cs_d_lclflddiv_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\lclflddiv_cs_d\\lclflddiv_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
