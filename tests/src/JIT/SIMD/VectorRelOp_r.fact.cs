using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorRelOp_r_VectorRelOp_r_
    {
        [Fact]
        public void _VectorRelOp_r_VectorRelOp_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorRelOp_r\\VectorRelOp_r.cmd");
        }
    }
}
