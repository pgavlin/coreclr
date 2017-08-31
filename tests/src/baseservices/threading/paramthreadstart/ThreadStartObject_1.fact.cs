using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartObject_1_ThreadStartObject_1_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartObject_1_ThreadStartObject_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartObject_1\\ThreadStartObject_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
