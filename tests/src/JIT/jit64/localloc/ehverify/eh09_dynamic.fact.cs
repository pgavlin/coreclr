using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh09_dynamic_eh09_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh09_dynamic_eh09_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh09_dynamic\\eh09_dynamic.cmd");
        }
    }
}
