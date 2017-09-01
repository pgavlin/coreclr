using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    public class _localloc_zeroinit_zeroInit01_large_zeroInit01_large_
    {
        [OuterLoop]
        [Fact]
        public void _localloc_zeroinit_zeroInit01_large_zeroInit01_large_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Methodical\\localloc\\zeroinit\\zeroInit01_large\\zeroInit01_large.cmd");
        }
    }
}
