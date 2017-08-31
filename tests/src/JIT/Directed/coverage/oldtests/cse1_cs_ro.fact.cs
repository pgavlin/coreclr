using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_cse1_cs_ro_cse1_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_cse1_cs_ro_cse1_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\cse1_cs_ro\\cse1_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
