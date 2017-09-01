using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh06_small_eh06_small_
    {
        [Fact]
        public void _localloc_ehverify_eh06_small_eh06_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh06_small\\eh06_small.cmd");
        }
    }
}
