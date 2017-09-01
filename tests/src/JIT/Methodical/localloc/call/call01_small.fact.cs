using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _localloc_call_call01_small_call01_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_call_call01_small_call01_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\localloc\\call\\call01_small\\call01_small.cmd");
        }
    }
}
