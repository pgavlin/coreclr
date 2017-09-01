using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorIntEquals_r_VectorIntEquals_r_
    {
        [OuterLoop]
        [Fact]
        public void _VectorIntEquals_r_VectorIntEquals_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorIntEquals_r\\VectorIntEquals_r.cmd");
        }
    }
}
