using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorInitN_r_VectorInitN_r_
    {
        [Fact]
        public void _VectorInitN_r_VectorInitN_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorInitN_r\\VectorInitN_r.cmd");
        }
    }
}
