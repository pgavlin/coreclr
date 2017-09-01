using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _localloc_zeroinit_zeroinit01_small_zeroinit01_small_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_zeroinit_zeroinit01_small_zeroinit01_small_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\localloc\\zeroinit\\zeroinit01_small\\zeroinit01_small.cmd");
        }
    }
}
