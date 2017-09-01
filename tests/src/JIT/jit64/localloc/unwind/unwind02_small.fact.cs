using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind02_small_unwind02_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind02_small_unwind02_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind02_small\\unwind02_small.cmd");
        }
    }
}
