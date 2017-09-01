using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorUnused_ro_VectorUnused_ro_
    {
        [Fact]
        public void _VectorUnused_ro_VectorUnused_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorUnused_ro\\VectorUnused_ro.cmd");
        }
    }
}
