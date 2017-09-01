using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _CtorFromArray_r_CtorFromArray_r_
    {
        [Fact]
        public void _CtorFromArray_r_CtorFromArray_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\CtorFromArray_r\\CtorFromArray_r.cmd");
        }
    }
}
