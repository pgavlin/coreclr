using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh11_dynamic_eh11_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh11_dynamic_eh11_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh11_dynamic\\eh11_dynamic.cmd");
        }
    }
}
