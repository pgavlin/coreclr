using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartOperations_1_ThreadStartOperations_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartOperations_1_ThreadStartOperations_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartOperations_1\\ThreadStartOperations_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
