using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_threadstartclass_threadstartclass_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_threadstartclass_threadstartclass_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\threadstartclass\\threadstartclass.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
