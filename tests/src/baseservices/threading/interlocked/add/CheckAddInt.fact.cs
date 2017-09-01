using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_add_CheckAddInt_CheckAddInt_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_CheckAddInt_CheckAddInt_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\CheckAddInt\\CheckAddInt.cmd");
        }
    }
}
