using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorArrayInit_ro_VectorArrayInit_ro_
    {
        [Fact]
        public void _VectorArrayInit_ro_VectorArrayInit_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorArrayInit_ro\\VectorArrayInit_ro.cmd");
        }
    }
}
