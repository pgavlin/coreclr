using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_add_CheckAddInt_CheckAddInt_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_CheckAddInt_CheckAddInt_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\CheckAddInt\\CheckAddInt.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
