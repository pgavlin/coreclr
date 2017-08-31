using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _DoublinkList_dlcollect_dlcollect_
    {
        [Fact]
        public void _DoublinkList_dlcollect_dlcollect_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\DoublinkList\\dlcollect\\dlcollect.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
