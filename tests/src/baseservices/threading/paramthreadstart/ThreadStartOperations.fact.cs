using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _paramthreadstart_ThreadStartOperations_ThreadStartOperations_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartOperations_ThreadStartOperations_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartOperations\\ThreadStartOperations.cmd");
        }
    }
}
