using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_multicastdelegate_MulticastDelegateEquals_MulticastDelegateEquals_
    {
        [OuterLoop]
        [Fact]
        public void _system_multicastdelegate_MulticastDelegateEquals_MulticastDelegateEquals_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\multicastdelegate\\MulticastDelegateEquals\\MulticastDelegateEquals.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
