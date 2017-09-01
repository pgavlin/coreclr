using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorGet_ro_VectorGet_ro_
    {
        [Fact]
        public void _VectorGet_ro_VectorGet_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorGet_ro\\VectorGet_ro.cmd");
        }
    }
}
