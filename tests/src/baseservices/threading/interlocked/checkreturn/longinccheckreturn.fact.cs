using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_checkreturn_longinccheckreturn_longinccheckreturn_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_checkreturn_longinccheckreturn_longinccheckreturn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\checkreturn\\longinccheckreturn\\longinccheckreturn.cmd");
        }
    }
}
