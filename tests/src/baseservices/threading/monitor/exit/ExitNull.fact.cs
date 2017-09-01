using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _monitor_exit_ExitNull_ExitNull_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_exit_ExitNull_ExitNull_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\exit\\ExitNull\\ExitNull.cmd");
        }
    }
}
