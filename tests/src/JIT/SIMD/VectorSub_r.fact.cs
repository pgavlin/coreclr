using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorSub_r_VectorSub_r_
    {
        [Fact]
        public void _VectorSub_r_VectorSub_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorSub_r\\VectorSub_r.cmd");
        }
    }
}
