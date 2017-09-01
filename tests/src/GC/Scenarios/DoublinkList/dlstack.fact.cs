using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _DoublinkList_dlstack_dlstack_
    {
        [Fact]
        public void _DoublinkList_dlstack_dlstack_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\DoublinkList\\dlstack\\dlstack.cmd");
        }
    }
}
