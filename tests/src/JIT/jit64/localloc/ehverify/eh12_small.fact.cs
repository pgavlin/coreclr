using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh12_small_eh12_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh12_small_eh12_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh12_small\\eh12_small.cmd");
        }
    }
}
