using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    class _DoublinkList_dlbigleakthd_v2_dlbigleakthd_v2_
    {
        [OuterLoop]
        [Fact]
        public void _DoublinkList_dlbigleakthd_v2_dlbigleakthd_v2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("GC\\Scenarios\\DoublinkList\\dlbigleakthd_v2\\dlbigleakthd_v2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
