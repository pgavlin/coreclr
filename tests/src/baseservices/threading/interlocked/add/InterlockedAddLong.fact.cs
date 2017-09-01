using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_add_InterlockedAddLong_InterlockedAddLong_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_add_InterlockedAddLong_InterlockedAddLong_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\add\\InterlockedAddLong\\InterlockedAddLong.cmd");
        }
    }
}
