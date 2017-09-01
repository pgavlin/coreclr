using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh09_small_eh09_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh09_small_eh09_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh09_small\\eh09_small.cmd");
        }
    }
}
