using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_checkreturn_intdeccheckreturn_intdeccheckreturn_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_checkreturn_intdeccheckreturn_intdeccheckreturn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\checkreturn\\intdeccheckreturn\\intdeccheckreturn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
