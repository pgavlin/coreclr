using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartOperations_2_ThreadStartOperations_2_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartOperations_2_ThreadStartOperations_2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartOperations_2\\ThreadStartOperations_2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
