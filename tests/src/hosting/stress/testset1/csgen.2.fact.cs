using CoreclrTestLib;
using Xunit;

namespace hosting_stress
{
    class _testset1_csgen_2_csgen_2_
    {
        [OuterLoop]
        [Fact]
        public void _testset1_csgen_2_csgen_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("hosting\\stress\\testset1\\csgen.2\\csgen.2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
