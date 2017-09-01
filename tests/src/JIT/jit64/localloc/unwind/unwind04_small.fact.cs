using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind04_small_unwind04_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind04_small_unwind04_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind04_small\\unwind04_small.cmd");
        }
    }
}
