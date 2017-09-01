using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorAdd_ro_VectorAdd_ro_
    {
        [Fact]
        public void _VectorAdd_ro_VectorAdd_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorAdd_ro\\VectorAdd_ro.cmd");
        }
    }
}
