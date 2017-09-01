using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorIntEquals_ro_VectorIntEquals_ro_
    {
        [Fact]
        public void _VectorIntEquals_ro_VectorIntEquals_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorIntEquals_ro\\VectorIntEquals_ro.cmd");
        }
    }
}
