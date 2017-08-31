using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_add_CheckAddLong_1_CheckAddLong_1_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_CheckAddLong_1_CheckAddLong_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\CheckAddLong_1\\CheckAddLong_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
