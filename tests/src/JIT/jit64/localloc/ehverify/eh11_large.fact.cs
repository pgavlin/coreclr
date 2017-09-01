using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh11_large_eh11_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh11_large_eh11_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh11_large\\eh11_large.cmd");
        }
    }
}
