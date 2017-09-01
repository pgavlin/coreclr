using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorDiv_ro_VectorDiv_ro_
    {
        [Fact]
        public void _VectorDiv_ro_VectorDiv_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorDiv_ro\\VectorDiv_ro.cmd");
        }
    }
}
