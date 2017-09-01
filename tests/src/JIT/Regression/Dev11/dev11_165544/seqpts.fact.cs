using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _Dev11_dev11_165544_seqpts_seqpts_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_dev11_165544_seqpts_seqpts_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\dev11_165544\\seqpts\\seqpts.cmd");
        }
    }
}
