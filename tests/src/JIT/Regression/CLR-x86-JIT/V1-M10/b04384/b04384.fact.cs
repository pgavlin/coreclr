using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b04384_b04384_b04384_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b04384_b04384_b04384_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b04384\\b04384\\b04384.cmd");
        }
    }
}
