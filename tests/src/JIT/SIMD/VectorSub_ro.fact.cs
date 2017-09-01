using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorSub_ro_VectorSub_ro_
    {
        [Fact]
        public void _VectorSub_ro_VectorSub_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorSub_ro\\VectorSub_ro.cmd");
        }
    }
}
