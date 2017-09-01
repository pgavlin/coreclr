using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_eh_eh02_small_eh02_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_eh_eh02_small_eh02_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\eh\\eh02_small\\eh02_small.cmd");
        }
    }
}
