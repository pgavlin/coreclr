using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorRelOp_ro_VectorRelOp_ro_
    {
        [Fact]
        public void _VectorRelOp_ro_VectorRelOp_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorRelOp_ro\\VectorRelOp_ro.cmd");
        }
    }
}
