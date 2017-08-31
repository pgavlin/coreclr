using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_cse2_cs_r_cse2_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_cse2_cs_r_cse2_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\cse2_cs_r\\cse2_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
