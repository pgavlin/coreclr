using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_misc_waitone1_waitone1_
    {
        [OuterLoop]
        [Fact]
        public void _mutex_misc_waitone1_waitone1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\misc\\waitone1\\waitone1.cmd");
        }
    }
}
