using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_add_CheckAddLong_CheckAddLong_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_CheckAddLong_CheckAddLong_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\CheckAddLong\\CheckAddLong.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
