using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorAbs_r_VectorAbs_r_
    {
        [Fact]
        public void _VectorAbs_r_VectorAbs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorAbs_r\\VectorAbs_r.cmd");
        }
    }
}
