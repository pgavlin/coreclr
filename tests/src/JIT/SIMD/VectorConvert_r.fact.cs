using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorConvert_r_VectorConvert_r_
    {
        [Fact]
        public void _VectorConvert_r_VectorConvert_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorConvert_r\\VectorConvert_r.cmd");
        }
    }
}
