using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _CLR_x86_JIT_V1_M10_b04257_b04257_b04257_
    {
        [OuterLoop]
        [Fact]
        public void _CLR_x86_JIT_V1_M10_b04257_b04257_b04257_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\CLR-x86-JIT\\V1-M10\\b04257\\b04257\\b04257.cmd");
        }
    }
}
