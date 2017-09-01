using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_call_call07_small_call07_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_call_call07_small_call07_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call07_small\\call07_small.cmd");
        }
    }
}
