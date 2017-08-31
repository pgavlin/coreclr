using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    class _interlocked_compareexchange_compareexchange1_cti_compareexchange1_cti_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchange1_cti_compareexchange1_cti_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchange1_cti\\compareexchange1_cti.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
