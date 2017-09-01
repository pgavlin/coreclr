using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorCopyToArray_r_VectorCopyToArray_r_
    {
        [Fact]
        public void _VectorCopyToArray_r_VectorCopyToArray_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorCopyToArray_r\\VectorCopyToArray_r.cmd");
        }
    }
}
