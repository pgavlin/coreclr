using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind06_small_unwind06_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind06_small_unwind06_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind06_small\\unwind06_small.cmd");
        }
    }
}
