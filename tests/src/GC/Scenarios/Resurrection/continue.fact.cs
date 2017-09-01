using CoreclrTestLib;
using Xunit;

namespace GC_Scenarios
{
    public class _Resurrection_continue_continue_
    {
        [Fact]
        public void _Resurrection_continue_continue_cmd()
        {
            CoreclrTestWrapperLib.RunTest("GC\\Scenarios\\Resurrection\\continue\\continue.cmd");
        }
    }
}
