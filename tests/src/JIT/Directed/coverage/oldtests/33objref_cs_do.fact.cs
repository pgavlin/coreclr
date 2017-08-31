using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_33objref_cs_do_33objref_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_33objref_cs_do_33objref_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\33objref_cs_do\\33objref_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
