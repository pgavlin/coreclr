using CoreclrTestLib;
using Xunit;

namespace hosting_stress
{
    public class _testset1_simple1_simple1_
    {
        [OuterLoop]
        [Fact]
        public void _testset1_simple1_simple1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("hosting\\stress\\testset1\\simple1\\simple1.cmd");
        }
    }
}
