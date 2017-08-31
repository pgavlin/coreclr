using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _DeadThreads_DeadThreads_DeadThreads_
    {
        [Fact]
        public void _DeadThreads_DeadThreads_DeadThreads_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\DeadThreads\\DeadThreads\\DeadThreads.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
