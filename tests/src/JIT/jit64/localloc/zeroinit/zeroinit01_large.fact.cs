using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_zeroinit_zeroinit01_large_zeroinit01_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_zeroinit_zeroinit01_large_zeroinit01_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\zeroinit\\zeroinit01_large\\zeroinit01_large.cmd");
        }
    }
}
