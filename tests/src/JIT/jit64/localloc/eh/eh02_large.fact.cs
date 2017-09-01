using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_eh_eh02_large_eh02_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_eh_eh02_large_eh02_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\eh\\eh02_large\\eh02_large.cmd");
        }
    }
}
