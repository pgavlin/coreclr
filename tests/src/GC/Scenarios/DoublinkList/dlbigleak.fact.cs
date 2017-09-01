using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _DoublinkList_dlbigleak_dlbigleak_
    {
        [OuterLoop]
        [Fact]
        public void _DoublinkList_dlbigleak_dlbigleak_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\DoublinkList\\dlbigleak\\dlbigleak.cmd");
        }
    }
}
