using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorSet_ro_VectorSet_ro_
    {
        [Fact]
        public void _VectorSet_ro_VectorSet_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorSet_ro\\VectorSet_ro.cmd");
        }
    }
}
