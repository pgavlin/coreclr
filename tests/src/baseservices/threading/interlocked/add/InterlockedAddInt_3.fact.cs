using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_add_InterlockedAddInt_3_InterlockedAddInt_3_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddInt_3_InterlockedAddInt_3_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddInt_3\\InterlockedAddInt_3.cmd");
        }
    }
}
