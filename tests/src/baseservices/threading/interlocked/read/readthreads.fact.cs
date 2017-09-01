using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_read_readthreads_readthreads_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_read_readthreads_readthreads_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\read\\readthreads\\readthreads.cmd");
        }
    }
}
