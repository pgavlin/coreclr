using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Vector4_ro_Vector4_ro_
    {
        [Fact]
        public void _Vector4_ro_Vector4_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Vector4_ro\\Vector4_ro.cmd");
        }
    }
}
