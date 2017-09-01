using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _monitor_wait_waitnull_waitnull_
    {
        [OuterLoop]
        [Fact]
        public void _monitor_wait_waitnull_waitnull_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\monitor\\wait\\waitnull\\waitnull.cmd");
        }
    }
}
