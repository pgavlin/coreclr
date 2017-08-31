using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _AddingSequence_r_AddingSequence_r_
    {
        [Fact]
        public void _AddingSequence_r_AddingSequence_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\AddingSequence_r\\AddingSequence_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
