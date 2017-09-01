using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_checkreturn_longdeccheckreturn_longdeccheckreturn_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_checkreturn_longdeccheckreturn_longdeccheckreturn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\checkreturn\\longdeccheckreturn\\longdeccheckreturn.cmd");
        }
    }
}
