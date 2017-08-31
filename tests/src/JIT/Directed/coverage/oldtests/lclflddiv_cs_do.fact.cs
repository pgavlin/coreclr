using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_lclflddiv_cs_do_lclflddiv_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_lclflddiv_cs_do_lclflddiv_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\lclflddiv_cs_do\\lclflddiv_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
