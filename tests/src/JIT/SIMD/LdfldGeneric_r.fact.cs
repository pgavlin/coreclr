using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _LdfldGeneric_r_LdfldGeneric_r_
    {
        [Fact]
        public void _LdfldGeneric_r_LdfldGeneric_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\LdfldGeneric_r\\LdfldGeneric_r.cmd");
        }
    }
}
