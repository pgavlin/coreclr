using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b08172_b08172_b08172_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b08172_b08172_b08172_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b08172\\b08172\\b08172.cmd");
        }
    }
}
