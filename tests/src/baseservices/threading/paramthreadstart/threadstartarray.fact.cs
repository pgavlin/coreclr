using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _paramthreadstart_threadstartarray_threadstartarray_
    {
        [OuterLoop]
        [Fact]
        public void _paramthreadstart_threadstartarray_threadstartarray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\paramthreadstart\\threadstartarray\\threadstartarray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
