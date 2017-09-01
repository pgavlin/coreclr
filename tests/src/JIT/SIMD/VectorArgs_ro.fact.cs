using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorArgs_ro_VectorArgs_ro_
    {
        [Fact]
        public void _VectorArgs_ro_VectorArgs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorArgs_ro\\VectorArgs_ro.cmd");
        }
    }
}
