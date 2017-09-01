using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_add_InterlockedAddInt_2_InterlockedAddInt_2_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddInt_2_InterlockedAddInt_2_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddInt_2\\InterlockedAddInt_2.cmd");
        }
    }
}
