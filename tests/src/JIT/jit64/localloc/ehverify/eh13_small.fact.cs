using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh13_small_eh13_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh13_small_eh13_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh13_small\\eh13_small.cmd");
        }
    }
}
