using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _threadpool_bindhandle_bindhandlenull_bindhandlenull_
    {
        [OuterLoop]
        [Fact]
        public void _threadpool_bindhandle_bindhandlenull_bindhandlenull_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\threadpool\\bindhandle\\bindhandlenull\\bindhandlenull.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
