using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_compareexchangeint_compareexchangeint_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchangeint_compareexchangeint_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchangeint\\compareexchangeint.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
