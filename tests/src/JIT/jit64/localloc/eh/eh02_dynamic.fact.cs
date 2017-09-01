using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_eh_eh02_dynamic_eh02_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_eh_eh02_dynamic_eh02_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\eh\\eh02_dynamic\\eh02_dynamic.cmd");
        }
    }
}
