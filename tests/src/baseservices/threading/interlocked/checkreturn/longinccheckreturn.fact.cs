using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_checkreturn_longinccheckreturn_longinccheckreturn_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_checkreturn_longinccheckreturn_longinccheckreturn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\checkreturn\\longinccheckreturn\\longinccheckreturn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
