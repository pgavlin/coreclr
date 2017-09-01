using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_eh_eh04_large_eh04_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_eh_eh04_large_eh04_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\eh\\eh04_large\\eh04_large.cmd");
        }
    }
}
