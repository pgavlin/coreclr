using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _Vector3_r_Vector3_r_
    {
        [Fact]
        public void _Vector3_r_Vector3_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\Vector3_r\\Vector3_r.cmd");
        }
    }
}
