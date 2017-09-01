using CoreclrTestLib;
using Xunit;

namespace JIT_SIMD
{
    public class _AddingSequence_r_AddingSequence_r_
    {
        [Fact]
        public void _AddingSequence_r_AddingSequence_r_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\SIMD\\AddingSequence_r\\AddingSequence_r.cmd");
        }
    }
}
