using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_compareexchange_compareexchangefloat_compareexchangefloat_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchangefloat_compareexchangefloat_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchangefloat\\compareexchangefloat.cmd");
        }
    }
}
