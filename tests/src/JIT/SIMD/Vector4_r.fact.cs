using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Vector4_r_Vector4_r_
    {
        [Fact]
        public void _Vector4_r_Vector4_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Vector4_r\\Vector4_r.cmd");
        }
    }
}
