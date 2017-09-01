using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _DoublinkList_dlbigleakthd_v2_dlbigleakthd_v2_
    {
        [OuterLoop]
        [Fact]
        public void _DoublinkList_dlbigleakthd_v2_dlbigleakthd_v2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\DoublinkList\\dlbigleakthd_v2\\dlbigleakthd_v2.cmd");
        }
    }
}
