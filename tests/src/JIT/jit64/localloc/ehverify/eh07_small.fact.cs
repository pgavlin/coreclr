using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh07_small_eh07_small_
    {
        [Fact]
        public void _localloc_ehverify_eh07_small_eh07_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh07_small\\eh07_small.cmd");
        }
    }
}
