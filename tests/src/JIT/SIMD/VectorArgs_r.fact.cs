using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorArgs_r_VectorArgs_r_
    {
        [Fact]
        public void _VectorArgs_r_VectorArgs_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorArgs_r\\VectorArgs_r.cmd");
        }
    }
}
