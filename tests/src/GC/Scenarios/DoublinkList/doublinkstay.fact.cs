using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _DoublinkList_doublinkstay_doublinkstay_
    {
        [Fact]
        public void _DoublinkList_doublinkstay_doublinkstay_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\DoublinkList\\doublinkstay\\doublinkstay.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
