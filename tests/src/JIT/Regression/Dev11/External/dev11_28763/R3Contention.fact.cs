using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _Dev11_External_dev11_28763_R3Contention_R3Contention_
    {
        [OuterLoop]
        [Fact]
        public void _Dev11_External_dev11_28763_R3Contention_R3Contention_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\External\\dev11_28763\\R3Contention\\R3Contention.cmd");
        }
    }
}
