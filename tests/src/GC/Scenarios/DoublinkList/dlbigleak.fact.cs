using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _DoublinkList_dlbigleak_dlbigleak_
    {
        [OuterLoop]
        [Fact]
        public void _DoublinkList_dlbigleak_dlbigleak_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\DoublinkList\\dlbigleak\\dlbigleak.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
