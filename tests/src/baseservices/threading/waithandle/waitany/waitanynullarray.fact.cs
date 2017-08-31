using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitany_waitanynullarray_waitanynullarray_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitany_waitanynullarray_waitanynullarray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitany\\waitanynullarray\\waitanynullarray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
