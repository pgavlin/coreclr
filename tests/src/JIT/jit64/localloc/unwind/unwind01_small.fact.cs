using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind01_small_unwind01_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind01_small_unwind01_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind01_small\\unwind01_small.cmd");
        }
    }
}
