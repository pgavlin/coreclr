using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _VS_ia64_JIT_M00_b84128_b84128_b84128_
    {
        [OuterLoop]
        [Fact]
        public void _VS_ia64_JIT_M00_b84128_b84128_b84128_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\VS-ia64-JIT\\M00\\b84128\\b84128\\b84128.cmd");
        }
    }
}
