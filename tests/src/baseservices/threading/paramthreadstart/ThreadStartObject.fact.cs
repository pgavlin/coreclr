using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_ThreadStartObject_ThreadStartObject_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_ThreadStartObject_ThreadStartObject_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\ThreadStartObject\\ThreadStartObject.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
