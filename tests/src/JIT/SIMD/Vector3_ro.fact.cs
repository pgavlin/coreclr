using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Vector3_ro_Vector3_ro_
    {
        [Fact]
        public void _Vector3_ro_Vector3_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Vector3_ro\\Vector3_ro.cmd");
        }
    }
}
