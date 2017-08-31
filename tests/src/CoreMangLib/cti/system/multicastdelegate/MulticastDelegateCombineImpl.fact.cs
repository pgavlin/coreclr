using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_multicastdelegate_MulticastDelegateCombineImpl_MulticastDelegateCombineImpl_
    {
        [OuterLoop]
        [Fact]
        public void _system_multicastdelegate_MulticastDelegateCombineImpl_MulticastDelegateCombineImpl_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\multicastdelegate\\MulticastDelegateCombineImpl\\MulticastDelegateCombineImpl.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
