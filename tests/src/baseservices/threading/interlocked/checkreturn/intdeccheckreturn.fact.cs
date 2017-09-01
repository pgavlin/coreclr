using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_checkreturn_intdeccheckreturn_intdeccheckreturn_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_checkreturn_intdeccheckreturn_intdeccheckreturn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\checkreturn\\intdeccheckreturn\\intdeccheckreturn.cmd");
        }
    }
}
