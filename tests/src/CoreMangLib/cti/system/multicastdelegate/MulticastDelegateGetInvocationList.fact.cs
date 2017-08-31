using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_multicastdelegate_MulticastDelegateGetInvocationList_MulticastDelegateGetInvocationList_
    {
        [OuterLoop]
        [Fact]
        public void _system_multicastdelegate_MulticastDelegateGetInvocationList_MulticastDelegateGetInvocationList_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\multicastdelegate\\MulticastDelegateGetInvocationList\\MulticastDelegateGetInvocationList.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
