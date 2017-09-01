using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh09_large_eh09_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh09_large_eh09_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh09_large\\eh09_large.cmd");
        }
    }
}
