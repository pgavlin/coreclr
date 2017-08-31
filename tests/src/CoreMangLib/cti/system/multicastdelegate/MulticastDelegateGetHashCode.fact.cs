using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_multicastdelegate_MulticastDelegateGetHashCode_MulticastDelegateGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_multicastdelegate_MulticastDelegateGetHashCode_MulticastDelegateGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\multicastdelegate\\MulticastDelegateGetHashCode\\MulticastDelegateGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
