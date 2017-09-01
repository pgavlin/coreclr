using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorUnused_r_VectorUnused_r_
    {
        [Fact]
        public void _VectorUnused_r_VectorUnused_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorUnused_r\\VectorUnused_r.cmd");
        }
    }
}
