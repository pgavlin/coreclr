using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_call_call06_dynamic_call06_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_call_call06_dynamic_call06_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call06_dynamic\\call06_dynamic.cmd");
        }
    }
}
