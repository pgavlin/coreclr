using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh05_large_eh05_large_
    {
        [Fact]
        public void _localloc_ehverify_eh05_large_eh05_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh05_large\\eh05_large.cmd");
        }
    }
}
