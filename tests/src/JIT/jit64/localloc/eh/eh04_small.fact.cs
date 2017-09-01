using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_eh_eh04_small_eh04_small_
    {
        [Fact]
        public void _localloc_eh_eh04_small_eh04_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\eh\\eh04_small\\eh04_small.cmd");
        }
    }
}
