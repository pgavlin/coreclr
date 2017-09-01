using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_add_CheckAddInt_1_CheckAddInt_1_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_CheckAddInt_1_CheckAddInt_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\CheckAddInt_1\\CheckAddInt_1.cmd");
        }
    }
}
