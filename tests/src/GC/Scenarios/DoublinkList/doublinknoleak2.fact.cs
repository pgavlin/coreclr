using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _DoublinkList_doublinknoleak2_doublinknoleak2_
    {
        [Fact]
        public void _DoublinkList_doublinknoleak2_doublinknoleak2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\DoublinkList\\doublinknoleak2\\doublinknoleak2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
