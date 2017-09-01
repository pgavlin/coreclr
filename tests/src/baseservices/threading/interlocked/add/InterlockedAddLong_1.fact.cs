using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_add_InterlockedAddLong_1_InterlockedAddLong_1_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddLong_1_InterlockedAddLong_1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddLong_1\\InterlockedAddLong_1.cmd");
        }
    }
}
