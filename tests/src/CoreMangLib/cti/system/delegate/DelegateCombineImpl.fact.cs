using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_delegate_DelegateCombineImpl_DelegateCombineImpl_
    {
        [OuterLoop]
        [Fact]
        public void _system_delegate_DelegateCombineImpl_DelegateCombineImpl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\delegate\\DelegateCombineImpl\\DelegateCombineImpl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
