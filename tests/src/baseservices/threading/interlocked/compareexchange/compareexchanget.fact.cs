using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_compareexchange_compareexchanget_compareexchanget_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchanget_compareexchanget_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchanget\\compareexchanget.cmd");
        }
    }
}
