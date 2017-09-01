using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _CreateGeneric_r_CreateGeneric_r_
    {
        [Fact]
        public void _CreateGeneric_r_CreateGeneric_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\CreateGeneric_r\\CreateGeneric_r.cmd");
        }
    }
}
