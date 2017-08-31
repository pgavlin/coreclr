using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitall_nullarraymember_nullarraymember_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitall_nullarraymember_nullarraymember_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitall\\nullarraymember\\nullarraymember.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
