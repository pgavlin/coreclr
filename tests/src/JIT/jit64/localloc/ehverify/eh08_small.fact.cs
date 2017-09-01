using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh08_small_eh08_small_
    {
        [Fact]
        public void _localloc_ehverify_eh08_small_eh08_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh08_small\\eh08_small.cmd");
        }
    }
}
