using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _DoublinkList_dlcollect_dlcollect_
    {
        [Fact]
        public void _DoublinkList_dlcollect_dlcollect_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\DoublinkList\\dlcollect\\dlcollect.cmd");
        }
    }
}
