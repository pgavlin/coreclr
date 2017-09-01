using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh05_dynamic_eh05_dynamic_
    {
        [Fact]
        public void _localloc_ehverify_eh05_dynamic_eh05_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh05_dynamic\\eh05_dynamic.cmd");
        }
    }
}
