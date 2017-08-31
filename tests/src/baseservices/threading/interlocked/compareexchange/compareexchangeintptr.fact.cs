using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_compareexchangeintptr_compareexchangeintptr_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchangeintptr_compareexchangeintptr_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchangeintptr\\compareexchangeintptr.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
