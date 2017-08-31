using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitany_waitanyemptyarray_waitanyemptyarray_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitany_waitanyemptyarray_waitanyemptyarray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitany\\waitanyemptyarray\\waitanyemptyarray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
