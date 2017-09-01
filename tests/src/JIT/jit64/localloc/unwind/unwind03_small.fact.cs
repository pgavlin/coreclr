using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind03_small_unwind03_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind03_small_unwind03_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind03_small\\unwind03_small.cmd");
        }
    }
}
