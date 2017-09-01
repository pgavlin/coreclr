using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind02_large_unwind02_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind02_large_unwind02_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind02_large\\unwind02_large.cmd");
        }
    }
}
