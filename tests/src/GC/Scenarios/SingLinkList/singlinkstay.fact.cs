using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _SingLinkList_singlinkstay_singlinkstay_
    {
        [Fact]
        public void _SingLinkList_singlinkstay_singlinkstay_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\SingLinkList\\singlinkstay\\singlinkstay.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
