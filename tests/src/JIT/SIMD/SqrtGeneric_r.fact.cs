using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _SqrtGeneric_r_SqrtGeneric_r_
    {
        [Fact]
        public void _SqrtGeneric_r_SqrtGeneric_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\SqrtGeneric_r\\SqrtGeneric_r.cmd");
        }
    }
}
