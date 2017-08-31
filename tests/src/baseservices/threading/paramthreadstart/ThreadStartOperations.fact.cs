using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartOperations_ThreadStartOperations_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartOperations_ThreadStartOperations_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartOperations\\ThreadStartOperations.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
