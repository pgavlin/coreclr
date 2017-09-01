using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorInit_ro_VectorInit_ro_
    {
        [Fact]
        public void _VectorInit_ro_VectorInit_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorInit_ro\\VectorInit_ro.cmd");
        }
    }
}
