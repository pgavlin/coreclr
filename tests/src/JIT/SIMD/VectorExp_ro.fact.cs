using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorExp_ro_VectorExp_ro_
    {
        [Fact]
        public void _VectorExp_ro_VectorExp_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorExp_ro\\VectorExp_ro.cmd");
        }
    }
}
