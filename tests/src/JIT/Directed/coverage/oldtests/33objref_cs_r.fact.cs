using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_33objref_cs_r_33objref_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_33objref_cs_r_33objref_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\33objref_cs_r\\33objref_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
