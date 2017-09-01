using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorAbs_ro_VectorAbs_ro_
    {
        [Fact]
        public void _VectorAbs_ro_VectorAbs_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorAbs_ro\\VectorAbs_ro.cmd");
        }
    }
}
