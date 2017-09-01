using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind01_large_unwind01_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind01_large_unwind01_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind01_large\\unwind01_large.cmd");
        }
    }
}
