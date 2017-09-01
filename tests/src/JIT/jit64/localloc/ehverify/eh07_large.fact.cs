using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh07_large_eh07_large_
    {
        [Fact]
        public void _localloc_ehverify_eh07_large_eh07_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh07_large\\eh07_large.cmd");
        }
    }
}
