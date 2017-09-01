using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_unwind_unwind06_large_unwind06_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_unwind_unwind06_large_unwind06_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\unwind\\unwind06_large\\unwind06_large.cmd");
        }
    }
}
