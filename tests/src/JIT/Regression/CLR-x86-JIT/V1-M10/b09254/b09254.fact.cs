using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b09254_b09254_b09254_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b09254_b09254_b09254_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b09254\\b09254\\b09254.cmd");
        }
    }
}
