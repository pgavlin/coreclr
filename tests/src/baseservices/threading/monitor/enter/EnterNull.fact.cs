using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _monitor_enter_EnterNull_EnterNull_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_enter_EnterNull_EnterNull_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\enter\\EnterNull\\EnterNull.cmd");
        }
    }
}
