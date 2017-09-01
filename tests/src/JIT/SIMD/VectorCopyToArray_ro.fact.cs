using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorCopyToArray_ro_VectorCopyToArray_ro_
    {
        [Fact]
        public void _VectorCopyToArray_ro_VectorCopyToArray_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorCopyToArray_ro\\VectorCopyToArray_ro.cmd");
        }
    }
}
