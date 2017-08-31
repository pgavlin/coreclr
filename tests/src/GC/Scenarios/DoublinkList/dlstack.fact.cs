using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _DoublinkList_dlstack_dlstack_
    {
        [Fact]
        public void _DoublinkList_dlstack_dlstack_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\DoublinkList\\dlstack\\dlstack.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
