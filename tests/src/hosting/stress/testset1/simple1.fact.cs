using CoreclrTestLib;
using Xunit;

namespace hosting_stress
{
    class _testset1_simple1_simple1_
    {
        [OuterLoop]
        [Fact]
        public void _testset1_simple1_simple1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("hosting\\stress\\testset1\\simple1\\simple1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
