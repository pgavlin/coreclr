using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_delegate_DelegateRemove_DelegateRemove_
    {
        [OuterLoop]
        [Fact]
        public void _system_delegate_DelegateRemove_DelegateRemove_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\delegate\\DelegateRemove\\DelegateRemove.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
