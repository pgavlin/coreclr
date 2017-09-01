using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_eh_eh01_dynamic_eh01_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_eh_eh01_dynamic_eh01_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\eh\\eh01_dynamic\\eh01_dynamic.cmd");
        }
    }
}
