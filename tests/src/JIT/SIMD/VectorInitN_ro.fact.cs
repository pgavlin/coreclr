using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _VectorInitN_ro_VectorInitN_ro_
    {
        [Fact]
        public void _VectorInitN_ro_VectorInitN_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\VectorInitN_ro\\VectorInitN_ro.cmd");
        }
    }
}
