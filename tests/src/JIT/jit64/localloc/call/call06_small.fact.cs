using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _localloc_call_call06_small_call06_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_call_call06_small_call06_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\localloc\\call\\call06_small\\call06_small.cmd");
        }
    }
}
