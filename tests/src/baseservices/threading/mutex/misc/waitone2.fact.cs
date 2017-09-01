using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _mutex_misc_waitone2_waitone2_
    {
        [OuterLoop]
        [Fact]
        public void _mutex_misc_waitone2_waitone2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\mutex\\misc\\waitone2\\waitone2.cmd");
        }
    }
}
