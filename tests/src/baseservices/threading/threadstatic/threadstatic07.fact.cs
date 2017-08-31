using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _threadstatic_threadstatic07_threadstatic07_
    {
        [OuterLoop]
        [Fact]
        public void _threadstatic_threadstatic07_threadstatic07_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\threadstatic\\threadstatic07\\threadstatic07.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
