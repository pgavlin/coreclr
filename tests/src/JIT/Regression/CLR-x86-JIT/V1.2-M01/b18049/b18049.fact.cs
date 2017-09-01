using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_2_M01_b18049_b18049_b18049_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_2_M01_b18049_b18049_b18049_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1.2-M01\\b18049\\b18049\\b18049.cmd");
        }
    }
}
