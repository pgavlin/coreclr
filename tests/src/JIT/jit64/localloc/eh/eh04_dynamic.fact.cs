using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_eh_eh04_dynamic_eh04_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_eh_eh04_dynamic_eh04_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\eh\\eh04_dynamic\\eh04_dynamic.cmd");
        }
    }
}
