using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _DeadThreads_DeadThreads_DeadThreads_
    {
        [Fact]
        public void _DeadThreads_DeadThreads_DeadThreads_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\DeadThreads\\DeadThreads\\DeadThreads.cmd");
        }
    }
}
