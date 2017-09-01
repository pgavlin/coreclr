using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind05_large_unwind05_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind05_large_unwind05_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind05_large\\unwind05_large.cmd");
        }
    }
}
