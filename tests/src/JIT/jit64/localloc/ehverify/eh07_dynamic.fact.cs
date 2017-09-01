using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh07_dynamic_eh07_dynamic_
    {
        [Fact]
        public void _localloc_ehverify_eh07_dynamic_eh07_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh07_dynamic\\eh07_dynamic.cmd");
        }
    }
}
