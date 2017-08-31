using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _DoublinkList_dlbigleakthd_dlbigleakthd_
    {
        [Fact]
        public void _DoublinkList_dlbigleakthd_dlbigleakthd_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\DoublinkList\\dlbigleakthd\\dlbigleakthd.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
