using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _CtorFromArray_ro_CtorFromArray_ro_
    {
        [Fact]
        public void _CtorFromArray_ro_CtorFromArray_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\CtorFromArray_ro\\CtorFromArray_ro.cmd");
        }
    }
}
