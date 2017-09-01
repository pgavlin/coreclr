using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _waithandle_misc_waithandledispose2_waithandledispose2_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_misc_waithandledispose2_waithandledispose2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\misc\\waithandledispose2\\waithandledispose2.cmd");
        }
    }
}
