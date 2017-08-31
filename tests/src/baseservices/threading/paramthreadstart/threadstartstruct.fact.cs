using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_threadstartstruct_threadstartstruct_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_threadstartstruct_threadstartstruct_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\threadstartstruct\\threadstartstruct.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
