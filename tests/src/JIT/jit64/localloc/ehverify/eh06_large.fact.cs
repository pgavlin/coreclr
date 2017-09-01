using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh06_large_eh06_large_
    {
        [Fact]
        public void _localloc_ehverify_eh06_large_eh06_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh06_large\\eh06_large.cmd");
        }
    }
}
