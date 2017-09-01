using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind04_large_unwind04_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind04_large_unwind04_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind04_large\\unwind04_large.cmd");
        }
    }
}
