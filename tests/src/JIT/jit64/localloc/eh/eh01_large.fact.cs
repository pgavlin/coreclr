using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_eh_eh01_large_eh01_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_eh_eh01_large_eh01_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\eh\\eh01_large\\eh01_large.cmd");
        }
    }
}
