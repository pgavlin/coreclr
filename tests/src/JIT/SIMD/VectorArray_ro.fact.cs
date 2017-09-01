using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorArray_ro_VectorArray_ro_
    {
        [Fact]
        public void _VectorArray_ro_VectorArray_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorArray_ro\\VectorArray_ro.cmd");
        }
    }
}
