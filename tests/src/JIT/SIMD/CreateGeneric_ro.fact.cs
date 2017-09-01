using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _CreateGeneric_ro_CreateGeneric_ro_
    {
        [Fact]
        public void _CreateGeneric_ro_CreateGeneric_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\CreateGeneric_ro\\CreateGeneric_ro.cmd");
        }
    }
}
