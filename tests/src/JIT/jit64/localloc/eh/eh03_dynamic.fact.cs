using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_eh_eh03_dynamic_eh03_dynamic_
    {
        [Fact]
        public void _localloc_eh_eh03_dynamic_eh03_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\eh\\eh03_dynamic\\eh03_dynamic.cmd");
        }
    }
}
