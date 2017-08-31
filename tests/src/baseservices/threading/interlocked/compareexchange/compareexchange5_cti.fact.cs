using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_compareexchange5_cti_compareexchange5_cti_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchange5_cti_compareexchange5_cti_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchange5_cti\\compareexchange5_cti.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
