using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_checkreturn_intinccheckreturn_intinccheckreturn_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_checkreturn_intinccheckreturn_intinccheckreturn_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\checkreturn\\intinccheckreturn\\intinccheckreturn.cmd");
        }
    }
}
