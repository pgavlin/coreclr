using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_ehverify_eh13_dynamic_eh13_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_ehverify_eh13_dynamic_eh13_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\ehverify\\eh13_dynamic\\eh13_dynamic.cmd");
        }
    }
}
