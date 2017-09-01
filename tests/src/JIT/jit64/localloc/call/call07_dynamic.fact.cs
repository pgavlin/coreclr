using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_call_call07_dynamic_call07_dynamic_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_call_call07_dynamic_call07_dynamic_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call07_dynamic\\call07_dynamic.cmd");
        }
    }
}
