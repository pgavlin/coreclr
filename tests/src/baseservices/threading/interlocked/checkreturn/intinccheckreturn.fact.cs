using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_checkreturn_intinccheckreturn_intinccheckreturn_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_checkreturn_intinccheckreturn_intinccheckreturn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\checkreturn\\intinccheckreturn\\intinccheckreturn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
