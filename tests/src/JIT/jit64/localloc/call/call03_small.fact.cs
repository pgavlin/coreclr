using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_call_call03_small_call03_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_call_call03_small_call03_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call03_small\\call03_small.cmd");
        }
    }
}
