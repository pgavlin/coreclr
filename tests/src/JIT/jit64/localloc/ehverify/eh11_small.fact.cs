using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh11_small_eh11_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh11_small_eh11_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh11_small\\eh11_small.cmd");
        }
    }
}
