using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _waithandle_waitany_nullarraymemberwaitany_nullarraymemberwaitany_
    {
        [OuterLoop]
        [Fact]
        public void _waithandle_waitany_nullarraymemberwaitany_nullarraymemberwaitany_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\waithandle\\waitany\\nullarraymemberwaitany\\nullarraymemberwaitany.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
