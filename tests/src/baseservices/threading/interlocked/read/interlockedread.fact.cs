using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_read_interlockedread_interlockedread_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_read_interlockedread_interlockedread_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\read\\interlockedread\\interlockedread.cmd");
        }
    }
}
