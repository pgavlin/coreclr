using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorDot_ro_VectorDot_ro_
    {
        [Fact]
        public void _VectorDot_ro_VectorDot_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorDot_ro\\VectorDot_ro.cmd");
        }
    }
}
