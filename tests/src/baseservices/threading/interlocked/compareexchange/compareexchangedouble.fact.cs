using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_compareexchange_compareexchangedouble_compareexchangedouble_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchangedouble_compareexchangedouble_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchangedouble\\compareexchangedouble.cmd");
        }
    }
}
