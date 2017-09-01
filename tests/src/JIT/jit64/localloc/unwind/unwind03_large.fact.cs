using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind03_large_unwind03_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind03_large_unwind03_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind03_large\\unwind03_large.cmd");
        }
    }
}
