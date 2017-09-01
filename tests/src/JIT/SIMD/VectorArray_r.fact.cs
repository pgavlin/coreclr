using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorArray_r_VectorArray_r_
    {
        [Fact]
        public void _VectorArray_r_VectorArray_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorArray_r\\VectorArray_r.cmd");
        }
    }
}
