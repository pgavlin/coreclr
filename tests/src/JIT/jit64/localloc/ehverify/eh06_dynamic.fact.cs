using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh06_dynamic_eh06_dynamic_
    {
        [Fact]
        public void _localloc_ehverify_eh06_dynamic_eh06_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh06_dynamic\\eh06_dynamic.cmd");
        }
    }
}
