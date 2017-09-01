using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorConvert_ro_VectorConvert_ro_
    {
        [Fact]
        public void _VectorConvert_ro_VectorConvert_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorConvert_ro\\VectorConvert_ro.cmd");
        }
    }
}
