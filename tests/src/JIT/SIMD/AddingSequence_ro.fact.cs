using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _AddingSequence_ro_AddingSequence_ro_
    {
        [Fact]
        public void _AddingSequence_ro_AddingSequence_ro_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\AddingSequence_ro\\AddingSequence_ro.cmd");
        }
    }
}
