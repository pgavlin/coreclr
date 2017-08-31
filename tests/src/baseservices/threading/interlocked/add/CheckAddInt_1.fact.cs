using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_add_CheckAddInt_1_CheckAddInt_1_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_CheckAddInt_1_CheckAddInt_1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\CheckAddInt_1\\CheckAddInt_1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
