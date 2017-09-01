using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorCast_ro_VectorCast_ro_
    {
        [Fact]
        public void _VectorCast_ro_VectorCast_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorCast_ro\\VectorCast_ro.cmd");
        }
    }
}
