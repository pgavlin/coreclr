using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_delegate_DelegateCombine1_DelegateCombine1_
    {
        [OuterLoop]
        [Fact]
        public void _system_delegate_DelegateCombine1_DelegateCombine1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\delegate\\DelegateCombine1\\DelegateCombine1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
