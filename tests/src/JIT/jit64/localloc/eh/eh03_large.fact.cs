using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_eh_eh03_large_eh03_large_
    {
        [Fact]
        public void _localloc_eh_eh03_large_eh03_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\eh\\eh03_large\\eh03_large.cmd");
        }
    }
}
