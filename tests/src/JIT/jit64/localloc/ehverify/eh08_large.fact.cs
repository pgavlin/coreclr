using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh08_large_eh08_large_
    {
        [Fact]
        public void _localloc_ehverify_eh08_large_eh08_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh08_large\\eh08_large.cmd");
        }
    }
}
