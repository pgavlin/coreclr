using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh13_large_eh13_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh13_large_eh13_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh13_large\\eh13_large.cmd");
        }
    }
}
