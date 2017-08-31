using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    class _AddingSequence_ro_AddingSequence_ro_
    {
        [Fact]
        public void _AddingSequence_ro_AddingSequence_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\SIMD\\AddingSequence_ro\\AddingSequence_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
