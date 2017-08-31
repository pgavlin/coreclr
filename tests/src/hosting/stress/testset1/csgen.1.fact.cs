using CoreclrTestLib;
using Xunit;

namespace hosting_stress
{
    class _testset1_csgen_1_csgen_1_
    {
        [OuterLoop]
        [Fact]
        public void _testset1_csgen_1_csgen_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("hosting\\stress\\testset1\\csgen.1\\csgen.1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
