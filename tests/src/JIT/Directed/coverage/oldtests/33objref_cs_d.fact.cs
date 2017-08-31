using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_oldtests_33objref_cs_d_33objref_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_oldtests_33objref_cs_d_33objref_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\oldtests\\33objref_cs_d\\33objref_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
