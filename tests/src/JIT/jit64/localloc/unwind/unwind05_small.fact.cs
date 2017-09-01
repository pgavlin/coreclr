using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind05_small_unwind05_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind05_small_unwind05_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind05_small\\unwind05_small.cmd");
        }
    }
}
