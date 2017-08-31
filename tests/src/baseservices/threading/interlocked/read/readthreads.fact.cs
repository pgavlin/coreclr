using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_read_readthreads_readthreads_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_read_readthreads_readthreads_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\read\\readthreads\\readthreads.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
