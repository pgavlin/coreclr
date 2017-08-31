using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _THDList_thdlist_thdlist_
    {
        [Fact]
        public void _THDList_thdlist_thdlist_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\THDList\\thdlist\\thdlist.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
