using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_QFE_b147816_b147816_b147816_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_QFE_b147816_b147816_b147816_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-QFE\\b147816\\b147816\\b147816.cmd");
        }
    }
}
