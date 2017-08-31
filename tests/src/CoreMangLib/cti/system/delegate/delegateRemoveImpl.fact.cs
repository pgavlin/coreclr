using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_delegate_delegateRemoveImpl_delegateRemoveImpl_
    {
        [OuterLoop]
        [Fact]
        public void _system_delegate_delegateRemoveImpl_delegateRemoveImpl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\delegate\\delegateRemoveImpl\\delegateRemoveImpl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
