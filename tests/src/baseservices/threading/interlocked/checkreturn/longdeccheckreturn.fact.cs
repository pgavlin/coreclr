using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_checkreturn_longdeccheckreturn_longdeccheckreturn_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_checkreturn_longdeccheckreturn_longdeccheckreturn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\checkreturn\\longdeccheckreturn\\longdeccheckreturn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
