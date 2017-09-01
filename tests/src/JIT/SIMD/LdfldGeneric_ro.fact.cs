using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _LdfldGeneric_ro_LdfldGeneric_ro_
    {
        [Fact]
        public void _LdfldGeneric_ro_LdfldGeneric_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\LdfldGeneric_ro\\LdfldGeneric_ro.cmd");
        }
    }
}
